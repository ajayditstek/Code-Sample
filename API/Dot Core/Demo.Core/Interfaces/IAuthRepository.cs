using Demo.Core.DTOs.Request;

namespace Demo.Core.Interfaces
{
    public interface IAuthRepository
    {
        LoginResponseDTO AddLogin(AddLoginDTO addLoginDTO);
    }
}