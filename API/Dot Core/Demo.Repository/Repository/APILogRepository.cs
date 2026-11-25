using System.Threading.Tasks;
using Demo.Core.DTOs.Request;
using Demo.Core.DTOs.Response;
using Demo.Core.Interfaces;
using Demo.Core.Model;
using Demo.Repository.Common.StoreProcedures;
using Demo.Repository.GenricRepo;

namespace Demo.Repository.Repository
{
    public class APILogRepository : GenericRepository<APILog>, IAPILogRepository
    {
        public async Task<ResponseDTO> AddAPILog(AddAPILogDTO addAPILogDTO)
        {
            return await CommandAsync<ResponseDTO>(StoreProcedures.AddAPILog, addAPILogDTO);
        }

        public async Task<ResponseDTO> UpdateAPILog(UpdateAPILogDTO updateAPILogDTO)
        {
            return await CommandAsync<ResponseDTO>(StoreProcedures.UpdateAPILog, updateAPILogDTO);
        }
    }
}