using System;
using System.Collections.Generic;

#nullable disable

namespace Demo.Core.Model
{
    public partial class ImportedSupplierCodfeeLineItem
    {
        public Guid CodfeeLineItemId { get; set; }
        public Guid? SupplierId { get; set; }
        public Guid? ClaimId { get; set; }
        public bool? NoCodfee { get; set; }
        public decimal? Codfee { get; set; }
        public decimal? RebatePercent { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public Guid? SupplierDocumentId { get; set; }
    }
}
