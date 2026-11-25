using System.Collections.Generic;
using System.Threading.Tasks;
using Demo.Core.DTOs.Request;
using Demo.Core.DTOs.Response;

namespace Demo.Core.Interfaces
{
    public interface IPanelBeatersRepository
    {
        IEnumerable<GetPanelBeaterClientsDTO> GetPanelBeaterClients(SearchPanelBeaterClientsDTO searchPanelBeaterClientsDTO);
        Task<IEnumerable<GetPanelBeaterAssignedSuppliersDTO>> GetPanelBeaterAssignedSuppliersAsync(SearchPanelBeaterAssignedSuppliersDTO searchPanelBeaterAssignedSuppliersDTO);
        Task<GetUnassignedSuppliersDataDTO> GetUnassignedSuppliersAsync(SearchUnassignedSuppliersDTO searchUnassignedSuppliersDTO);
        IEnumerable<GetFundedByDTO> GetFactors();
        IEnumerable<GetDefaultFundingDTO> GetDefaultFundings();
        Task<ResponseDTO> UpdatePanelBeaterClientSupplierAsync(UpdatePanelBeaterClientSupplierDTO updatePanelBeaterClientSupplierDTO);
        Task<IEnumerable<GetPanelBeaterDropdownDTO>> GetPanelBeaterDropdownsAsync(SearchPanelBeaterDropdownDTO searchPanelBeaterDropdownDTO);
        GetPanelBeaterClientDetailsDTO GetPanelBeaterClientDetails(SearchPanelBeaterClientDeatilsDTO searchPanelBeaterClientDeatilsDTO);
        Task<ResponseDTO> AddPanelBeaterClientAsync(AddPanelBeaterClientDTO addPanelBeaterClientDTO);
        Task<ResponseDTO> AssignSupplierToPanelBeaterAsync(AssignSupplierToPanelBeaterDTO assignSupplierToPanelBeaterDTO);
        Task<ResponseDTO> UpdatePanelBeaterClientAsync(UpdatePanelBeaterClientDTO updatePanelBeaterClientDTO);
        Task<ResponseDTO> UpdateSupplierNotificationEmailAsync(UpdateSupplierNotificationEmailDTO updateSupplierNotificationEmailDTO);
        Task<ResponseDTO> UpdateClientEmailAddressesAsync(UpdateClientEmailAddressesDTO updateClientEmailAddressesDTO);
        Task<ResponseDTO> UnassignPanelBeaterSupplierAsync(UnassignPanelBeaterSupplierDTO unassignPanelBeaterSupplierDTO);
        GetNextPanelBeaterClientExternalIdDTO GetNextPanelBeaterClientExternalId();

    }
}