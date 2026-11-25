using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Demo.Core.DTOs.Request;
using Demo.Core.DTOs.Response;
using Demo.Core.Interfaces;
using Demo.Core.Model;
using Demo.Repository.Repository;
using System.Net;
using System.Threading.Tasks;

namespace Demo.API.Controllers
{
    [ApiController]
    // [Authorize]
    [Route("api/[Controller]")]
    public class InsurerController : BaseController
    {
        private readonly IInsurerRepository _insurerRepository;
        private readonly UATDemoPortalContext _dbContext;


        public InsurerController(IHttpContextAccessor httpContext, IInsurerRepository insurerRepository, UATDemoPortalContext dbContext) : base(httpContext)
        {
            _insurerRepository = insurerRepository;
            _dbContext = dbContext;
        }

        [Route("AddInsurerRequest")]
        [HttpPost]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        [ProducesResponseType(typeof(ResponseDTO), StatusCodes.Status200OK)]

        public async Task<ResponseDTO> AddInsurerRequestAsync([FromForm] AddInsurerRequestDTO addInsurerRequestDTO)
        {
            // addInsurerRequestDTO.ActionPerformedBy = GetUserId();
            return await _insurerRepository.AddInsurerRequestAsync(addInsurerRequestDTO);
        }
    }
}
