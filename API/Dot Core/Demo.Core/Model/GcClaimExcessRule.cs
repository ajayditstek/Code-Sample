using System;
using System.Collections.Generic;

#nullable disable

namespace Demo.Core.Model
{
    public partial class GcClaimExcessRule
    {
        public Guid ClaimExcessRuleId { get; set; }
        public string ExcessRuleDescription { get; set; }
        public decimal? ExcessRulePercentage { get; set; }
        public decimal? ExcessRuleMinimum { get; set; }
    }
}
