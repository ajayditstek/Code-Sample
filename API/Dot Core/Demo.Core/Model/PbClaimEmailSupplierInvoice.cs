using System;
using System.Collections.Generic;

#nullable disable

namespace Demo.Core.Model
{
    public partial class PbClaimEmailSupplierInvoice
    {
        public Guid ClaimEmailSupplierInvoiceId { get; set; }
        public Guid? ClaimId { get; set; }
        public Guid? ClaimEmailId { get; set; }
        public string SupplierCode { get; set; }
        public string SupplierName { get; set; }
        public DateTime? InvoiceDate { get; set; }
        public decimal? InvoiceValue { get; set; }
        public string InvoiceNumber { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string DemoFunded { get; set; }
        public Guid? SupplierId { get; set; }
        public bool? PbsupplierInvoiceMatch { get; set; }
        public string MatchedBy { get; set; }
        public DateTime? MatchedDate { get; set; }
        public Guid? MatchedImportedSupplierDocumentId { get; set; }
    }
}
