using System;

namespace Demo.Core.DTOs.Response
{
    public class GetLookupsDTO
    {
        public Guid LookupId { get; set; }
        public string Category { get; set; }
        public string Description { get; set; }
    }

    public class SearchLookupsDTO
    {
        public string Category { get; set; }
    }

}