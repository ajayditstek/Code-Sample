namespace Demo.Core.DTOs.Response
{
    public class GetChildLocationsDTO : GetLocationsDTO
    {
        
    }
    public class SearchChildLocationsDTO
    {
        public string ParentLocationId { get; set; }
    }
}