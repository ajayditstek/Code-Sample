using System;
using System.Collections.Generic;

#nullable disable

namespace Demo.Core.Model
{
    public partial class GcFitter
    {
        public Guid FitterId { get; set; }
        public Guid FitmentCenterId { get; set; }
        public string FitterName { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime ModifiedDate { get; set; }
        public string NotificationEmailAddress { get; set; }
    }
}
