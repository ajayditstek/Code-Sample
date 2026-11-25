import { useEffect, useRef, useState } from 'react';
import { useTranslation } from 'react-i18next';
import { useLocation } from 'react-router';

import { useGenerateWidgetTokenMutation } from '@/global-apis/widget-auth-api';
import { useUserAndRoles } from '@/hooks/use-auth';
import { buildSsoBridgeRedirect, isReturnUrlAllowed, isSsoBridgeConfigured } from '@/lib/sso-bridge-origins';
import { Paths } from '@/routes/paths';

type BridgeState = 'checking' | 'minting' | 'error';

const SsoBridgePage: React.FC = () => {
  const { user } = useUserAndRoles();
  const location = useLocation();
  const { t } = useTranslation();
  
  const [generateWidgetToken] = useGenerateWidgetTokenMutation();
  const [state, setState] = useState<BridgeState>('checking');
  const [error, setError] = useState<string>('');
  
  const started = useRef(false);

  useEffect(() => {
    if (started.current) return;

    const params = new URLSearchParams(location.search);
    const returnTo = params.get('return_to');
    const opaqueState = params.get('state');

    if (!isSsoBridgeConfigured()) {
      setState('error');
      setError(t('ssoBridge.notConfigured', 'Single sign-on is not configured for this environment.'));
      return;
    }

    // Validate BEFORE authenticating or minting. A bad return_to should never
    // reach the point of having a token in hand.
    if (!isReturnUrlAllowed(returnTo)) {
      setState('error');
      setError(t('ssoBridge.invalidLink', 'This sign-in link is not valid. Please start again from the site you came from.'));
      return;
    }

    // Not signed in: go to login and come back here with the query intact. Same
    // shape RouteGuard uses, so behaviour matches the rest of the app.
    if (!user) {
      const returnUrl = location.pathname + location.search;
      window.location.replace(`${Paths.LOGIN}?redirect=${encodeURIComponent(returnUrl)}`);
      return;
    }

    started.current = true;
    setState('minting');

    // Read AFTER isReturnUrlAllowed above, deliberately. Rule 2 in the header is
    // that validation happens before anything is minted or authenticated, and the
    // way that ordering erodes is by someone reading "just one more harmless
    // parameter" earlier in the effect.
    //
    // An allowlist of exactly one literal, never a pass-through. `purpose` arrives
    // on a URL that this page hands a live credential to, so the only safe thing to
    // forward is a value we recognise. Anything else - absent, misspelt, or some
    // future value - mints the full payload, which is what every caller other than
    // the Circle SSO login flow needs. Narrowing on a value we do not understand
    // would be the failure mode worth avoiding here; widening is not possible,
    // because `identity` is the only value that removes anything.
    const purpose = params.get('purpose');
    const mintArgs = purpose === 'identity' ? { purpose: 'identity' as const } : undefined;

    generateWidgetToken(mintArgs)
      .unwrap()
      .then((response) => {
        const token = response?.data;
        if (!token) throw new Error('empty token');
        // replace(), not assign(): the bridge must not sit in history where a
        // back-navigation would re-trigger a mint.
        window.location.replace(buildSsoBridgeRedirect(returnTo as string, token, opaqueState));
      })
      .catch(() => {
        // Deliberately generic, and deliberately not the underlying error: this
        // page is reachable by anyone who can guess the URL.
        setState('error');
        setError(t('ssoBridge.failed', 'Could not complete sign-in. Please try again.'));
      });
  }, [user, location.pathname, location.search, generateWidgetToken, t]);

  if (state === 'error') {
    return (
      <div className="flex min-h-screen items-center justify-center p-6">
        <p className="max-w-md text-center text-sm text-muted-foreground">{error}</p>
      </div>
    );
  }

  return (
    <div className="flex min-h-screen items-center justify-center p-6">
      <p className="text-sm text-muted-foreground">{t('ssoBridge.signingIn', 'Signing you in…')}</p>
    </div>
  );
};

export default SsoBridgePage;
