using System;
using System.Collections.Generic;

#nullable disable

namespace Demo.Core.Model
{
    public partial class GcInsurerScheme
    {
        public Guid InsurerId { get; set; }
        public Guid SchemeId { get; set; }
        public string SchemeName { get; set; }
    }
}
