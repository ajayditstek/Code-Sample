using System.Collections.Generic;
using System.Threading.Tasks;
using Demo.Core.DTOs.Request;
using Demo.Core.DTOs.Response;

namespace Demo.Core.Interfaces
{
    public interface IClaimsRepository
    {
        Task<AddClaimResponseDTO> AddClaimAsync(AddClaimDTO addClaimDTO);
        Task<AddRequestedClaimResponseDTO> AddRequestedClaimAsync(AddRequestedClaimDTO addRequestedClaimDTO);
        Task<AddClaimRequestResponseDTO> AddClaimRequestAsync(AddClaimRequestDTO addClaimRequestDTO);
        Task<ResponseDTO> AddClaimDocumentAsync(AddClaimDocumentDTO addClaimDocumentDTO);
        Task<ResponseDTO> AddClaimNoteAsync(AddClaimNotesDTO addClaimNotesDTO);
        Task<AddClaimDraftResponseDTO> AddClaimDraftAsync(AddClaimDraftDTO addClaimDraftDTO);
        Task<ResponseDTO> UpdateClaimAsync(UpdateClaimDTO updateClaimDTO);
        Task<ResponseDTO> UpdateClaimDraftAsync(UpdateClaimDraftDTO updateClaimDraftDTO);
        IEnumerable<GetClaimsDTO> GetClaimsList(SearchClaimsDTO searchClaimsDTO);
        IEnumerable<GetClaimStatusDTO> GetStatusList();
        IEnumerable<GetAssessorsDTO> GetAssesors();
        Task<IEnumerable<GetVehicleRegistrationCheckResponseDTO>> GetRegistrationCheckResponseAsync(SearchVehicleRegistrationCheckDTO searchVehicleRegistrationCheckDTO);
        IEnumerable<GetCorrespondanceDTO> GetCorrespondaceList(SearchCorrespondanceDTO searchCorrespondanceDTO);
        IEnumerable<GetAllClaimsDTO> GetAllClaimList(SearchAllClaimsDTO searchAllClaimsDTO);
        IEnumerable<GetClaimsLogDTO> GetClaimsLogList(SearchClaimsLogDTO searchClaimsLogDTO);
        IEnumerable<GetClientInsurersDTO> GetClientInsurers(SearchClientInsurersDTO searchClientInsurersDTO);
        IEnumerable<GetClaimDocumentsDTO> GetClaimDocuments(SearchClaimdocumentsDTO searchClaimdocumentsDTO);
        Task<IEnumerable<GetRequestedClaimsDTO>> GetRequestedClaimsAsync(SearchRequestedClaimsDTO searchRequestedClaimsDTO);
        IEnumerable<GetBrandSuppliersDTO> GetBrandSuppliers(SearchBrandSuppliersDTO searchBrandSuppliersDTO);
        IEnumerable<GetPanelBeaterInsurersDTO> GetPanelBeaterInsurers();
        GetClaimsViewDTO GetClaimsView(SearchClaimsViewDTO searchClaimsViewDTO);
        GetRequestedClaimDetailsDTO GetRequestedClaimDetails(SearchRequestedClaimDetailsDTO searchRequestedClaimDetailsDTO);
        GetClientDetailsDTO GetClientDetails(SearchClientDetailsDTO SearchClientDetailsDTO);
        GetClaimDetailsDTO GetClaimDetails(SearchClaimDetailsDTO searchClaimDetailsDTO);
        GetClaimsDetailDTO GetClaimsDetail(SearchClaimsDetailDTO searchClaimsDetailDTO);
        Task<ResponseDTO> RequestPartsSummaryAsync(RequestPartsSummaryDTO requestPartsSummaryDTO);
        Task<ResponseDTO> CancelClaimRequestAsync(CancelClaimRequestDTO cancelClaimRequestDTO);
        Task<ResponseDTO> DeleteClaimAsync(DeleteClaimDTO deleteClaimDTO);
        Task<ResponseDTO> DeleteClaimDocumentAsync(DeleteClaimDocumentDTO deleteClaimDocumentDTO);

    }
}