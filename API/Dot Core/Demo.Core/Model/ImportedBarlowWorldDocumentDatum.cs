using System;
using System.Collections.Generic;

#nullable disable

namespace Demo.Core.Model
{
    public partial class ImportedBarlowWorldDocumentDatum
    {
        public Guid DataId { get; set; }
        public string DemoInvoiceRecordId { get; set; }
        public string Dealership { get; set; }
        public string AccountNumber { get; set; }
        public string AccountName { get; set; }
        public string RtscodeOrPartNumber { get; set; }
        public string Description { get; set; }
        public string Reference { get; set; }
        public decimal PriceInclVat { get; set; }
        public DateTime DocDate { get; set; }
        public string DocumentType { get; set; }
        public string DocumentNumber { get; set; }
        public decimal ExtendedPrice { get; set; }
        public decimal Vat { get; set; }
        public decimal Quantity { get; set; }
        public string Wip { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime ModifiedDate { get; set; }
        public decimal? DiscountRate { get; set; }
        public decimal? OriginalPrice { get; set; }
        public DateTime? ProcessedDate { get; set; }
        public string ProcessedStatus { get; set; }
        public string SuppliersDemoNumber { get; set; }
        public string DemoNumber { get; set; }
        public string SupplierType { get; set; }
        public decimal? DocumentBaseTotal { get; set; }
    }
}
