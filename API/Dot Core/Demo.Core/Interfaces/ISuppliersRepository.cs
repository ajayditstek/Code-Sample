using System.Collections.Generic;
using System.Threading.Tasks;
using Demo.Core.DTOs.Request;
using Demo.Core.DTOs.Response;

namespace Demo.Core.Interfaces
{
    public interface ISuppliersRepository
    {
        IEnumerable<GetSuppliersDTO> GetSuppliersAsync(SearchSuppliersDTO searchSuppliersDTO);
        IEnumerable<GetSuppliersNameDTO> GetSuppliersNameAsync(SearchSuppliersNameDTO searchSuppliersNameDTO);
        Task<IEnumerable<GetSupplierBrandsDTO>> GetSupplierBrandsAsync(SearchSupplierBrandsDTO searchSupplierBrandsDTO);
        IEnumerable<GetSupplierGroupsDTO> GetSupplierGroups(SearchSupplierGroupsDTO searchSupplierGroupsDTO);
        IEnumerable<GetRequestedSuppliersDTO> GetRequestedSuppliers(SearchRequestedSuppliersDTO searchRequestedSuppliersDTO);
        GetRequestedSupplierDetailsDTO GetRequestedSupplierDetails(SearchRequestedSupplierDetailsDTO searchRequestedSupplierDetailsDTO);
        IEnumerable<GetBrandsDTO> GetBrands();
        IEnumerable<GetUnassignedSupplierBrandsDTO> GetUnassignedSupplierBrands(SearchUnassignedSupplierBrandsDTO searchUnassignedSupplierBrandsDTO);
        Task<GetSupplierDetailsDTO> GetSupplierDetailsAsync(SearchSupplierDetailsDTO searchSupplierDetailsDTO);
        Task<ResponseDTO> AddSupplierExternalNameAsync(AddSupplierExternalNameDTO addSupplierExternalNameDTO);
        Task<ResponseDTO> AddSupplierBrandsAsync(AddSupplierBrandsDTO addSupplierBrandsDTO);
        Task<IEnumerable<FilteredDataDTO>> GetFilteredDataAsync(SearchFilterSuppliersDTO searchFilterSuppliersDTO);
        Task<GetNextSupplierExternalIdDTO> GetNextSupplierExternalIdAsync();

        Task<ResponseDTO> AddSupplierAsync(AddSupplierDTO addSupplierDTO);
        Task<ResponseDTO> AddSupplierRequestAsync(AddSupplierRequestDTO addSupplierRequestDTO);
        Task<ResponseDTO> DeleteSupplierBrandAsync(DeleteSupplierBrandDTO deleteSupplierBrandDTO);
        Task<ResponseDTO> UpdateSupplierExternalNameAsync(UpdateSupplierExternalNameDTO updateSupplierExternalNameDTO);
        Task<ResponseDTO> DeleteSupplierExternalNameAsync(DeleteSupplierExternalNameDTO deleteSupplierExternalNameDTO);
        Task<ResponseDTO> UpdateSupplierAsync(UpdateSupplierDTO updateSupplierDTO);
        Task<ResponseDTO> UpdateSupplyLocationsAsync(UpdateSupplyLocationsDTO updateSupplyLocationsDTO);
        Task<ResponseDTO> AddRequestedSupplierAsync(AddRequestedSupplierDTO addRequestedSupplierDTO);
        Task<ResponseDTO> UpdateSupplierClientAsync(UpdateSupplierClientDTO updateSupplierClientDTO);

    }
}