using System;
using System.Collections.Generic;

#nullable disable

namespace Demo.Core.Model
{
    public partial class PbClient
    {
        public Guid ClientId { get; set; }
        public string ClientName { get; set; }
        public string ClientTradingName { get; set; }
        public string CompanyRegNumber { get; set; }
        public string VatregNumber { get; set; }
        public string ExternalId { get; set; }
        public string TmsclientCode { get; set; }
        public string Email { get; set; }
        public string NotificationEmailAddress { get; set; }
        public string TmsnotificationEmailAddress { get; set; }
        public string TelNumber { get; set; }
        public string FaxNumber { get; set; }
        public string CellNumber { get; set; }
        public string PhysicalAddr1 { get; set; }
        public string PhysicalAddr2 { get; set; }
        public string PhysicalAddr3 { get; set; }
        public string PhysicalAddrCode { get; set; }
        public string PostalAddr1 { get; set; }
        public string PostalAddr2 { get; set; }
        public string PostalAddr3 { get; set; }
        public string PostalAddrCode { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? SyncFlag { get; set; }
        public int? BatchPayments { get; set; }
        public decimal? ContingencyPercent { get; set; }
        public decimal? InterestRate { get; set; }
        public string PaymentNotificationEmail { get; set; }
        public string AccountCode { get; set; }
        public string BankAccountNumber { get; set; }
        public string ClaimAdministrator { get; set; }
        public string ClaimController { get; set; }
        public string BankAllocation { get; set; }
        public decimal? DefaultFunding { get; set; }
        public string LoanAccountCode { get; set; }
        public string Rating { get; set; }
        public bool? OnHold { get; set; }
        public string OnHoldReason { get; set; }
        public string RemittanceContactEmail { get; set; }
        public string RemittanceContactPerson { get; set; }
        public string FinalInvoiceNotificationEmail { get; set; }
        public bool? PayAndClear { get; set; }
        public string Region { get; set; }
        public bool? EnableDeductions { get; set; }
        public Guid? RegionId { get; set; }
        public Guid? CityId { get; set; }
        public Guid? SuburbId { get; set; }
        public string TmsnotificationEmailAddressNewReference { get; set; }
        public string TmsnotificationEmailAddressPartsSummaries { get; set; }
        public bool? DeductionInterestEnabled { get; set; }
        public string DeductionInterestEnabledBy { get; set; }
        public DateTime? DeductionInterestEnabledDate { get; set; }
        public bool? DeductionAodshortPaymentsEnabled { get; set; }
        public string DeductionAodshortPaymentsEnabledBy { get; set; }
        public DateTime? DeductionAodshortPaymentsEnabledDate { get; set; }
        public bool? DeductionInvoiceReclaim90daysEnabled { get; set; }
        public string DeductionInvoiceReclaim90daysEnabledBy { get; set; }
        public DateTime? DeductionInvoiceReclaim90daysEnabledDate { get; set; }
        public bool? DeductionShortPaymentEnabled { get; set; }
        public string DeductionShortPaymentEnabledBy { get; set; }
        public DateTime? DeductionShortPaymentEnabledDate { get; set; }
        public bool? DeductionPaidDirectToPbenabled { get; set; }
        public string DeductionPaidDirectToPbenabledBy { get; set; }
        public DateTime? DeductionPaidDirectToPbenabledDate { get; set; }
        public bool? DeductionCodfeeEnabled { get; set; }
        public string DeductionCodfeeEnabledBy { get; set; }
        public DateTime? DeductionCodfeeEnabledDate { get; set; }
        public bool? PartsPurchasedOnClosedJobsEnabled { get; set; }
        public string PartsPurchasedOnClosedJobsBy { get; set; }
        public DateTime? PartsPurchasedOnClosedJobsDate { get; set; }
        public bool? PartsPurchasedOnClosedJobsWipenabled { get; set; }
        public string PartsPurchasedOnClosedJobsWipby { get; set; }
        public DateTime? PartsPurchasedOnClosedJobsWipdate { get; set; }
        public DateTime? PastelConfirmDate { get; set; }
        public Guid? FactorerId { get; set; }
        public string PartsAuthEmailAddress { get; set; }
        public string BankName { get; set; }
        public string BankBranchCode { get; set; }
        public string BankAccountHolderName { get; set; }
        public bool? IgnoreInsurerRebate { get; set; }
        public string WipalertPerson { get; set; }
        public bool? Legal { get; set; }
        public bool? Active { get; set; }
        public string PartsSummaryAlertPerson { get; set; }
        public string RebateProvisionAccountCode { get; set; }
        public string BankingDetailsModifiedBy { get; set; }
        public DateTime? BankingDetailsModifiedDate { get; set; }
        public string PopUpPartsSummaryAlertPerson { get; set; }
        public string ClaimControllerAlt { get; set; }
    }
}
