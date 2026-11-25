using System;
using System.Collections.Generic;

#nullable disable

namespace Demo.Core.Model
{
    public partial class Factorer
    {
        public Guid FactorerId { get; set; }
        public string FactorerName { get; set; }
        public string NotificationEmailAddress { get; set; }
        public decimal? Commission { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
    }
}
