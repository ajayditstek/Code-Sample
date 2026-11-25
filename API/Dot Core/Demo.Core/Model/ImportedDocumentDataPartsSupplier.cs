using System;
using System.Collections.Generic;

#nullable disable

namespace Demo.Core.Model
{
    public partial class ImportedDocumentDataPartsSupplier
    {
        public Guid DataId { get; set; }
        public string ImportType { get; set; }
        public string PartsSupplierDealership { get; set; }
        public string PbAccountNumber { get; set; }
        public string PbAccountName { get; set; }
        public DateTime DocumentDate { get; set; }
        public string DocumentType { get; set; }
        public string DocumentNumber { get; set; }
        public string Reference { get; set; }
        public string PartNumber { get; set; }
        public string PartDescription { get; set; }
        public decimal Quantity { get; set; }
        public decimal PriceRetail { get; set; }
        public decimal DiscountPercent { get; set; }
        public decimal PriceInclDiscount { get; set; }
        public decimal PriceExclVat { get; set; }
        public decimal Vat { get; set; }
        public decimal PriceInclVat { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime ModifiedDate { get; set; }
        public DateTime? ProcessedDate { get; set; }
        public string ProcessedStatus { get; set; }
        public string SuppliersNotes { get; set; }
    }
}
