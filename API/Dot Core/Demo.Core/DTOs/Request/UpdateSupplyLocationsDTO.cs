using System.Collections.Generic;

namespace Demo.Core.DTOs.Request
{
    public class UpdateSupplyLocationsDTO
    {
        public string SupplierId { get; set; }
        public List<SupplyLocation> SupplyLocations { get; set; }
        public string ActionPerformedBy { get; set; }

    }
    public class SupplyLocation
    {
        public string LocationId { get; set; }
        public bool IsAssigned { get; set; }
        public bool IsRemoved { get; set; }
    }
}