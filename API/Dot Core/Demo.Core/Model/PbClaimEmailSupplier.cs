using System;
using System.Collections.Generic;

#nullable disable

namespace Demo.Core.Model
{
    public partial class PbClaimEmailSupplier
    {
        public Guid ClaimEmailSupplierId { get; set; }
        public Guid ClaimEmailId { get; set; }
        public string SupplierCode { get; set; }
        public string SupplierName { get; set; }
        public decimal? EstimatedValue { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string DemoFunded { get; set; }
        public Guid? SupplierId { get; set; }
    }
}
