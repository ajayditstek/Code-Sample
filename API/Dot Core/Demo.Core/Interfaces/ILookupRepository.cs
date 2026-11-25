using System.Collections.Generic;
using Demo.Core.DTOs.Response;

namespace Demo.Core.Interfaces
{
    public interface ILookupRepository
    {
        IEnumerable<GetLookupsDTO> GetLookups(SearchLookupsDTO searchLookupsDTO);
    }
}