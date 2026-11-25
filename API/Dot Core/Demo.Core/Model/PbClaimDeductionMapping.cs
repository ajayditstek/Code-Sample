using System;
using System.Collections.Generic;

#nullable disable

namespace Demo.Core.Model
{
    public partial class PbClaimDeductionMapping
    {
        public Guid ClaimDeductionMappingId { get; set; }
        public Guid? ClaimDeductionId { get; set; }
        public Guid? ClaimId { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
    }
}
