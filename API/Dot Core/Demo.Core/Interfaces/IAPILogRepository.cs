using System.Threading.Tasks;
using Demo.Core.DTOs.Request;
using Demo.Core.DTOs.Response;

namespace Demo.Core.Interfaces
{
    public interface IAPILogRepository
    {
        Task<ResponseDTO> AddAPILog(AddAPILogDTO addAPILogDTO);
        Task<ResponseDTO> UpdateAPILog(UpdateAPILogDTO updateAPILogDTO);
    }
}