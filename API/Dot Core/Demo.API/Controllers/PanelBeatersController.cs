using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Demo.Core.DTOs.Request;
using Demo.Core.DTOs.Response;
using Demo.Core.Interfaces;
using Demo.Core.Model;

namespace Demo.API.Controllers
{
    [ApiController]
    // [Authorize]
    [Route("api/[Controller]")]
    public class PanelBeatersController : BaseController
    {
        private readonly IPanelBeatersRepository _panelBeatersRepository;
        private readonly UATDemoPortalContext _dbContext;
        public PanelBeatersController(IHttpContextAccessor httpContext, UATDemoPortalContext dbContext, IPanelBeatersRepository panelBeatersRepository) : base(httpContext)
        {
            _dbContext = dbContext;
            _panelBeatersRepository = panelBeatersRepository;
        }

        [Route("AddPanelBeaterClient")]
        [HttpPost]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        [ProducesResponseType(typeof(ResponseDTO), StatusCodes.Status200OK)]

        public async Task<ResponseDTO> AddPanelBeaterClientAsync([FromBody] AddPanelBeaterClientDTO addPanelBeaterClientDTO)
        {
            // addPanelBeaterClientDTO.ActionPerformedBy = GetUserId();
            return await _panelBeatersRepository.AddPanelBeaterClientAsync(addPanelBeaterClientDTO);
        }

        [Route("AssignSupplierToPanelBeater")]
        [HttpPost]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        [ProducesResponseType(typeof(ResponseDTO), StatusCodes.Status200OK)]

        public async Task<ResponseDTO> AssignSupplierToPanelBeaterAsync([FromBody] AssignSupplierToPanelBeaterDTO assignSupplierToPanelBeaterDTO)
        {
            // addPanelBeaterClientDTO.ActionPerformedBy = GetUserId();
            return await _panelBeatersRepository.AssignSupplierToPanelBeaterAsync(assignSupplierToPanelBeaterDTO);
        }

        [Route("UpdatePanelBeaterClient")]
        [HttpPut]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        [ProducesResponseType(typeof(ResponseDTO), StatusCodes.Status200OK)]

        public async Task<ResponseDTO> UpdatePanelBeaterClientAsync([FromBody] UpdatePanelBeaterClientDTO updatePanelBeaterClientDTO)
        {
            // updatePanelBeaterClientDTO.ActionPerformedBy = GetUserId();
            return await _panelBeatersRepository.UpdatePanelBeaterClientAsync(updatePanelBeaterClientDTO);
        }
        [Route("UpdatePanelBeaterClientSupplier")]
        [HttpPut]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        [ProducesResponseType(typeof(ResponseDTO), StatusCodes.Status200OK)]

        public async Task<ResponseDTO> UpdatePanelBeaterClientSupplierAsync([FromBody] UpdatePanelBeaterClientSupplierDTO updatePanelBeaterClientSupplierDTO)
        {
            // updatePanelBeaterClientSupplierDTO.ActionPerformedBy = GetUserId();
            return await _panelBeatersRepository.UpdatePanelBeaterClientSupplierAsync(updatePanelBeaterClientSupplierDTO);
        }

        [Route("UpdateSupplierEmailAddress")]
        [HttpPut]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        [ProducesResponseType(typeof(ResponseDTO), StatusCodes.Status200OK)]

        public async Task<ResponseDTO> UpdateSupplierNotificationEmailAsync([FromBody] UpdateSupplierNotificationEmailDTO updateSupplierNotificationEmailDTO)
        {
            // updateSupplierNotificationEmailDTO.ActionPerformedBy = GetUserId();
            return await _panelBeatersRepository.UpdateSupplierNotificationEmailAsync(updateSupplierNotificationEmailDTO);
        }

        [Route("UpdateClientEmailAddresses")]
        [HttpPut]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        [ProducesResponseType(typeof(ResponseDTO), StatusCodes.Status200OK)]

        public async Task<ResponseDTO> UpdateClientEmailAddressesAsync([FromBody] UpdateClientEmailAddressesDTO updateClientEmailAddressesDTO)
        {
            // updateClientEmailAddressesDTO.ActionPerformedBy = GetUserId();
            return await _panelBeatersRepository.UpdateClientEmailAddressesAsync(updateClientEmailAddressesDTO);
        }

        [Route("GetPanelBeaterClients")]
        [HttpGet]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        [ProducesResponseType(typeof(IEnumerable<GetPanelBeaterClientsDTO>), StatusCodes.Status200OK)]

        public IEnumerable<GetPanelBeaterClientsDTO> GetPanelBeaterClients([FromQuery]SearchPanelBeaterClientsDTO searchPanelBeaterClientsDTO)
        {
            return _panelBeatersRepository.GetPanelBeaterClients(searchPanelBeaterClientsDTO);
        }

        [Route("GetUnassignedSuppliers")]
        [HttpPost]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        [ProducesResponseType(typeof(IEnumerable<GetUnassignedSuppliersDTO>), StatusCodes.Status200OK)]

        public  async Task<GetUnassignedSuppliersDataDTO> GetUnassignedSuppliersAsync([FromBody] SearchUnassignedSuppliersDTO searchUnassignedSuppliersDTO)
        {
            return await _panelBeatersRepository.GetUnassignedSuppliersAsync(searchUnassignedSuppliersDTO);
        }

        [Route("GetFactors")]
        [HttpGet]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        [ProducesResponseType(typeof(IEnumerable<GetFundedByDTO>), StatusCodes.Status200OK)]
        public IEnumerable<GetFundedByDTO> GetFactors()
        {
            return _panelBeatersRepository.GetFactors();
        }

        [Route("GetDefaultFundings")]
        [HttpGet]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        [ProducesResponseType(typeof(IEnumerable<GetDefaultFundingDTO>), StatusCodes.Status200OK)]
        public IEnumerable<GetDefaultFundingDTO> GetDefaultFundings()
        {
            return _panelBeatersRepository.GetDefaultFundings();
        }

        [Route("GetPanelBeaterDropdowns")]
        [HttpGet]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        [ProducesResponseType(typeof(IEnumerable<GetPanelBeaterDropdownDTO>), StatusCodes.Status200OK)]

        public Task<IEnumerable<GetPanelBeaterDropdownDTO>> GetPanelBeaterDropdownsAsync([FromQuery] SearchPanelBeaterDropdownDTO searchPanelBeaterDropdownDTO)
        {
            return _panelBeatersRepository.GetPanelBeaterDropdownsAsync(searchPanelBeaterDropdownDTO);
        }
        
        [Route("GetPanelBeaterAssignedSuppliers")]
        [HttpGet]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        [ProducesResponseType(typeof(IEnumerable<GetPanelBeaterAssignedSuppliersDTO>), StatusCodes.Status200OK)]

        public Task<IEnumerable<GetPanelBeaterAssignedSuppliersDTO>> GetPanelBeaterAssignedSuppliersAsync([FromQuery] SearchPanelBeaterAssignedSuppliersDTO searchPanelBeaterAssignedSuppliersDTO)
        {
            return _panelBeatersRepository.GetPanelBeaterAssignedSuppliersAsync(searchPanelBeaterAssignedSuppliersDTO);
        }


        [Route("GetPanelBeaterClientDetails")]
        [HttpGet]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        [ProducesResponseType(typeof(GetPanelBeaterClientDetailsDTO), StatusCodes.Status200OK)]

        public GetPanelBeaterClientDetailsDTO GetPanelBeaterClientDetails([FromQuery] SearchPanelBeaterClientDeatilsDTO searchPanelBeaterClientDeatilsDTO)
        {
            return _panelBeatersRepository.GetPanelBeaterClientDetails(searchPanelBeaterClientDeatilsDTO);
        }

        [Route("GetNextPanelBeaterClientExternalId")]
        [HttpGet]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        [ProducesResponseType(typeof(GetNextPanelBeaterClientExternalIdDTO), StatusCodes.Status200OK)]

        public GetNextPanelBeaterClientExternalIdDTO GetNextPanelBeaterClientExternalId()
        {
            return _panelBeatersRepository.GetNextPanelBeaterClientExternalId();
        }

        [Route("UnassignSupplier")]
        [HttpDelete]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        [ProducesResponseType(typeof(ResponseDTO), StatusCodes.Status200OK)]

        public async Task<ResponseDTO> UnassignSupplierAsync([FromQuery] UnassignPanelBeaterSupplierDTO unassignPanelBeaterSupplierDTO)
        {
            return await _panelBeatersRepository.UnassignPanelBeaterSupplierAsync(unassignPanelBeaterSupplierDTO);
        }
    }
}