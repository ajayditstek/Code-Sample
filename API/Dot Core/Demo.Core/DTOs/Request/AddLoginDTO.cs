using System;
using Demo.Core.DTOs.Response;

namespace Demo.Core.DTOs.Request
{
    public class AddLoginDTO
    {
        public string UserName { get; set; }
        public string Password { get; set; }
    }

    public class LoginResponseDTO : ResponseDTO
    {
        public string Token { get; set; }
        public string Email { get; set; }
        public Guid UserId { get; set; }
        public Guid? PanelBeaterId { get; set; }
    }
}