using System;
using System.Collections.Generic;

#nullable disable

namespace Demo.Core.Model
{
    public partial class GcBroker
    {
        public Guid BrokerId { get; set; }
        public string BrokerName { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime ModifiedDate { get; set; }
        public string NotificationEmailAddress { get; set; }
    }
}
