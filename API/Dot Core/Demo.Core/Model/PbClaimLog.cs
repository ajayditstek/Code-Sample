using System;
using System.Collections.Generic;

#nullable disable

namespace Demo.Core.Model
{
    public partial class PbClaimLog
    {
        public Guid ClaimLogId { get; set; }
        public Guid? ClaimId { get; set; }
        public string Category { get; set; }
        public string Description { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string Notes { get; set; }
    }
}
