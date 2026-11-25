using System;
using System.Collections.Generic;

#nullable disable

namespace Demo.Core.Model
{
    public partial class GcGlassLookup
    {
        public Guid GlassId { get; set; }
        public string Category { get; set; }
        public string Description { get; set; }
        public string ItemNumber { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string VehicleMake { get; set; }
        public string VehicleModel { get; set; }
        public string YearFrom { get; set; }
        public string YearTo { get; set; }
        public decimal? RetailPrice { get; set; }
        public string Notes { get; set; }
    }
}
