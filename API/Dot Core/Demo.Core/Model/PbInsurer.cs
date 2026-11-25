using System;
using System.Collections.Generic;

#nullable disable

namespace Demo.Core.Model
{
    public partial class PbInsurer
    {
        public Guid InsurerId { get; set; }
        public string InsurerName { get; set; }
        public string InsurerTradingName { get; set; }
        public string CompanyRegNumber { get; set; }
        public string VatregNumber { get; set; }
        public string ExternalId { get; set; }
        public string Email { get; set; }
        public string NotificationEmailAddress { get; set; }
        public string BankName { get; set; }
        public string BankBranchName { get; set; }
        public string BankAccountHolder { get; set; }
        public string BankAccountNumber { get; set; }
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
        public int? Confidential { get; set; }
        public string InvoiceRecipient { get; set; }
        public string AccountCode { get; set; }
        public int? PeriodToPay { get; set; }
        public bool? OnHold { get; set; }
        public string OnHoldReason { get; set; }
        public string InsurerType { get; set; }
        public decimal? FixedRebatePercent { get; set; }
        public Guid? InsurerTypeId { get; set; }
        public bool? Obsolete { get; set; }
        public Guid? SelfInsuredCategoryId { get; set; }
        public string ObsoleteReason { get; set; }
        public Guid? ObsoleteMappingId { get; set; }
        public string ClaimNoPrefixText { get; set; }
        public string ClaimNoSufixText { get; set; }
        public bool? ZeroFundingPercent { get; set; }
        public bool? ShowReferringBroker { get; set; }
        public string BankingDetailsModifiedBy { get; set; }
        public DateTime? BankingDetailsModifiedDate { get; set; }
    }
}
