using System;
using System.Collections.Generic;

#nullable disable

namespace Demo.Core.Model
{
    public partial class PbSupplierClaimValidation
    {
        public Guid ClaimId { get; set; }
        public string DemoNumber { get; set; }
        public Guid? SupplierId { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public decimal? ClaimAmount { get; set; }
        public string Notification { get; set; }
        public string ClaimStatus { get; set; }
        public Guid AttemptId { get; set; }
    }
}
