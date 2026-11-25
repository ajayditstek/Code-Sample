using System;
using System.Collections.Generic;

#nullable disable

namespace Demo.Core.Model
{
    public partial class ImportedApiSupplierDocument
    {
        public Guid ApisupplierDocumentId { get; set; }
        public Guid SupplierId { get; set; }
        public Guid? ClaimId { get; set; }
        public string DocumentSource { get; set; }
        public string Reference { get; set; }
        public string DocumentType { get; set; }
        public string DocumentNumber { get; set; }
        public DateTime DocumentDate { get; set; }
        public decimal DocumentVat { get; set; }
        public decimal? DocumentValue { get; set; }
        public decimal? DocumentTotal { get; set; }
        public string DemoNumber { get; set; }
        public string ProcessedBy { get; set; }
        public DateTime? ProcessedDate { get; set; }
        public string ProcessStatus { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime ModifiedDate { get; set; }
        public string Notes { get; set; }
        public DateTime? MatchedDate { get; set; }
        public string MatchedBy { get; set; }
        public Guid? MappedImportedSupplierDocumentId { get; set; }
        public Guid? MatchedImportedSupplierDocumentId { get; set; }
    }
}
