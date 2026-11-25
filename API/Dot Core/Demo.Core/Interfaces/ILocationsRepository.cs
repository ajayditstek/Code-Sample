using System.Collections.Generic;
using Demo.Core.DTOs.Response;

namespace Demo.Core.Interfaces
{
    public interface ILocationsRepository
    {
        IEnumerable<GetLocationsDTO> GetLocations(SearchLocationsDTO searchLocationsDTO);
        IEnumerable<GetChildLocationsDTO> GetChildLocations(SearchChildLocationsDTO searchChildLocationsDTO);
    }
}