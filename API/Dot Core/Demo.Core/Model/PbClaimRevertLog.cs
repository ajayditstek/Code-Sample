using System;
using System.Collections.Generic;

#nullable disable

namespace Demo.Core.Model
{
    public partial class PbClaimRevertLog
    {
        public Guid ClaimRevertLogId { get; set; }
        public Guid ClaimId { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? FinalCostingRequestedDate { get; set; }
        public DateTime? FinalCostingApprovedDate { get; set; }
        public DateTime? FinalInvoiceRequestDate { get; set; }
        public DateTime? FinalInvoiceDate { get; set; }
        public DateTime? FinalInvoiceApprovalDate { get; set; }
        public DateTime? FinalInvoiceCalculatedDate { get; set; }
        public DateTime? FinalInvoiceAuthorisedDate { get; set; }
        public DateTime? PbPartsAuthorisedDate { get; set; }
        public DateTime? PaidDate { get; set; }
        public string InvoiceType { get; set; }
        public Guid? PaymentBatchId { get; set; }
        public decimal? FinalInvoiceAmount { get; set; }
        public decimal? ProductDefinition { get; set; }
        public decimal? ContingencyPercent { get; set; }
        public decimal? BankCharges { get; set; }
        public decimal? AllocationAmount { get; set; }
        public string AllocationReason { get; set; }
        public decimal? FinalInvoiceCodfee { get; set; }
        public decimal? FinalInvoiceSupplierPartsAmount { get; set; }
        public decimal? ShortPayment { get; set; }
        public decimal? Interest { get; set; }
        public decimal? Reclaim { get; set; }
        public decimal? AodshortPayment { get; set; }
        public decimal? PaidDirectToPb { get; set; }
        public decimal? AuthorisedClaimAmount { get; set; }
        public decimal? Codfee { get; set; }
        public decimal? PartsPurchasedClosedJobsWip { get; set; }
        public decimal? PartsPurchasedClosedJobs { get; set; }
        public decimal? FundingAmount { get; set; }
        public decimal? ContingencyAmount { get; set; }
        public decimal? FinalInvoiceAuthorisedAmount { get; set; }
        public decimal? PaymentDueToPb { get; set; }
        public DateTime? FinalInvoicePastelJournalDate { get; set; }
        public Guid? PastelOiReceiptId { get; set; }
        public DateTime? PastelOiReceiptDate { get; set; }
        public DateTime? PastelOiReceiptDateUpdateDate { get; set; }
        public DateTime? FinalInvoiceReversalPastelJournalDate { get; set; }
        public decimal? ContingencyAmountFlat { get; set; }
        public decimal? ClaimAmount { get; set; }
        public string ReverseReason { get; set; }
        public DateTime? FinalInvoicePastelJournalRepostDate { get; set; }
        public DateTime? RevertDate { get; set; }
        public Guid? FactorerId { get; set; }
        public decimal? InsurerDiscountPercentage { get; set; }
        public decimal? InsurerDiscountPercentageAmount { get; set; }
        public decimal? FinalInvoiceAmountNett { get; set; }
    }
}
