using System;
using System.Collections.Generic;

#nullable disable

namespace Demo.Core.Model
{
    public partial class GcBrokersMapping
    {
        public Guid BrokerMappingId { get; set; }
        public Guid BrokerId { get; set; }
        public Guid InsurerId { get; set; }
    }
}
