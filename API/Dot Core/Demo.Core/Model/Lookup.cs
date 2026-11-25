using System;
using System.Collections.Generic;

#nullable disable

namespace Demo.Core.Model
{
    public partial class Lookup
    {
        public Guid LookupId { get; set; }
        public string Category { get; set; }
        public string Description { get; set; }
        public string Value { get; set; }
    }
}
