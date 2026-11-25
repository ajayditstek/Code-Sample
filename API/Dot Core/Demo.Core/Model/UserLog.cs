using System;
using System.Collections.Generic;

#nullable disable

namespace Demo.Core.Model
{
    public partial class UserLog
    {
        public Guid UserLogId { get; set; }
        public string Type { get; set; }
        public string Action { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string Ipaddress { get; set; }
        public string Url { get; set; }
    }
}
