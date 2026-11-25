using System;

namespace Demo.Core.DTOs.Response
{
    public class GetLocationsDTO
    {
        public Guid LocationId { get; set; }
        public string Type { get; set; }
        public string Description { get; set; }
        public Guid? ParentLocationId { get; set; }
    }
    
    public class SearchLocationsDTO
    {
        public string Type { get; set; }
    }
}