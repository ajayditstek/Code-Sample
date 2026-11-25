using Demo.Core.DTOs.Request;
using Demo.Core.DTOs.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Core.Interfaces
{
    public interface IInsurerRepository
    {
        Task<ResponseDTO> AddInsurerRequestAsync(AddInsurerRequestDTO addInsurerRequestDTO);
    }
}
