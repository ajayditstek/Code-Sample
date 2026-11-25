using System;
using System.Collections.Generic;

#nullable disable

namespace Demo.Core.Model
{
    public partial class PbClaimSupplier
    {
        public Guid ClaimSupplierId { get; set; }
        public Guid ClaimId { get; set; }
        public Guid SupplierId { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime ModifiedDate { get; set; }
    }
}
