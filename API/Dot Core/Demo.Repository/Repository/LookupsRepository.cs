using System.Collections.Generic;
using AutoMapper;
using Demo.Core.DTOs.Response;
using Demo.Core.Interfaces;
using Demo.Core.Model;
using System.Linq;
using Demo.Repository.GenricRepo;

namespace Demo.Repository.Repository
{
    public class LookupsRepository : GenericRepository<Lookup>, ILookupRepository
    {
        private readonly UATDemoPortalContext _dbContext;
        public LookupsRepository(UATDemoPortalContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IEnumerable<GetLookupsDTO> GetLookups(SearchLookupsDTO searchLookupsDTO)
        {
            IEnumerable<GetLookupsDTO> lookupsList = (from l in _dbContext.Lookups
                                                      where l.Category == searchLookupsDTO.Category
                                                      select new GetLookupsDTO
                                                      {
                                                          LookupId = l.LookupId,
                                                          Category = l.Category,
                                                          Description = l.Description
                                                      }).OrderBy(x => x.Description).ToList();
            return lookupsList;
        }
    }
}