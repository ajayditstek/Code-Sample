using System;
using System.Collections.Generic;

#nullable disable

namespace Demo.Core.Model
{
    public partial class ImportedSupplierDocumentsItem
    {
        public Guid SupplierDocumentsItemId { get; set; }
        public Guid SupplierDocumentId { get; set; }
        public string PartNumber { get; set; }
        public string PartDescription { get; set; }
        public decimal Quantity { get; set; }
        public decimal ItemValue { get; set; }
        public decimal ItemVat { get; set; }
        public decimal ItemTotal { get; set; }
        public decimal RetailPrice { get; set; }
        public decimal DiscountPercent { get; set; }
        public Guid? ImportDataId { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime ModifiedDate { get; set; }
    }
}
