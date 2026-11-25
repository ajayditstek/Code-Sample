using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using Demo.Core.DTOs.Response;
using Demo.Core.Interfaces;
using Demo.Core.Model;
using Demo.Repository.GenricRepo;

namespace Demo.Repository.Repository
{
    public class LocationsRepository : GenericRepository<Location>, ILocationsRepository
    {
        private readonly UATDemoPortalContext _dbContext;
        public LocationsRepository(UATDemoPortalContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IEnumerable<GetChildLocationsDTO> GetChildLocations(SearchChildLocationsDTO searchChildLocationsDTO)
        {
            if(searchChildLocationsDTO.ParentLocationId != null && searchChildLocationsDTO.ParentLocationId != "")
            {
                var childLocations = (from l in _dbContext.Locations
                                      where l.ParentLocationId.ToString() == searchChildLocationsDTO.ParentLocationId
                                      select new GetChildLocationsDTO
                                      {
                                          LocationId = l.LocationId,
                                          Type = l.Type,
                                          Description = l.Description,
                                          ParentLocationId = l.ParentLocationId
                                      }).OrderBy(x => x.Description).ToList();
                return childLocations;
            }
            else
            {
                return new List<GetChildLocationsDTO>();
            }
        }

        public IEnumerable<GetLocationsDTO> GetLocations(SearchLocationsDTO searchLocationsDTO)
        {
            IEnumerable<GetLocationsDTO> locations = (from l in _dbContext.Locations
                                                      where l.Type == searchLocationsDTO.Type
                                                      select new GetLocationsDTO
                                                      {
                                                          LocationId = l.LocationId,
                                                          Type = l.Type,
                                                          Description = l.Description,
                                                           ParentLocationId = l.ParentLocationId
                                                      }).OrderBy(x => x.Description).ToList();
            return locations;
        }
    }
}