using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;

namespace Demo.API.Controllers
{
    public class BaseController : ControllerBase
    {
        private readonly IHttpContextAccessor _httpContext;
        public BaseController(IHttpContextAccessor httpContext)
        {
            _httpContext = httpContext;
        }
        protected IActionResult BaseResult(int response)
        {
            if (response > 0)
                return Ok();
            else
                return BadRequest();
        }
        protected IActionResult BaseResult<T>(T response)
        {
            if (response != null)
                return Ok(response);
            else
                return BadRequest();
        }
        protected IActionResult CollectionResult<T>(T response)
        {
            return Ok(response);
        }

        protected string GetUserId()
        {
           return _httpContext.HttpContext.User?.Claims.Where(x => x.Type == "Email").Select(x => x.Value).FirstOrDefault().ToString();
        }

        [NonAction]
        protected DateTime GetUserExpiredDateFromToken(string token)
        {
           // token = token.Replace("Bearer ", "");
            var handler = new JwtSecurityTokenHandler();
            var jwtSecurityToken = handler.ReadJwtToken(token);
            DateTime expirydate = jwtSecurityToken.ValidTo.AddHours(5).AddMinutes(30);
            return expirydate;
            //jwtSecurityToken.Claims.FirstOrDefault(x => x.Type == "exp").Value;
        }

    }
}
