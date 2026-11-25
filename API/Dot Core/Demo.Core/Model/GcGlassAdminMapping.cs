using System;
using System.Collections.Generic;

#nullable disable

namespace Demo.Core.Model
{
    public partial class GcGlassAdminMapping
    {
        public Guid GlassAdminMappingId { get; set; }
        public Guid InsurerId { get; set; }
        public Guid GlassAdministratorId { get; set; }
    }
}
