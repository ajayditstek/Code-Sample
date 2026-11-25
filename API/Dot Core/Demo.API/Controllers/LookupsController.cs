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
    public class LookupsController : BaseController
    {
        private readonly ILookupRepository _lookupsRespository;
        private readonly UATDemoPortalContext _dbContext;
        public LookupsController(IHttpContextAccessor httpContext, UATDemoPortalContext dbContext, ILookupRepository lookupsRespository) : base(httpContext)
        {
            _dbContext = dbContext;
            _lookupsRespository = lookupsRespository;
        }

        [Route("GetLookups")]
        [HttpGet]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        [ProducesResponseType(typeof(IEnumerable<GetLookupsDTO>), StatusCodes.Status200OK)]

        public IEnumerable<GetLookupsDTO> GetLookups([FromQuery] SearchLookupsDTO searchLookupsDTO)
        {
            return _lookupsRespository.GetLookups(searchLookupsDTO);
        }

    }
}