using System;
using System.Collections.Generic;

#nullable disable

namespace Demo.Core.Model
{
    public partial class PbClaimsFactored
    {
        public Guid ClaimId { get; set; }
        public Guid FactorerId { get; set; }
        public DateTime? FactoredDate { get; set; }
        public string NotificationEmailAddress { get; set; }
        public decimal? Commission { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
    }
}
