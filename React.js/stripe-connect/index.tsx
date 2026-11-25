import StripeConnectModal from '@/components/stripe-connect-modal';
import { Button } from '@/components/ui/button';
import { Card, CardContent, CardDescription, CardHeader, CardTitle } from '@/components/ui/card';
import { useUserAndRoles } from '@/hooks/use-auth';
import { CreditCard, DollarSign, TrendingUp } from 'lucide-react';
import { useState } from 'react';
import { useTranslation } from 'react-i18next';

const StripeConnectPage: React.FC = () => {
  const { t } = useTranslation();
  const { user } = useUserAndRoles();
  const [isModalOpen, setIsModalOpen] = useState(false);

  const coachId = user?._id || '';
  const coachName = user?.name || '';

  return (
    <div className="container mx-auto p-6 max-w-4xl">
      <div className="space-y-6">
        {/* Header */}
        <div>
          <h1 className="text-3xl font-bold">{t('stripeConnect.title')}</h1>
          <p className="text-gray-600 mt-2">{t('stripeConnect.description')}</p>
        </div>

        {/* Payment Split Explanation */}
        <Card>
          <CardHeader>
            <CardTitle className="flex items-center gap-2">
              <DollarSign className="w-5 h-5" />
              Payment Split Structure
            </CardTitle>
            <CardDescription>How payments are distributed when clients purchase packages</CardDescription>
          </CardHeader>
          <CardContent className="space-y-4">
            <div className="grid md:grid-cols-2 gap-4">
              <div className="p-4 bg-blue-50 rounded-lg">
                <h4 className="font-semibold text-blue-900 mb-2">Package Purchase</h4>
                <ul className="text-sm text-blue-700 space-y-1">
                  <li>• Client pays €100.00</li>
                  <li>• Stripe fee: €3.50 (3.5%)</li>
                  <li>• Platform receives: €96.50</li>
                </ul>
              </div>

              <div className="p-4 bg-green-50 rounded-lg">
                <h4 className="font-semibold text-green-900 mb-2">Per Appointment</h4>
                <ul className="text-sm text-green-700 space-y-1">
                  <li>• Coach receives: 80%</li>
                  <li>• Platform keeps: 20%</li>
                  <li>• Auto-transferred per booking</li>
                </ul>
              </div>
            </div>

            <div className="p-4 bg-gray-50 rounded-lg">
              <h4 className="font-semibold text-gray-900 mb-2">Example (€100 package, 10 appointments)</h4>
              <div className="text-sm text-gray-700 space-y-1">
                <p>• Per appointment value: €100 ÷ 10 = €10.00</p>
                <p>• Coach gets: €10.00 × 80% = €8.00 per appointment</p>
                <p>• Total coach earnings: €8.00 × 10 = €80.00</p>
                <p>• Platform keeps: €16.50 (after Stripe fees)</p>
              </div>
            </div>
          </CardContent>
        </Card>

        {/* Setup Card */}
        <Card>
          <CardHeader>
            <CardTitle className="flex items-center gap-2">
              <CreditCard className="w-5 h-5" />
              Connect Your Stripe Account
            </CardTitle>
            <CardDescription>Required to receive payments for your coaching sessions</CardDescription>
          </CardHeader>
          <CardContent className="space-y-4">
            <div className="flex items-start gap-3 p-4 bg-yellow-50 rounded-lg">
              <TrendingUp className="w-5 h-5 text-yellow-600 mt-0.5" />
              <div>
                <h4 className="font-medium text-yellow-900">Setup Required</h4>
                <p className="text-sm text-yellow-700 mt-1">
                  Connect your Stripe account to start receiving payments. This is a one-time setup that takes about 5 minutes.
                </p>
              </div>
            </div>

            <div className="space-y-3">
              <h5 className="font-medium text-sm">What you'll need:</h5>
              <ul className="list-disc list-inside space-y-1 text-sm text-gray-600">
                <li>Business or personal information</li>
                <li>Bank account details for payouts</li>
                <li>Tax information (EIN or SSN)</li>
                <li>Government-issued ID</li>
              </ul>
            </div>

            <Button onClick={() => setIsModalOpen(true)} size="lg" className="w-full md:w-auto">
              Setup Stripe Account
            </Button>
          </CardContent>
        </Card>

        {/* Benefits Card */}
        <Card>
          <CardHeader>
            <CardTitle>Benefits of Stripe Connect</CardTitle>
          </CardHeader>
          <CardContent>
            <ul className="space-y-2 text-sm">
              <li className="flex items-start gap-2">
                <span className="text-green-600 mt-1">✓</span>
                <span>Automatic payment splitting - no manual transfers needed</span>
              </li>
              <li className="flex items-start gap-2">
                <span className="text-green-600 mt-1">✓</span>
                <span>Secure payment processing with industry-leading protection</span>
              </li>
              <li className="flex items-start gap-2">
                <span className="text-green-600 mt-1">✓</span>
                <span>Track all your earnings in the Stripe Dashboard</span>
              </li>
              <li className="flex items-start gap-2">
                <span className="text-green-600 mt-1">✓</span>
                <span>Fast payouts directly to your bank account</span>
              </li>
              <li className="flex items-start gap-2">
                <span className="text-green-600 mt-1">✓</span>
                <span>Detailed transaction history and reporting</span>
              </li>
            </ul>
          </CardContent>
        </Card>
      </div>

      {/* Stripe Connect Modal */}
      <StripeConnectModal open={isModalOpen} onOpenChange={setIsModalOpen} coachId={coachId} coachName={coachName} />
    </div>
  );
};

export default StripeConnectPage;
