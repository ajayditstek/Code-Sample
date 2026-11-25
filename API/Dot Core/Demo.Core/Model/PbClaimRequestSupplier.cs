using System;
using System.Collections.Generic;

#nullable disable

namespace Demo.Core.Model
{
    public partial class PbClaimRequestSupplier
    {
        public Guid ClaimRequestSupplierId { get; set; }
        public Guid? ClaimRequestId { get; set; }
        public Guid? SupplierId { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
    }
}
