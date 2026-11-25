using System;
using System.Collections.Generic;

#nullable disable

namespace Demo.Core.Model
{
    public partial class ImportedSupplierDocumentsPdf
    {
        public Guid SupplierDocumentId { get; set; }
        public string DocumentType { get; set; }
        public byte[] DocumentData { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string DocumentNumber { get; set; }
        public string Supplier { get; set; }
    }
}
