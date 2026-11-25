using System;
using System.Collections.Generic;

#nullable disable

namespace Demo.Core.Model
{
    public partial class PastelSdklog
    {
        public Guid Id { get; set; }
        public string PastelCall { get; set; }
        public string PastelDataString { get; set; }
        public string Pastelresult { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public string Category { get; set; }
        public string ProjectCode { get; set; }
    }
}
