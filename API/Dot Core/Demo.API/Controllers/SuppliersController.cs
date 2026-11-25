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
    public class SuppliersController : BaseController
    {
        private readonly ISuppliersRepository _suppliersRespository;
        private readonly UATDemoPortalContext _dbContext;
        public SuppliersController(IHttpContextAccessor httpContext, UATDemoPortalContext dbContext, ISuppliersRepository suppliersRespository) : base(httpContext)
        {
            _dbContext = dbContext;
            _suppliersRespository = suppliersRespository;
        }

        [Route("GetSuppliers")]
        [HttpGet]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        [ProducesResponseType(typeof(IEnumerable<GetSuppliersDTO>), StatusCodes.Status200OK)]

        public IEnumerable<GetSuppliersDTO> GetSuppliersList([FromQuery] SearchSuppliersDTO searchSuppliersDTO)
        {
            return _suppliersRespository.GetSuppliersAsync(searchSuppliersDTO);
        }

        [Route("GetSuppliersName")]
        [HttpGet]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        [ProducesResponseType(typeof(IEnumerable<GetSuppliersNameDTO>), StatusCodes.Status200OK)]

        public IEnumerable<GetSuppliersNameDTO> GetSuppliersNameList([FromQuery] SearchSuppliersNameDTO searchSuppliersNameDTO)
        {
            return _suppliersRespository.GetSuppliersNameAsync(searchSuppliersNameDTO);
        }

        [Route("GetSupplierBrands")]
        [HttpGet]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        [ProducesResponseType(typeof(IEnumerable<GetSuppliersNameDTO>), StatusCodes.Status200OK)]

        public async Task<IEnumerable<GetSupplierBrandsDTO>> GetSupplierBrandsAsync([FromQuery] SearchSupplierBrandsDTO searchSupplierBrandsDTO)
        {
            return await _suppliersRespository.GetSupplierBrandsAsync(searchSupplierBrandsDTO);
        }

        [Route("GetSupplierGroups")]
        [HttpGet]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        [ProducesResponseType(typeof(IEnumerable<GetSupplierGroupsDTO>), StatusCodes.Status200OK)]

        public IEnumerable<GetSupplierGroupsDTO> GetSupplierGroupsList([FromQuery] SearchSupplierGroupsDTO searchSupplierGroupsDTO)
        {
            return _suppliersRespository.GetSupplierGroups(searchSupplierGroupsDTO);
        }

        [Route("GetRequestedSuppliers")]
        [HttpGet]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        [ProducesResponseType(typeof(IEnumerable<GetRequestedSuppliersDTO>), StatusCodes.Status200OK)]

        public IEnumerable<GetRequestedSuppliersDTO> GetRequestedsuppliersList([FromQuery] SearchRequestedSuppliersDTO searchRequestedSuppliersDTO)
        {
            return _suppliersRespository.GetRequestedSuppliers(searchRequestedSuppliersDTO);
        }
        [Route("GetFilteredSuppliers")]
        [HttpPost]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        [ProducesResponseType(typeof(IEnumerable<FilteredDataDTO>), StatusCodes.Status200OK)]

        public async Task<IEnumerable<FilteredDataDTO>> GetFilteredSuppliersAsync([FromBody] SearchFilterSuppliersDTO searchFilterSuppliersDTO)
        {
            return await _suppliersRespository.GetFilteredDataAsync(searchFilterSuppliersDTO);
        }

        [Route("GetSupplierDetails")]
        [HttpGet]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        [ProducesResponseType(typeof(GetSupplierDetailsDTO), StatusCodes.Status200OK)]

        public Task<GetSupplierDetailsDTO> GetSupplierDetailsAsync([FromQuery]SearchSupplierDetailsDTO searchSupplierDetailsDTO)
        {
            return _suppliersRespository.GetSupplierDetailsAsync(searchSupplierDetailsDTO);
        }

        [Route("GetRequestedSupplierDetails")]
        [HttpGet]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        [ProducesResponseType(typeof(GetRequestedSupplierDetailsDTO), StatusCodes.Status200OK)]

        public GetRequestedSupplierDetailsDTO GetRequestedSupplierDetails([FromQuery] SearchRequestedSupplierDetailsDTO searchRequestedSupplierDetailsDTO)
        {
            return _suppliersRespository.GetRequestedSupplierDetails(searchRequestedSupplierDetailsDTO);
        }

        [Route("GetBrands")]
        [HttpGet]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        [ProducesResponseType(typeof(IEnumerable<GetBrandsDTO>), StatusCodes.Status200OK)]

        public IEnumerable<GetBrandsDTO> GetBrands()
        {
            return _suppliersRespository.GetBrands();
        }
        [Route("GetUnassignedSupplierBrands")]
        [HttpGet]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        [ProducesResponseType(typeof(IEnumerable<GetUnassignedSupplierBrandsDTO>), StatusCodes.Status200OK)]

        public IEnumerable<GetUnassignedSupplierBrandsDTO> GetUnassignedSupplierBrands([FromQuery] SearchUnassignedSupplierBrandsDTO searchUnassignedSupplierBrandsDTO)
        {
            return _suppliersRespository.GetUnassignedSupplierBrands(searchUnassignedSupplierBrandsDTO);
        }

        [Route("AddSupplierExternalName")]
        [HttpPost]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        [ProducesResponseType(typeof(ResponseDTO), StatusCodes.Status200OK)]

        public async Task<ResponseDTO> AddSupplierExternalNameAsync([FromBody] AddSupplierExternalNameDTO addSupplierExternalNameDTO)
        {
            // addSupplierExternalNameDTO.ActionPerformedBy = GetUserId();
            return await _suppliersRespository.AddSupplierExternalNameAsync(addSupplierExternalNameDTO);
        }
        [Route("AddSupplierRequest")]
        [HttpPost]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        [ProducesResponseType(typeof(ResponseDTO), StatusCodes.Status200OK)]

        public async Task<ResponseDTO> AddSupplierRequestAsync([FromBody] AddSupplierRequestDTO addSupplierRequestDTO)
        {
            // addSupplierExternalNameDTO.ActionPerformedBy = GetUserId();
            return await _suppliersRespository.AddSupplierRequestAsync(addSupplierRequestDTO);
        }

        [Route("AddSupplierBrands")]
        [HttpPost]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        [ProducesResponseType(typeof(ResponseDTO), StatusCodes.Status200OK)]

        public async Task<ResponseDTO> AddSupplierBrandsAsync([FromBody] AddSupplierBrandsDTO addSupplierBrandsDTO)
        {
            return await _suppliersRespository.AddSupplierBrandsAsync(addSupplierBrandsDTO);
        }
        [Route("AddSupplier")]
        [HttpPost]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        [ProducesResponseType(typeof(ResponseDTO), StatusCodes.Status200OK)]

        public async Task<ResponseDTO> AddSupplierAsync([FromBody] AddSupplierDTO addSupplierDTO)
        {
            // addSupplierDTO.ActionPerformedBy = GetUserId();
            return await _suppliersRespository.AddSupplierAsync(addSupplierDTO);
        }
        [Route("UpdateSupplier")]
        [HttpPut]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        [ProducesResponseType(typeof(ResponseDTO), StatusCodes.Status200OK)]

        public async Task<ResponseDTO> UpdateSupplierAsync([FromBody] UpdateSupplierDTO updateSupplierDTO)
        {
            // updateSupplierDTO.ActionPerformedBy = GetUserId();
            return await _suppliersRespository.UpdateSupplierAsync(updateSupplierDTO);
        }
        [Route("UpdateSupplierClient")]
        [HttpPut]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        [ProducesResponseType(typeof(ResponseDTO), StatusCodes.Status200OK)]

        public async Task<ResponseDTO> UpdateSupplierClientAsync([FromBody] UpdateSupplierClientDTO updateSupplierClientDTO)
        {
            // updateSupplierClientDTO.ActionPerformedBy = GetUserId();
            return await _suppliersRespository.UpdateSupplierClientAsync(updateSupplierClientDTO);
        }
        [Route("AddRequestedSupplier")]
        [HttpPost]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        [ProducesResponseType(typeof(ResponseDTO), StatusCodes.Status200OK)]

        public async Task<ResponseDTO> AddRequestedSupplierAsync([FromBody] AddRequestedSupplierDTO addRequestedSupplierDTO)
        {
            // addRequestedSupplierDTO.ActionPerformedBy = GetUserId();
            return await _suppliersRespository.AddRequestedSupplierAsync(addRequestedSupplierDTO);
        }
        [Route("UpdateSupplierExternalName")]
        [HttpPut]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        [ProducesResponseType(typeof(ResponseDTO), StatusCodes.Status200OK)]

        public async Task<ResponseDTO> UpdateSupplierExternalNameAsync([FromBody] UpdateSupplierExternalNameDTO updateSupplierExternalNameDTO)
        {
            updateSupplierExternalNameDTO.ActionPerformedBy = GetUserId();
            return await _suppliersRespository.UpdateSupplierExternalNameAsync(updateSupplierExternalNameDTO);
        }

        [Route("UpdateSupplyLocations")]
        [HttpPut]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        [ProducesResponseType(typeof(ResponseDTO), StatusCodes.Status200OK)]

        public async Task<ResponseDTO> UpdateSupplyLocationsAsync([FromBody] UpdateSupplyLocationsDTO updateSupplyLocationsDTO)
        {
            // updateSupplyLocationsDTO.ActionPerformedBy = GetUserId();
            return await _suppliersRespository.UpdateSupplyLocationsAsync(updateSupplyLocationsDTO);
        }
        [Route("DeleteSupplierExternalName")]
        [HttpDelete]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        [ProducesResponseType(typeof(ResponseDTO), StatusCodes.Status200OK)]

        public async Task<ResponseDTO> DeleteSupplierExternalNameAsync([FromQuery] DeleteSupplierExternalNameDTO deleteSupplierExternalNameDTO)
        {
            return await _suppliersRespository.DeleteSupplierExternalNameAsync(deleteSupplierExternalNameDTO);
        }

        [Route("DeleteSupplierBrand")]
        [HttpDelete]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        [ProducesResponseType(typeof(ResponseDTO), StatusCodes.Status200OK)]

        public async Task<ResponseDTO> DeleteSupplierBrandAsync([FromQuery] DeleteSupplierBrandDTO deleteSupplierBrandDTO)
        {
            return await _suppliersRespository.DeleteSupplierBrandAsync(deleteSupplierBrandDTO);
        }

        [Route("GetNextSupplierExternalId")]
        [HttpGet]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        [ProducesResponseType(typeof(GetNextSupplierExternalIdDTO), StatusCodes.Status200OK)]

        public async Task<GetNextSupplierExternalIdDTO> GetNextSupplierExternalIdAsync()
        {
            return await _suppliersRespository.GetNextSupplierExternalIdAsync();
        }

    }
}