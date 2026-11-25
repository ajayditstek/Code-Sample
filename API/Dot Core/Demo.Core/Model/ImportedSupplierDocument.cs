using System;
using System.Collections.Generic;

#nullable disable

namespace Demo.Core.Model
{
    public partial class ImportedSupplierDocument
    {
        public Guid SupplierDocumentId { get; set; }
        public string PortalSystem { get; set; }
        public Guid SupplierId { get; set; }
        public Guid? ClaimId { get; set; }
        public string DocumentSource { get; set; }
        public string Reference { get; set; }
        public string DocumentNumber { get; set; }
        public DateTime DocumentDate { get; set; }
        public decimal DocumentVat { get; set; }
        public decimal? DocumentValue { get; set; }
        public decimal? DocumentTotal { get; set; }
        public string DemoNumber { get; set; }
        public DateTime? ProcessedToFame { get; set; }
        public string ProcessedBy { get; set; }
        public DateTime? ProcessedDate { get; set; }
        public string ProcessStatus { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime ModifiedDate { get; set; }
        public string DocumentType { get; set; }
        public string ProcessedToFameStatus { get; set; }
        public string HardCopyReceivedBy { get; set; }
        public DateTime? HardCopyReceivedDate { get; set; }
        public string OmitText { get; set; }
        public int? FinalInvoicesToClaim { get; set; }
        public bool? FullyReclaimed { get; set; }
        public string DemoNumberFame { get; set; }
        public Guid? CreditNoteReference { get; set; }
        public Guid? SupplierCodbatchReference { get; set; }
        public DateTime? InvoicePaidDate { get; set; }
        public string InvoicePaidBy { get; set; }
        public DateTime? PastelConfirmDate { get; set; }
        public string PastelConfirmComments { get; set; }
        public DateTime? PastelOiReceiptDate { get; set; }
        public DateTime? PastelOiReceiptDateUpdateDate { get; set; }
        public string Notes { get; set; }
    }
}
