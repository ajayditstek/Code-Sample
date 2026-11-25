import { API_URLS } from '@/config/api-urls';
import { api } from '@/services/api-interceptor';

// Request/Response Types
export interface GetConnectStatusRequest {
  coachId: string;
}

export interface ConnectStatusResponse {
  status: boolean;
  message: string;
  data: {
    hasConnectAccount: boolean;
    stripeConnectAccountId?: string;
    isOnboarded: boolean;
    payoutsEnabled?: boolean;
    chargesEnabled?: boolean;
    detailsSubmitted?: boolean;
    message: string;
  };
}

export interface CreateConnectAccountRequest {
  coachId: string;
  country?: string;
}

export interface CreateConnectAccountResponse {
  status: boolean;
  message: string;
  data?: {
    accountId: string;
    coachId: string;
    coachName: string;
  };
  error?: string;
}

export interface GetOnboardingLinkRequest {
  coachId: string;
}

export interface OnboardingLinkResponse {
  status: boolean;
  message: string;
  data: {
    url: string;
    expiresAt?: string;
    coachId: string;
  };
}

export interface GetDashboardLinkRequest {
  coachId: string;
}

export interface DashboardLinkResponse {
  status: boolean;
  message: string;
  data: {
    url: string;
    coachId: string;
  };
}

// Payment Split Types
export interface PaymentSplitRecord {
  _id: string;
  splitType: string;
  status: string;
  clientId: {
    _id: string;
    firstName: string;
    lastName: string;
    email: string;
  };
  coachId?: {
    _id: string;
    firstName: string;
    lastName: string;
    email: string;
  };
  packageId?: {
    _id: string;
    title: string;
  };
  purchasedPackageId?: {
    _id: string;
    payableAmount: number;
    totalAppointments: number;
    packageId: {
      _id: string;
      title: string;
    };
  };
  grossAmount: number;
  stripeFee: number;
  netAmount: number;
  coachShareAmount: number;
  platformShareAmount: number;
  coachSharePercentage: number;
  platformSharePercentage: number;
  currency: string;
  description: string;
  createdAt: string;
}

export interface GetPaymentSplitRecordsRequest {
  page?: number;
  limit?: number;
  search?: string;
  sortField?: string;
  sortOrder?: string;
  paymentFor?: string;
}

export interface PaymentSplitRecordsResponse {
  status: boolean;
  message: string;
  data: {
    records: PaymentSplitRecord[];
    total: number;
    page: number;
    limit: number;
    totalPages: number;
  };
}

export interface GetPaymentSplitSummaryRequest {
  startDate?: string;
  endDate?: string;
  coachId?: string;
}

export interface PaymentSplitSummaryResponse {
  status: boolean;
  message: string;
  data: {
    summary: {
      _id: null;
      totalGrossAmount: number;
      totalNetAmount: number;
      totalStripeFees: number;
      totalCoachShare: number;
      totalPlatformShare: number;
      totalTransactions: number;
      avgCoachSharePercentage: number;
    };
    byType: Array<{
      _id: string;
      count: number;
      totalGrossAmount: number;
      totalCoachShare: number;
      totalPlatformShare: number;
    }>;
    byCoach: Array<{
      _id: string;
      count: number;
      totalCoachShare: number;
      totalPlatformShare: number;
      coachId: string;
      coachName: string;
      coachEmail: string;
    }>;
  };
}

export interface GetPaymentSplitByIdRequest {
  id: string;
}

export interface PaymentSplitByIdResponse {
  status: boolean;
  message: string;
  data: PaymentSplitRecord & {
    stripeConnectAccountId?: string;
    metadata?: any;
    purchasedPackageId?: any; // Detailed object
  };
}

export interface GetPackagePaymentBreakdownRequest {
  purchasedPackageId?: string;
}

export interface PackagePaymentBreakdownResponse {
  status: boolean;
  message: string;
  data: {
    package: {
      id: string;
      title: string;
      name: string;
      originalPrice: number;
      totalAppointments: number;
      remainingAppointments: number;
      appointmentsUsed: number;
      purchasedBy: {
        _id: string;
        firstName: string;
        lastName: string;
        email: string;
      };
      purchaseDate: string;
      expiryDate: string;
      isExpired: boolean;
    };
    purchase: PaymentSplitRecord;
    transfers: any[];
    summary: {
      totalTransferredToCoaches: number;
      totalPlatformEarned: number;
      appointmentsUsed: number;
      appointmentsRemaining: number;
      perAppointmentValue: number;
      projectedTotalCoachPayout: number;
      projectedTotalPlatformEarning: number;
    };
  };
}

const stripeConnectApi = api.injectEndpoints({
  endpoints: (builder) => ({
    // Get Coach Connect Status
    getCoachConnectStatus: builder.query<ConnectStatusResponse, GetConnectStatusRequest>({
      query: (payload) => ({
        url: API_URLS.GET_COACH_CONNECT_STATUS,
        method: 'POST',
        body: payload,
      }),
      providesTags: ['Stripe'],
    }),

    // Create Connect Account
    createCoachConnectAccount: builder.mutation<CreateConnectAccountResponse, CreateConnectAccountRequest>({
      query: (payload) => ({
        url: API_URLS.CREATE_COACH_CONNECT_ACCOUNT,
        method: 'POST',
        body: payload,
      }),
    }),

    // Get Onboarding Link
    getCoachConnectOnboardingLink: builder.mutation<OnboardingLinkResponse, GetOnboardingLinkRequest>({
      query: (payload) => ({
        url: API_URLS.GET_COACH_CONNECT_ONBOARDING_LINK,
        method: 'POST',
        body: payload,
      }),
    }),

    // Get Dashboard Link
    getCoachConnectDashboardLink: builder.mutation<DashboardLinkResponse, GetDashboardLinkRequest>({
      query: (payload) => ({
        url: API_URLS.GET_COACH_CONNECT_DASHBOARD_LINK,
        method: 'POST',
        body: payload,
      }),
    }),

    // Get Payment Split Records
    getPaymentSplitRecords: builder.mutation<PaymentSplitRecordsResponse, GetPaymentSplitRecordsRequest>({
      query: (payload) => ({
        url: API_URLS.GET_PAYMENT_SPLIT_RECORDS,
        method: 'POST',
        body: payload,
      }),
    }),

    // Get Payment Split Summary
    getPaymentSplitSummary: builder.mutation<PaymentSplitSummaryResponse, GetPaymentSplitSummaryRequest>({
      query: (payload) => ({
        url: API_URLS.GET_PAYMENT_SPLIT_SUMMARY,
        method: 'POST',
        body: payload,
      }),
    }),

    // Get Payment Split By ID
    getPaymentSplitById: builder.mutation<PaymentSplitByIdResponse, GetPaymentSplitByIdRequest>({
      query: (payload) => ({
        url: API_URLS.GET_PAYMENT_SPLIT_BY_ID,
        method: 'POST',
        body: payload,
      }),
    }),

    // Get Package Payment Breakdown
    getPackagePaymentBreakdown: builder.mutation<PackagePaymentBreakdownResponse, GetPackagePaymentBreakdownRequest>({
      query: (payload) => ({
        url: API_URLS.GET_PACKAGE_PAYMENT_BREAKDOWN,
        method: 'POST',
        body: payload,
      }),
    }),
  }),
});

export const {
  useGetCoachConnectStatusQuery,
  useLazyGetCoachConnectStatusQuery,
  useCreateCoachConnectAccountMutation,
  useGetCoachConnectOnboardingLinkMutation,
  useGetCoachConnectDashboardLinkMutation,
  useGetPaymentSplitRecordsMutation,
  useGetPaymentSplitSummaryMutation,
  useGetPaymentSplitByIdMutation,
  useGetPackagePaymentBreakdownMutation,
} = stripeConnectApi;
