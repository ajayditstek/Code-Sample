using System.Collections.Generic;
using System.Net;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Demo.Core.DTOs.Response;
using Demo.Core.Interfaces;
using Demo.Core.Model;

namespace Demo.API.Controllers
{
    [ApiController]
    // [Authorize]
    [Route("api/[Controller]")]
    public class LocationsController : BaseController
    {
        private readonly ILocationsRepository _locationsRespository;
        private readonly UATDemoPortalContext _dbContext;
        public LocationsController(IHttpContextAccessor httpContext, UATDemoPortalContext dbContext, ILocationsRepository locationsRespository) : base(httpContext)
        {
            _dbContext = dbContext;
            _locationsRespository = locationsRespository;
        }

        [Route("GetLocations")]
        [HttpGet]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        [ProducesResponseType(typeof(IEnumerable<GetLocationsDTO>), StatusCodes.Status200OK)]

        public IEnumerable<GetLocationsDTO> GetLocations([FromQuery] SearchLocationsDTO searchLocationsDTO)
        {
            return _locationsRespository.GetLocations(searchLocationsDTO);
        }
        [Route("GetChildLocations")]
        [HttpGet]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        [ProducesResponseType(typeof(IEnumerable<GetChildLocationsDTO>), StatusCodes.Status200OK)]

        public IEnumerable<GetChildLocationsDTO> GetChildLocations([FromQuery] SearchChildLocationsDTO searchChildLocationsDTO)
        {
            return _locationsRespository.GetChildLocations(searchChildLocationsDTO);
        }
    }
}