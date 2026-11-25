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
    public class ClaimsController : BaseController
    {
        private readonly IClaimsRepository _claimsRespository;
        private readonly UATDemoPortalContext _dbContext;
        public ClaimsController(IHttpContextAccessor httpContext, UATDemoPortalContext dbContext, IClaimsRepository claimsRespository) : base(httpContext)
        {
            _dbContext = dbContext;
            _claimsRespository = claimsRespository;
        }

        [Route("AddClaim")]
        [HttpPost]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        [ProducesResponseType(typeof(AddClaimResponseDTO), StatusCodes.Status200OK)]

        public async Task<AddClaimResponseDTO> AddclaimAsync([FromBody] AddClaimDTO addClaimDTO)
        {
            // addClaimDTO.ActionPerformedBy = GetUserId();
            return await _claimsRespository.AddClaimAsync(addClaimDTO);
        }
        [Route("AddClaimRequest")]
        [HttpPost]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        [ProducesResponseType(typeof(AddClaimRequestDTO), StatusCodes.Status200OK)]

        public async Task<ResponseDTO> AddClaimRequestAsync([FromBody] AddClaimRequestDTO addClaimRequestDTO)
        {
            // addClaimDTO.ActionPerformedBy = GetUserId();
            return await _claimsRespository.AddClaimRequestAsync(addClaimRequestDTO);
        }

        [Route("AddClaimDraft")]
        [HttpPost]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        [ProducesResponseType(typeof(AddClaimDraftResponseDTO), StatusCodes.Status200OK)]

        public async Task<AddClaimDraftResponseDTO> AddClaimDraftAsync([FromBody] AddClaimDraftDTO addClaimDraftDTO)
        {
            // addClaimDTO.ActionPerformedBy = GetUserId();
            return await _claimsRespository.AddClaimDraftAsync(addClaimDraftDTO);
        }

        [Route("AddRequestedClaim")]
        [HttpPost]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        [ProducesResponseType(typeof(AddRequestedClaimDTO), StatusCodes.Status200OK)]

        public async Task<AddRequestedClaimResponseDTO> AddRequestedClaimAsync([FromBody] AddRequestedClaimDTO addRequestedClaimDTO)
        {
            // addClaimDTO.ActionPerformedBy = GetUserId();
            return await _claimsRespository.AddRequestedClaimAsync(addRequestedClaimDTO);
        }
        [Route("AddClaimNote")]
        [HttpPost]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        [ProducesResponseType(typeof(ResponseDTO), StatusCodes.Status200OK)]

        public async Task<ResponseDTO> AddClaimNoteAsync([FromBody] AddClaimNotesDTO addClaimNotesDTO)
        {
            // addClaimNotesDTO.ActionPerformedBy = GetUserId();
            return await _claimsRespository.AddClaimNoteAsync(addClaimNotesDTO);
        }

        [Route("AddClaimDocument")]
        [HttpPost]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        [ProducesResponseType(typeof(ResponseDTO), StatusCodes.Status200OK)]

        public async Task<ResponseDTO> AddClaimDocumentAsync([FromForm] AddClaimDocumentDTO addClaimDocumentDTO)
        {
            // addClaimDocumentDTO.ActionPerformedBy = GetUserId();
            return await _claimsRespository.AddClaimDocumentAsync(addClaimDocumentDTO);
        }
        [Route("DeclineClaimRequest")]
        [HttpPost]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        [ProducesResponseType(typeof(ResponseDTO), StatusCodes.Status200OK)]

        public async Task<ResponseDTO> DeclineClaimRequestAsync([FromBody] CancelClaimRequestDTO cancelClaimRequestDTO)
        {
            // addClaimDocumentDTO.ActionPerformedBy = GetUserId();
            return await _claimsRespository.CancelClaimRequestAsync(cancelClaimRequestDTO);
        }

        [Route("RequestPartsSummary")]
        [HttpPost]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        [ProducesResponseType(typeof(ResponseDTO), StatusCodes.Status200OK)]

        public async Task<ResponseDTO> RequestPartsSummaryAsync([FromBody] RequestPartsSummaryDTO requestPartsSummaryDTO)
        {
            // requestPartsSummaryDTO.ActionPerformedBy = GetUserId();
            return await _claimsRespository.RequestPartsSummaryAsync(requestPartsSummaryDTO);
        }

        [Route("UpdateClaim")]
        [HttpPut]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        [ProducesResponseType(typeof(ResponseDTO), StatusCodes.Status200OK)]

        public async Task<ResponseDTO> UpdateClaimAsync([FromBody] UpdateClaimDTO updateClaimDTO)
        {
            // updateClaimDTO.ActionPerformedBy = GetUserId();
            return await _claimsRespository.UpdateClaimAsync(updateClaimDTO);
        }

        [Route("UpdateClaimDraft")]
        [HttpPut]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        [ProducesResponseType(typeof(ResponseDTO), StatusCodes.Status200OK)]

        public async Task<ResponseDTO> UpdateClaimDraftAsync([FromBody] UpdateClaimDraftDTO updateClaimDraftDTO)
        {
            // updateClaimDTO.ActionPerformedBy = GetUserId();
            return await _claimsRespository.UpdateClaimDraftAsync(updateClaimDraftDTO);
        }


        [Route("GetAssessors")]
        [HttpGet]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        [ProducesResponseType(typeof(IEnumerable<GetAssessorsDTO>), StatusCodes.Status200OK)]

        public IEnumerable<GetAssessorsDTO> GetAssessors()
        {
            return _claimsRespository.GetAssesors();
        }

        [Route("GetClaims")]
        [HttpGet]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        [ProducesResponseType(typeof(IEnumerable<GetClaimsDTO>), StatusCodes.Status200OK)]

        public IEnumerable<GetClaimsDTO> GetClaims([FromQuery] SearchClaimsDTO searchClaimsDTO)
        {
            return _claimsRespository.GetClaimsList(searchClaimsDTO);
        }

        [Route("GetAllClaims")]
        [HttpGet]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        [ProducesResponseType(typeof(IEnumerable<GetAllClaimsDTO>), StatusCodes.Status200OK)]

        public IEnumerable<GetAllClaimsDTO> GetAllClaims([FromQuery] SearchAllClaimsDTO searchAllClaimsDTO)
        {
            return _claimsRespository.GetAllClaimList(searchAllClaimsDTO);
        }

        [Route("GetClaimsDetail")]
        [HttpGet]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        [ProducesResponseType(typeof(GetClaimsDetailDTO), StatusCodes.Status200OK)]

        public GetClaimsDetailDTO GetClaimsDetail([FromQuery] SearchClaimsDetailDTO searchClaimsDetailDTO)
        {
            return _claimsRespository.GetClaimsDetail(searchClaimsDetailDTO);
        }

        [Route("GetClaimStatusList")]
        [HttpGet]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        [ProducesResponseType(typeof(IEnumerable<GetClaimStatusDTO>), StatusCodes.Status200OK)]

        public IEnumerable<GetClaimStatusDTO> GetClaimStatusList()
        {
            return _claimsRespository.GetStatusList();
        }

        [Route("GetBrandSuppliers")]
        [HttpGet]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        [ProducesResponseType(typeof(IEnumerable<GetBrandSuppliersDTO>), StatusCodes.Status200OK)]

        public IEnumerable<GetBrandSuppliersDTO> GetClaimStatusList([FromQuery]SearchBrandSuppliersDTO searchBrandSuppliersDTO)
        {
            return _claimsRespository.GetBrandSuppliers(searchBrandSuppliersDTO);
        }


        [Route("GetRequestedClaims")]
        [HttpGet]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        [ProducesResponseType(typeof(IEnumerable<GetRequestedClaimsDTO>), StatusCodes.Status200OK)]

        public async Task<IEnumerable<GetRequestedClaimsDTO>> GetRequestedClaimsAsync([FromQuery] SearchRequestedClaimsDTO searchRequestedClaimsDTO)
        {
            return await _claimsRespository.GetRequestedClaimsAsync(searchRequestedClaimsDTO);
        }
        [Route("GetClaimsLog")]
        [HttpGet]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        [ProducesResponseType(typeof(IEnumerable<GetClaimsLogDTO>), StatusCodes.Status200OK)]

        public IEnumerable<GetClaimsLogDTO> GetClaimsLog([FromQuery] SearchClaimsLogDTO searchClaimsLogDTO)
        {
            return _claimsRespository.GetClaimsLogList(searchClaimsLogDTO);
        }
        [Route("GetCorrespondance")]
        [HttpGet]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        [ProducesResponseType(typeof(IEnumerable<GetCorrespondanceDTO>), StatusCodes.Status200OK)]

        public IEnumerable<GetCorrespondanceDTO> GetCorrespondaceList([FromQuery] SearchCorrespondanceDTO searchCorrespondanceDTO)
        {
            return _claimsRespository.GetCorrespondaceList(searchCorrespondanceDTO);
        }
        [Route("GetPanelBeaterInsurers")]
        [HttpGet]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        [ProducesResponseType(typeof(IEnumerable<GetPanelBeaterInsurersDTO>), StatusCodes.Status200OK)]

        public IEnumerable<GetPanelBeaterInsurersDTO> GetPanelBeaterInsurers()
        {
            return _claimsRespository.GetPanelBeaterInsurers();
        }
        [Route("GetClientInsurers")]
        [HttpGet]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        [ProducesResponseType(typeof(IEnumerable<GetClientInsurersDTO>), StatusCodes.Status200OK)]

        public IEnumerable<GetClientInsurersDTO> GetClientInsurersDTO([FromQuery]SearchClientInsurersDTO searchClientInsurersDTO)
        {
            return _claimsRespository.GetClientInsurers(searchClientInsurersDTO);
        }

        [Route("GetVehicleRegistrationCheckResponse")]
        [HttpGet]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        [ProducesResponseType(typeof(IEnumerable<GetVehicleRegistrationCheckResponseDTO>), StatusCodes.Status200OK)]

        public async Task<IEnumerable<GetVehicleRegistrationCheckResponseDTO>> GetVehicleRegistrationCheckResponseAsync([FromQuery] SearchVehicleRegistrationCheckDTO searchVehicleRegistrationCheckDTO)
        {
            return await _claimsRespository.GetRegistrationCheckResponseAsync(searchVehicleRegistrationCheckDTO);
        }

        [Route("GetClaimDocuments")]
        [HttpGet]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        [ProducesResponseType(typeof(IEnumerable<GetClaimDocumentsDTO>), StatusCodes.Status200OK)]

        public IEnumerable<GetClaimDocumentsDTO> GetClaimDocuments([FromQuery]SearchClaimdocumentsDTO searchClaimdocumentsDTO)
        {
            return _claimsRespository.GetClaimDocuments(searchClaimdocumentsDTO);
        }
        [Route("GetClaimsView")]
        [HttpGet]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        [ProducesResponseType(typeof(GetClaimsViewDTO), StatusCodes.Status200OK)]

        public GetClaimsViewDTO GetClaimsView([FromQuery] SearchClaimsViewDTO searchClaimsViewDTO)
        {
            return _claimsRespository.GetClaimsView(searchClaimsViewDTO);
        }

        [Route("GetClaimDetails")]
        [HttpGet]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        [ProducesResponseType(typeof(GetClaimDetailsDTO), StatusCodes.Status200OK)]

        public GetClaimDetailsDTO GetClaimDetails([FromQuery] SearchClaimDetailsDTO searchClaimDetailsDTO)
        {
            return _claimsRespository.GetClaimDetails(searchClaimDetailsDTO);
        }
        [Route("GetRequestedClaimDetails")]
        [HttpGet]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        [ProducesResponseType(typeof(GetRequestedClaimDetailsDTO), StatusCodes.Status200OK)]

        public GetRequestedClaimDetailsDTO GetRequestedClaimDetails([FromQuery] SearchRequestedClaimDetailsDTO searchRequestedClaimDetailsDTO)
        {
            return _claimsRespository.GetRequestedClaimDetails(searchRequestedClaimDetailsDTO);
        }

        [Route("GetClientDetails")]
        [HttpGet]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        [ProducesResponseType(typeof(GetClientDetailsDTO), StatusCodes.Status200OK)]

        public GetClientDetailsDTO GetClientDetails([FromQuery] SearchClientDetailsDTO searchClientDetailsDTO)
        {
            return _claimsRespository.GetClientDetails(searchClientDetailsDTO);
        }

        [Route("DeleteClaim")]
        [HttpDelete]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        [ProducesResponseType(typeof(ResponseDTO), StatusCodes.Status200OK)]

        public Task<ResponseDTO> DeleteClaimAsync([FromQuery] DeleteClaimDTO deleteClaimDTO)
        {
            return _claimsRespository.DeleteClaimAsync(deleteClaimDTO);
        }

        [Route("DeleteClaimDocument")]
        [HttpDelete]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        [ProducesResponseType(typeof(ResponseDTO), StatusCodes.Status200OK)]

        public Task<ResponseDTO> DeleteClaimDocumentAsync([FromQuery] DeleteClaimDocumentDTO deleteClaimDocumentDTO)
        {
            return _claimsRespository.DeleteClaimDocumentAsync(deleteClaimDocumentDTO);
        }
    }
}