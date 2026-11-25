using System;
using System.Collections.Generic;

#nullable disable

namespace Demo.Core.Model
{
    public partial class TempCacheLog
    {
        public Guid CacheLogId { get; set; }
        public DateTime CreatedDate { get; set; }
        public string Ipaddress { get; set; }
    }
}
