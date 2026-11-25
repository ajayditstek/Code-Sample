using Microsoft.AspNetCore.Http;
using Demo.Core.Interfaces;
using Demo.Core.Model;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using Demo.Core.DTOs.Request;

namespace Demo.API.Controllers
{
    [ApiController]
    // [Authorize]
    [Route("api/[Controller]")]
    public class AuthController : BaseController
    {
        private readonly IAuthRepository _authRepository;
        private readonly UATDemoPortalContext _dbContext;

        public AuthController(IHttpContextAccessor httpContext, UATDemoPortalContext dbContext, IAuthRepository authRepository) : base(httpContext)
        {
            _authRepository = authRepository;
            _dbContext = dbContext;
        }

        [Route("Login")]
        [HttpPost]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        [ProducesResponseType(typeof(LoginResponseDTO), StatusCodes.Status200OK)]

        public LoginResponseDTO AddLogin([FromBody] AddLoginDTO addLoginDTO)
        {
            return  _authRepository.AddLogin(addLoginDTO);
        }
    }
}
