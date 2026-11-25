using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Demo.Core.DTOs.Request;
using Demo.Core.DTOs.Response;
using Demo.Core.Interfaces;
using Demo.Core.Model;
using Demo.Repository.Common.StoreProcedures;
using Demo.Repository.Enums;
using Demo.Repository.GenricRepo;

namespace Demo.Repository.Repository
{
    public class SuppliersRepository : GenericRepository<PbSupplier>, ISuppliersRepository
    {
        private readonly UATDemoPortalContext _dbContext;
        public SuppliersRepository(UATDemoPortalContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
        }

        public async Task<ResponseDTO> AddRequestedSupplierAsync(AddRequestedSupplierDTO addRequestedSupplierDTO)
        {
            var PbSupplier = new PbSupplier();
            PbSupplier.SupplierId = Guid.NewGuid();

            PbSupplier.SupplierName = addRequestedSupplierDTO.SupplierName;
            PbSupplier.SupplierTradingName = addRequestedSupplierDTO.SupplierTradingName;
            PbSupplier.CompanyRegNumber = addRequestedSupplierDTO.CompanyRegNumber;
            PbSupplier.VatregNumber = addRequestedSupplierDTO.VATRegNumber;
            PbSupplier.Email = addRequestedSupplierDTO.Email;
            PbSupplier.NotificationEmailAddress = addRequestedSupplierDTO.NotificationEmailAddress;
            PbSupplier.TelNumber = addRequestedSupplierDTO.TelNumber;
            PbSupplier.FaxNumber = addRequestedSupplierDTO.FaxNumber;
            PbSupplier.CellNumber = addRequestedSupplierDTO.CellNumber;
            PbSupplier.PhysicalAddr1 = addRequestedSupplierDTO.PhysicalAddr1;
            PbSupplier.PhysicalAddr2 = addRequestedSupplierDTO.PhysicalAddr2;
            PbSupplier.PhysicalAddr3 = addRequestedSupplierDTO.PhysicalAddr3;
            PbSupplier.PhysicalAddrCode = addRequestedSupplierDTO.PhysicalAddrCode;
            PbSupplier.PostalAddr1 = addRequestedSupplierDTO.PostalAddr1;
            PbSupplier.PostalAddr2 = addRequestedSupplierDTO.PostalAddr2;
            PbSupplier.PostalAddr3 = addRequestedSupplierDTO.PostalAddr3;
            PbSupplier.PostalAddrCode = addRequestedSupplierDTO.PostalAddrCode;
            PbSupplier.PaymentsLessRebateStructure = addRequestedSupplierDTO.PaymentsLessRebateStructure;
            PbSupplier.Obselete = false;
            PbSupplier.ModifiedBy = addRequestedSupplierDTO.ActionPerformedBy;
            PbSupplier.ModifiedDate = DateTime.Now;
            PbSupplier.ExternalId = addRequestedSupplierDTO.ExternalId;

            if (addRequestedSupplierDTO.SupplierGroupId != null && addRequestedSupplierDTO.SupplierGroupId != "")
            {
                PbSupplier.SupplierGroupId = Guid.Parse(addRequestedSupplierDTO.SupplierGroupId);
            }
            if (addRequestedSupplierDTO.Region != null && addRequestedSupplierDTO.Region != "")
            {
                PbSupplier.Region = addRequestedSupplierDTO.Region;
            }
      

            var addSupplierBrandsDTO = new AddSupplierBrandsDTO()
            {
                SupplierId = PbSupplier.SupplierId.ToString(),
                Brands = addRequestedSupplierDTO.Brands
            };

            var supplierBrandResponse = await AddSupplierBrandsAsync(addSupplierBrandsDTO);


            await _dbContext.PbSuppliers.AddAsync(PbSupplier);

            var requestedSupplierToUpdate = (from x in _dbContext.PbSuppliersRegistrations
                                             where x.SupplierRegisterId.ToString() == addRequestedSupplierDTO.SupplierRegisterId
                                             select x).FirstOrDefault();

            requestedSupplierToUpdate.AddedBy = addRequestedSupplierDTO.ActionPerformedBy;
            requestedSupplierToUpdate.AddedDate = DateTime.Now;

            _dbContext.PbSuppliersRegistrations.Update(requestedSupplierToUpdate);
            await _dbContext.SaveChangesAsync();

            return new ResponseDTO()
            {
                KeyId = 1,
                ResponseCode = ResponseCode.Success,
                ResponseMessage = ResponseMessages.RequestedSupplierAdded
            };

        }

        public async Task<ResponseDTO> AddSupplierAsync(AddSupplierDTO addSupplierDTO)
        {
            var supplierNameCount = _dbContext.PbSuppliers.Where(x => x.SupplierName == addSupplierDTO.SupplierName).Count();
            if (supplierNameCount > 0)
            {
                throw new Exception(ResponseMessages.SupplierNameAlreadyExists);
            }
            else
            {
                var PbSupplier = new PbSupplier();
                PbSupplier.SupplierId = Guid.NewGuid();

                PbSupplier.SupplierName = addSupplierDTO.SupplierName;
                PbSupplier.SupplierTradingName = addSupplierDTO.SupplierTradingName;
                PbSupplier.CompanyRegNumber = addSupplierDTO.CompanyRegNumber;
                PbSupplier.VatregNumber = addSupplierDTO.VATRegNumber;
                PbSupplier.ContactPerson = addSupplierDTO.ContactPerson;
                PbSupplier.Email = addSupplierDTO.Email;
                PbSupplier.NotificationEmailAddress = addSupplierDTO.NotificationEmailAddress;
                PbSupplier.TelNumber = addSupplierDTO.TelNumber;
                PbSupplier.FaxNumber = addSupplierDTO.FaxNumber;
                PbSupplier.CellNumber = addSupplierDTO.CellNumber;
                PbSupplier.NoCodfee = addSupplierDTO.NoCODFee;
                PbSupplier.PhysicalAddr1 = addSupplierDTO.PhysicalAddr1;
                PbSupplier.PhysicalAddr2 = addSupplierDTO.PhysicalAddr2;
                PbSupplier.PhysicalAddr3 = addSupplierDTO.PhysicalAddr3;
                PbSupplier.PhysicalAddrCode = addSupplierDTO.PhysicalAddrCode;
                PbSupplier.PostalAddr1 = addSupplierDTO.PostalAddr1;
                PbSupplier.PostalAddr2 = addSupplierDTO.PostalAddr2;
                PbSupplier.PostalAddr3 = addSupplierDTO.PostalAddr3;
                PbSupplier.PostalAddrCode = addSupplierDTO.PostalAddrCode;
                PbSupplier.ExternalId = addSupplierDTO.ExternalId;
                PbSupplier.PaymentsLessRebateStructure = addSupplierDTO.PaymentsLessRebateStructure;
                PbSupplier.SuppliesGlass = addSupplierDTO.SuppliesGlass;
                PbSupplier.Obselete = false;
                PbSupplier.CreatedBy = addSupplierDTO.ActionPerformedBy;
                PbSupplier.CreatedDate = DateTime.Now;


                if (addSupplierDTO.SupplierGroupId != null && addSupplierDTO.SupplierGroupId != "")
                {
                    PbSupplier.SupplierGroupId = Guid.Parse(addSupplierDTO.SupplierGroupId);
                }

                if (addSupplierDTO.RegionId != null && addSupplierDTO.RegionId != "")
                {
                    PbSupplier.RegionId = Guid.Parse(addSupplierDTO.RegionId);
                }

                if (addSupplierDTO.SupplierType != null && addSupplierDTO.SupplierType != "")
                {
                    PbSupplier.SupplierType = addSupplierDTO.SupplierType;
                }

                if (addSupplierDTO.SuburbId != null && addSupplierDTO.SuburbId != "")
                {
                    PbSupplier.SuburbId = Guid.Parse(addSupplierDTO.SuburbId);
                }

                var addSupplierBrandsDTO = new AddSupplierBrandsDTO()
                {
                    SupplierId = PbSupplier.SupplierId.ToString(),
                    Brands = addSupplierDTO.Brands
                };

                var supplierBrandResponse = await AddSupplierBrandsAsync(addSupplierBrandsDTO);

                if (addSupplierDTO.CityId != null && addSupplierDTO.CityId != "")
                {
                    PbSupplier.CityId = Guid.Parse(addSupplierDTO.CityId);

                    if ((from s in _dbContext.PbSupplierSupplyAreas
                         where s.SupplierId == PbSupplier.SupplierId
                         select s).Any() == false)
                    {
                        var addSupplyArea = new PbSupplierSupplyArea();
                        addSupplyArea.SupplyAreaId = Guid.NewGuid();
                        addSupplyArea.SupplierId = PbSupplier.SupplierId;
                        addSupplyArea.CityId = Guid.Parse(addSupplierDTO.CityId);
                        addSupplyArea.CreatedBy = addSupplierDTO.ActionPerformedBy;
                        addSupplyArea.CreatedDate = DateTime.Now;

                        await _dbContext.PbSupplierSupplyAreas.AddAsync(addSupplyArea);

                        await _dbContext.SaveChangesAsync();

                    }

                }

                if (addSupplierDTO.SupplierPercent == (addSupplierDTO.ClientPercent + addSupplierDTO.InsurerPercent + addSupplierDTO.DemoPercent))
                {
                    var model = new AddRebateStructureDTO()
                    {
                        EffectiveDate = DateTime.Now,
                        SupplierId = PbSupplier.SupplierId,
                        ClientId = null,
                        InsurerId = null,
                        DemoPercent = addSupplierDTO.SupplierPercent - (addSupplierDTO.ClientPercent + addSupplierDTO.InsurerPercent),
                        ClientPercent = addSupplierDTO.ClientPercent,
                        InsurerPercent = addSupplierDTO.InsurerPercent,
                        TotalPercent = addSupplierDTO.SupplierPercent,
                        UserName = addSupplierDTO.ActionPerformedBy
                    };

                    var response = await CommandAsync<ResponseDTO>(StoreProcedures.AddRebateStructure, model);

                    if (response.ResponseCode != ResponseCode.Success)
                    {
                        throw new Exception(ResponseMessages.ErrorCreatingRebateStructure);
                    }
                }
                else
                {
                    throw new Exception(ResponseMessages.ErrorCreatingRebateStructure);
                }

                await _dbContext.PbSuppliers.AddAsync(PbSupplier);
                await _dbContext.SaveChangesAsync();

                return new ResponseDTO()
                {
                    KeyId = 1,
                    ResponseCode = ResponseCode.Success,
                    ResponseMessage = ResponseMessages.SupplierCreated
                };

            }


        }

        public async Task<ResponseDTO> AddSupplierBrandsAsync(AddSupplierBrandsDTO addSupplierBrandsDTO)
        {

            foreach (var brand in addSupplierBrandsDTO.Brands)
            {
                var pbSupplierBrand = new PbSupplierBrand();
                pbSupplierBrand.BrandId = Guid.Parse(brand.BrandId);
                pbSupplierBrand.SupplierId = Guid.Parse(addSupplierBrandsDTO.SupplierId);
                pbSupplierBrand.PanelBeaterBrandId = Guid.NewGuid();

                await _dbContext.PbSupplierBrands.AddAsync(pbSupplierBrand);
            }

            await _dbContext.SaveChangesAsync();

            return new ResponseDTO()
            {
                KeyId = 1,
                ResponseCode = ResponseCode.Success,
                ResponseMessage = ResponseMessages.SupplierBrandSaved
            };
        }

        public async Task<ResponseDTO> AddSupplierExternalNameAsync(AddSupplierExternalNameDTO addSupplierExternalNameDTO)
        {
            var importSupplierMapping = new ImportSupplierMapping();
            importSupplierMapping.DemoSupplierId = Guid.Parse(addSupplierExternalNameDTO.SupplierId);
            importSupplierMapping.SupplierMappingId = Guid.NewGuid();
            importSupplierMapping.CreatedBy = addSupplierExternalNameDTO.ActionPerformedBy;
            importSupplierMapping.CreatedDate = DateTime.Now;
            importSupplierMapping.ModifiedBy = addSupplierExternalNameDTO.ActionPerformedBy;
            importSupplierMapping.ModifiedDate = DateTime.Now;
            importSupplierMapping.SupplierNameExternal = addSupplierExternalNameDTO.ExternalName;

            await _dbContext.ImportSupplierMappings.AddAsync(importSupplierMapping);

            await _dbContext.SaveChangesAsync();

            return new ResponseDTO()
            {
                KeyId = 1,
                ResponseCode = ResponseCode.Success,
                ResponseMessage = ResponseMessages.SupplierExternalNameSaved
            };
        }

        public async Task<ResponseDTO> DeleteSupplierBrandAsync(DeleteSupplierBrandDTO deleteSupplierBrandDTO)
        {
            var supplierBrandToDelete = _dbContext.PbSupplierBrands.Where(x => x.SupplierId.ToString() == deleteSupplierBrandDTO.SupplierId && x.BrandId.ToString() == deleteSupplierBrandDTO.BrandId).FirstOrDefault();

            if (supplierBrandToDelete == null)
            {
                throw new Exception(ResponseMessages.NoSupplierBrandExists);
            }
            else
            {
                _dbContext.PbSupplierBrands.Remove(supplierBrandToDelete);
                await _dbContext.SaveChangesAsync();

                return new ResponseDTO()
                {
                    KeyId = 1,
                    ResponseCode = ResponseCode.Success,
                    ResponseMessage = ResponseMessages.SupplierBrandDeleted
                };
            }
        }

        public async Task<ResponseDTO> DeleteSupplierExternalNameAsync(DeleteSupplierExternalNameDTO deleteSupplierExternalNameDTO)
        {
            var importSupplierMappingToDelete = _dbContext.ImportSupplierMappings.Where(x => x.SupplierMappingId.ToString() == deleteSupplierExternalNameDTO.SupplierMappingId).FirstOrDefault();
            if (importSupplierMappingToDelete == null)
            {
                throw new Exception(ResponseMessages.NoSupplierExternalNameExist);
            }
            else
            {
                _dbContext.ImportSupplierMappings.Remove(importSupplierMappingToDelete);

                await _dbContext.SaveChangesAsync();

                return new ResponseDTO()
                {
                    KeyId = 1,
                    ResponseCode = ResponseCode.Success,
                    ResponseMessage = ResponseMessages.SupplierExternalNameDeleted
                };
            }
        }

        public IEnumerable<GetBrandsDTO> GetBrands()
        {
            IEnumerable<GetBrandsDTO> brandsList = (from b in _dbContext.PbBrands
                                                    select new GetBrandsDTO
                                                    {
                                                        BrandId = b.BrandId,
                                                        Brand = b.Brand
                                                    }).OrderBy(x => x.Brand).ToList();
            return brandsList;
        }

        public async Task<IEnumerable<FilteredDataDTO>> GetFilteredDataAsync(SearchFilterSuppliersDTO searchFilterSuppliersDTO)
        {
            try
            {
                IEnumerable<GetFilteredSuppliersDTO> suppliersList = await CollectionsAsync<GetFilteredSuppliersDTO>(StoreProcedures.GetFilteredSuppliers);

                suppliersList = suppliersList.Distinct().ToList();

                if (searchFilterSuppliersDTO.SupplierName != null && searchFilterSuppliersDTO.SupplierName != "")
                {
                    SearchByName(ref suppliersList, searchFilterSuppliersDTO.SupplierName);
                }

                // filter work starts here .....
                // Supplier type
                if (searchFilterSuppliersDTO.SupplierType != null && searchFilterSuppliersDTO.SupplierType != "")
                {
                    suppliersList = suppliersList.Where(x => x.SupplierType == searchFilterSuppliersDTO.SupplierType).ToList();
                }

                // Brand 
                if (searchFilterSuppliersDTO.Brands.Count > 0)
                {
                    suppliersList = suppliersList.Where(x => searchFilterSuppliersDTO.Brands.Any(c => c.BrandId.Equals(x.BrandId.ToString()))).ToList();
                }

                // region
                if (searchFilterSuppliersDTO.RegionId != null && searchFilterSuppliersDTO.RegionId != "")
                {
                    suppliersList = suppliersList.Where(x => x.RegionId.ToString() == searchFilterSuppliersDTO.RegionId).ToList();
                }

                // supplier name


                // supplier Group name
                if (searchFilterSuppliersDTO.SupplierGroupId != null && searchFilterSuppliersDTO.SupplierGroupId != "")
                {
                    suppliersList = suppliersList.Where(x => x.SupplierGroupId.ToString() == searchFilterSuppliersDTO.SupplierGroupId).ToList();
                }

                // 
                if (!searchFilterSuppliersDTO.HasSurcharge)
                {
                    suppliersList = suppliersList.Where(x => x.Rebate > 0 || (x.NoCODFee ?? false) == true).ToList();
                }
                else
                {
                    suppliersList = suppliersList.Where(x => x.Rebate == 0 && (x.NoCODFee ?? false) == false).ToList();
                }

                var filteredList = suppliersList.Select(x => new FilteredDataDTO { SupplierId = x.SupplierId, SupplierName = x.SupplierName }).ToList().Distinct();

                return filteredList.GroupBy(x => x.SupplierName).Select(x => x.First()).OrderBy(x => x.SupplierName);
            }
            catch (System.Exception ex)
            {

                throw;
            }

        }

        public async Task<GetNextSupplierExternalIdDTO> GetNextSupplierExternalIdAsync()
        {
            return await CommandAsync<GetNextSupplierExternalIdDTO>(StoreProcedures.GetNextSupplierExternalId);
        }

        public GetRequestedSupplierDetailsDTO GetRequestedSupplierDetails(SearchRequestedSupplierDetailsDTO searchRequestedSupplierDetailsDTO)
        {

            IQueryable<GetRequestedSupplierDetailsDTO> requestedSupplierDetail = (from sr in _dbContext.PbSuppliersRegistrations
                                                                                  where sr.SupplierRegisterId.ToString() == searchRequestedSupplierDetailsDTO.SupplierRegisterId
                                                                                  select new GetRequestedSupplierDetailsDTO
                                                                                  {
                                                                                      SupplierRegisterId = sr.SupplierRegisterId,
                                                                                      SupplierName = sr.SupplierName,
                                                                                      SupplierTradingName = sr.SupplierTradingName,
                                                                                      CompanyRegNumber = sr.CompanyRegNumber,
                                                                                      VatregNumber = sr.VatregNumber,
                                                                                      NotificationEmailAddress = sr.NotificationEmailAddress,
                                                                                      Email = sr.Email,
                                                                                      TelNumber = sr.TelNumber,
                                                                                      FaxNumber = sr.FaxNumber,
                                                                                      CellNumber = sr.CellNumber,
                                                                                      PhysicalAddr1 = sr.PhysicalAddr1,
                                                                                      PhysicalAddr2 = sr.PhysicalAddr2,
                                                                                      PhysicalAddr3 = sr.PhysicalAddr3,
                                                                                      PhysicalAddrCode = sr.PhysicalAddrCode,
                                                                                      PostalAddr1 = sr.PostalAddr1,
                                                                                      PostalAddr2 = sr.PostalAddr2,
                                                                                      PostalAddr3 = sr.PostalAddr3,
                                                                                      PostalAddrCode = sr.PostalAddrCode,
                                                                                      CreatedBy = sr.CreatedBy,
                                                                                      CreatedDate = sr.CreatedDate,
                                                                                      ModifiedBy = sr.ModifiedBy,
                                                                                      ModifiedDate = sr.ModifiedDate,
                                                                                      SyncFlag = sr.SyncFlag,
                                                                                      Region = sr.Region,
                                                                                      AccountCode = sr.AccountCode,
                                                                                      SupplierGroupName = sr.SupplierGroupName,
                                                                                      PaymentTerms = sr.PaymentTerms,
                                                                                      Brand = sr.Brand,
                                                                                      IntegrationName = sr.IntegrationName,
                                                                                      BankName = sr.BankName,
                                                                                      BankBranchName = sr.BankBranchName,
                                                                                      BankAccountHolder = sr.BankAccountHolder,
                                                                                      BankAccountNumber = sr.BankAccountNumber
                                                                                  });
            return requestedSupplierDetail.FirstOrDefault();
        }

        public IEnumerable<GetRequestedSuppliersDTO> GetRequestedSuppliers(SearchRequestedSuppliersDTO searchRequestedSuppliersDTO)
        {
            if (searchRequestedSuppliersDTO.OrderBy != null)
            {
                searchRequestedSuppliersDTO.OrderBy = char.ToUpper(searchRequestedSuppliersDTO.OrderBy[0]) + searchRequestedSuppliersDTO.OrderBy.Substring(1);
            }

            IEnumerable<GetRequestedSuppliersDTO> requestedSuppliersList = (from sr in _dbContext.PbSuppliersRegistrations
                                                                            where sr.AddedDate == null
                                                                            select new GetRequestedSuppliersDTO
                                                                            {
                                                                                SupplierRegisterId = sr.SupplierRegisterId,
                                                                                SupplierName = sr.SupplierName,
                                                                                CompanyRegNumber = sr.CompanyRegNumber,
                                                                                VATRegNumber = sr.VatregNumber,
                                                                                Email = sr.Email,
                                                                                TelNumber = sr.TelNumber,
                                                                                FaxNumber = sr.FaxNumber,
                                                                                CellNumber = sr.CellNumber,
                                                                                PhysicalAddr1 = sr.PhysicalAddr1,
                                                                                PhysicalAddr2 = sr.PhysicalAddr2,
                                                                                PhysicalAddr3 = sr.PhysicalAddr3,
                                                                                PhysicalAddrCode = sr.PhysicalAddrCode,
                                                                                CreatedBy = sr.CreatedBy,
                                                                                CreatedDate = sr.CreatedDate,
                                                                                ModifiedBy = sr.ModifiedBy,
                                                                                ModifiedDate = sr.ModifiedDate
                                                                            }).ToList();

            SearchByName(ref requestedSuppliersList, searchRequestedSuppliersDTO.SearchValue);

            if (searchRequestedSuppliersDTO.OrderByDescending == true)
            {
                if (searchRequestedSuppliersDTO.OrderBy != null)
                {
                    requestedSuppliersList = requestedSuppliersList.OrderByDescending(x => x.GetType().GetProperty(searchRequestedSuppliersDTO.OrderBy).GetValue(x));
                }
            }
            else
            {
                if (searchRequestedSuppliersDTO.OrderBy != null)
                {
                    requestedSuppliersList = requestedSuppliersList.OrderBy(x => x.GetType().GetProperty(searchRequestedSuppliersDTO.OrderBy).GetValue(x));
                }
            }
            int count = requestedSuppliersList.Count();

            if (searchRequestedSuppliersDTO.AllRecords)
                requestedSuppliersList = requestedSuppliersList.ToList();
            else
                requestedSuppliersList = requestedSuppliersList.Skip((searchRequestedSuppliersDTO.PageNo - 1) * searchRequestedSuppliersDTO.PageSize).Take(searchRequestedSuppliersDTO.PageSize).ToList();

            return requestedSuppliersList;
        }

        public async Task<IEnumerable<GetSupplierBrandsDTO>> GetSupplierBrandsAsync(SearchSupplierBrandsDTO searchSupplierBrandsDTO)
        {
            return await CollectionsAsync<GetSupplierBrandsDTO>(StoreProcedures.GetSupplierBrands, searchSupplierBrandsDTO);
        }

        public async Task<GetSupplierDetailsDTO> GetSupplierDetailsAsync(SearchSupplierDetailsDTO searchSupplierDetailsDTO)
        {
            var percent = await GetSupplierTotalRebateAsync(searchSupplierDetailsDTO.SupplierId);
            var assignedLocations = GetSupplierAssignedLocations(searchSupplierDetailsDTO.SupplierId);
            IQueryable<GetSupplierDetailsDTO> suppliersDetail = (from s in _dbContext.PbSuppliers
                                                                 where s.SupplierId.ToString() == searchSupplierDetailsDTO.SupplierId
                                                                 select new GetSupplierDetailsDTO
                                                                 {
                                                                     SupplierId = s.SupplierId,
                                                                     SupplierName = s.SupplierName,
                                                                     SupplierTradingName = s.SupplierTradingName,
                                                                     CompanyRegNumber = s.CompanyRegNumber,
                                                                     VatregNumber = s.VatregNumber,
                                                                     ExternalId = s.ExternalId,
                                                                     Email = s.Email,
                                                                     NotificationEmailAddress = s.NotificationEmailAddress,
                                                                     TelNumber = s.TelNumber,
                                                                     FaxNumber = s.FaxNumber,
                                                                     CellNumber = s.CellNumber,
                                                                     BankName = s.BankName,
                                                                     BankBranchName = s.BankBranchName,
                                                                     BankAccountHolder = s.BankAccountHolder,
                                                                     BankAccountNumber = s.BankAccountNumber,
                                                                     PhysicalAddr1 = s.PhysicalAddr1,
                                                                     PhysicalAddr2 = s.PhysicalAddr2,
                                                                     PhysicalAddr3 = s.PhysicalAddr3,
                                                                     PhysicalAddrCode = s.PhysicalAddrCode,
                                                                     PostalAddr1 = s.PostalAddr1,
                                                                     PostalAddr2 = s.PostalAddr2,
                                                                     PostalAddr3 = s.PostalAddr3,
                                                                     PostalAddrCode = s.PostalAddrCode,
                                                                     CreatedBy = s.CreatedBy,
                                                                     CreatedDate = s.CreatedDate,
                                                                     ModifiedBy = s.ModifiedBy,
                                                                     ModifiedDate = s.ModifiedDate,
                                                                     SyncFlag = s.SyncFlag,
                                                                     Region = s.Region,
                                                                     IntegrationName = s.IntegrationName,
                                                                     AccountCode = s.AccountCode,
                                                                     Brand = s.Brand,
                                                                     SupplierGroupName = s.SupplierGroupName,
                                                                     PaymentTerms = s.PaymentTerms,
                                                                     City = s.City,
                                                                     PaymentsLessRebateStructure = s.PaymentsLessRebateStructure,
                                                                     OnHold = s.OnHold,
                                                                     OnHoldReason = s.OnHoldReason,
                                                                     NoCodfee = s.NoCodfee,
                                                                     SupplierType = s.SupplierType,
                                                                     BranchCode = s.BranchCode,
                                                                     RegionId = s.RegionId,
                                                                     CityId = s.CityId,
                                                                     SuburbId = s.SuburbId,
                                                                     SuppliesGlass = s.SuppliesGlass,
                                                                     PastelCategory = s.PastelCategory,
                                                                     NotificationEmailAddressBcc = s.NotificationEmailAddressBcc,
                                                                     SupplierGroupId = s.SupplierGroupId,
                                                                     Obselete = s.Obselete,
                                                                     RemittanceContactPerson = s.RemittanceContactPerson,
                                                                     RemittanceContactEmail = s.RemittanceContactEmail,
                                                                     PastelConfirmDate = s.PastelConfirmDate,
                                                                     ContactPerson = s.ContactPerson,
                                                                     TotalPercent = percent,
                                                                     CreditorDepartmentEmailAddress = s.CreditorDepartmentEmailAddress,
                                                                     SupplierExternalNames = (from ism in _dbContext.ImportSupplierMappings
                                                                                              where ism.DemoSupplierId == s.SupplierId
                                                                                              select new SupplierExternalName()
                                                                                              {
                                                                                                  SupplierMappingId = ism.SupplierMappingId,
                                                                                                  SupplierId = ism.DemoSupplierId,
                                                                                                  ExternalName = ism.SupplierNameExternal
                                                                                              }
                                                                                            ).ToList(),
                                                                     SupplierClients = (from pbcs in _dbContext.PbClientSuppliers
                                                                                        join c in _dbContext.PbClients
                                                                                        on pbcs.ClientId equals c.ClientId
                                                                                        where pbcs.SupplierId == s.SupplierId
                                                                                        select new SupplierClient
                                                                                        {
                                                                                            ClientSupplierId = pbcs.ClientSupplierId,
                                                                                            SupplierId = pbcs.SupplierId,
                                                                                            AccountCode = pbcs.AccountCode,
                                                                                            ClientName = c.ClientName
                                                                                        }).ToList(),
                                                                     Brands = (from sb in _dbContext.PbSupplierBrands
                                                                               join x in _dbContext.PbBrands on sb.BrandId equals x.BrandId
                                                                               where sb.SupplierId == s.SupplierId
                                                                               select new SupplierBrand
                                                                               {
                                                                                   SupplierId = sb.SupplierId,
                                                                                   BrandId = x.BrandId,
                                                                                   Brand = x.Brand
                                                                               }).OrderBy(x => x.Brand).ToList(),
                                                                     AssignedCities = assignedLocations.AssignedCities,
                                                                     AssignedRegions = assignedLocations.AssignedRegions

                                                                 });
            return suppliersDetail.FirstOrDefault(); ;
        }

        public IEnumerable<GetSupplierGroupsDTO> GetSupplierGroups(SearchSupplierGroupsDTO searchSupplierGroupsDTO)
        {
            IEnumerable<GetSupplierGroupsDTO> supplierGroupsList = (from sg in _dbContext.PbSupplierGroups
                                                                    select new GetSupplierGroupsDTO
                                                                    {
                                                                        SupplierGroupId = sg.SupplierGroupId,
                                                                        SupplierGroup = sg.SupplierGroup
                                                                    }
                                                                ).OrderBy(x => x.SupplierGroup).ToList();

            if (searchSupplierGroupsDTO.SupplierGroupId != null)
                supplierGroupsList = supplierGroupsList.Where(x => x.SupplierGroupId.ToString() == searchSupplierGroupsDTO.SupplierGroupId);

            supplierGroupsList = supplierGroupsList.Skip((searchSupplierGroupsDTO.PageNo - 1) * searchSupplierGroupsDTO.PageSize).Take(searchSupplierGroupsDTO.PageSize).ToList();

            return supplierGroupsList;
        }

        public IEnumerable<GetSuppliersDTO> GetSuppliersAsync(SearchSuppliersDTO searchSuppliersDTO)
        {

            if (searchSuppliersDTO.OrderBy != null)
            {
                searchSuppliersDTO.OrderBy = char.ToUpper(searchSuppliersDTO.OrderBy[0]) + searchSuppliersDTO.OrderBy.Substring(1);
            }

            IEnumerable<GetSuppliersDTO> suppliersLists = (from s in _dbContext.PbSuppliers

                                                           select new GetSuppliersDTO
                                                           {
                                                               SupplierId = s.SupplierId,
                                                               SupplierName = s.SupplierName,
                                                               SupplierTradingName = s.SupplierTradingName,
                                                               CompanyRegNumber = s.CompanyRegNumber,
                                                               VatregNumber = s.VatregNumber,
                                                               ExternalId = s.ExternalId,
                                                               Email = s.Email,
                                                               NotificationEmailAddress = s.NotificationEmailAddress,
                                                               TelNumber = s.TelNumber,
                                                               FaxNumber = s.FaxNumber,
                                                               CellNumber = s.CellNumber,
                                                               BankName = s.BankName,
                                                               BankBranchName = s.BankBranchName,
                                                               BankAccountHolder = s.BankAccountHolder,
                                                               BankAccountNumber = s.BankAccountNumber,
                                                               PhysicalAddr1 = s.PhysicalAddr1,
                                                               PhysicalAddr2 = s.PhysicalAddr2,
                                                               PhysicalAddr3 = s.PhysicalAddr3,
                                                               PhysicalAddrCode = s.PhysicalAddrCode,
                                                               PostalAddr1 = s.PostalAddr1,
                                                               PostalAddr2 = s.PostalAddr2,
                                                               PostalAddr3 = s.PostalAddr3,
                                                               PostalAddrCode = s.PostalAddrCode,
                                                               CreatedBy = s.CreatedBy,
                                                               CreatedDate = s.CreatedDate,
                                                               ModifiedBy = s.ModifiedBy,
                                                               ModifiedDate = s.ModifiedDate,

                                                           }).OrderByDescending(x => x.ModifiedDate).ToList();
            if (searchSuppliersDTO.SupplierId != null)
                suppliersLists = suppliersLists.Where(x => x.SupplierId.ToString() == searchSuppliersDTO.SupplierId);

            SearchByName(ref suppliersLists, searchSuppliersDTO.SearchValue);

            if (searchSuppliersDTO.OrderByDescending == true)
            {
                if (searchSuppliersDTO.OrderBy != null)
                {
                    suppliersLists = suppliersLists.OrderByDescending(x => x.GetType().GetProperty(searchSuppliersDTO.OrderBy).GetValue(x));
                }
            }
            else
            {
                if (searchSuppliersDTO.OrderBy != null)
                {
                    suppliersLists = suppliersLists.OrderBy(x => x.GetType().GetProperty(searchSuppliersDTO.OrderBy).GetValue(x));
                }
            }
            int count = suppliersLists.Count();

            if (searchSuppliersDTO.AllRecords)
                suppliersLists = suppliersLists.ToList();
            else
                suppliersLists = suppliersLists.Skip((searchSuppliersDTO.PageNo - 1) * searchSuppliersDTO.PageSize).Take(searchSuppliersDTO.PageSize).ToList();

            return suppliersLists;
        }

        public IEnumerable<GetSuppliersNameDTO> GetSuppliersNameAsync(SearchSuppliersNameDTO searchSuppliersNameDTO)
        {
           
            IEnumerable<GetSuppliersNameDTO> suppliersNameList = _dbContext.PbSuppliers.Select(x => new GetSuppliersNameDTO() { SupplierId = x.SupplierId, SupplierName = x.SupplierName }).OrderBy(x => x.SupplierName).AsEnumerable();

             SearchByName(ref suppliersNameList, searchSuppliersNameDTO.SearchValue);

            if (searchSuppliersNameDTO.OrderByDescending == true)
            {
                if (searchSuppliersNameDTO.OrderBy != null)
                {
                    suppliersNameList = suppliersNameList.OrderByDescending(x => x.GetType().GetProperty(searchSuppliersNameDTO.OrderBy).GetValue(x));
                }
            }
            else
            {
                if (searchSuppliersNameDTO.OrderBy != null)
                {
                    suppliersNameList = suppliersNameList.OrderBy(x => x.GetType().GetProperty(searchSuppliersNameDTO.OrderBy).GetValue(x));
                }
            }
            int count = suppliersNameList.Count();

            if (searchSuppliersNameDTO.AllRecords)
                suppliersNameList = suppliersNameList.ToList();
            else
                suppliersNameList = suppliersNameList.Skip((searchSuppliersNameDTO.PageNo - 1) * searchSuppliersNameDTO.PageSize).Take(searchSuppliersNameDTO.PageSize).ToList();

            return suppliersNameList;
        }

        public async Task<ResponseDTO> UpdateSupplierAsync(UpdateSupplierDTO updateSupplierDTO)
        {
            try
            {
                if (updateSupplierDTO.OnHold == true && (updateSupplierDTO.OnHoldReason == null || updateSupplierDTO.OnHoldReason == ""))
                {
                    return new ResponseDTO()
                    {
                        KeyId = -1,
                        ResponseCode = 500,
                        ResponseMessage = ResponseMessages.HoldResonRequired
                    };
                }
                else
                {
                    var pbSupplierToUpdate = (from s in _dbContext.PbSuppliers
                                              where s.SupplierId.ToString() == updateSupplierDTO.SupplierId
                                              select s
                                            ).FirstOrDefault();

      

                    pbSupplierToUpdate.SupplierName = updateSupplierDTO.SupplierName;
                    pbSupplierToUpdate.SupplierTradingName = updateSupplierDTO.SupplierTradingName;
                    pbSupplierToUpdate.CompanyRegNumber = updateSupplierDTO.CompanyRegNumber;
                    pbSupplierToUpdate.VatregNumber = updateSupplierDTO.VATRegNumber;
                    pbSupplierToUpdate.ContactPerson = updateSupplierDTO.ContactPerson;
                    pbSupplierToUpdate.Email = updateSupplierDTO.Email;
                    pbSupplierToUpdate.NotificationEmailAddress = updateSupplierDTO.NotificationEmailAddress;
                    pbSupplierToUpdate.NotificationEmailAddressBcc = updateSupplierDTO.NotificationEmailAddressBcc;
                    pbSupplierToUpdate.CreditorDepartmentEmailAddress = updateSupplierDTO.CreditorDepartmentEmailAddress;
                    pbSupplierToUpdate.TelNumber = updateSupplierDTO.TelNumber;
                    pbSupplierToUpdate.FaxNumber = updateSupplierDTO.FaxNumber;
                    pbSupplierToUpdate.CellNumber = updateSupplierDTO.CellNumber;
                    pbSupplierToUpdate.NoCodfee = updateSupplierDTO.NoCODFee;
                    pbSupplierToUpdate.PaymentTerms = updateSupplierDTO.PaymentTerms;
                    pbSupplierToUpdate.PhysicalAddr1 = updateSupplierDTO.PhysicalAddr1;
                    pbSupplierToUpdate.PhysicalAddr2 = updateSupplierDTO.PhysicalAddr2;
                    pbSupplierToUpdate.PhysicalAddr3 = updateSupplierDTO.PhysicalAddr3;
                    pbSupplierToUpdate.PhysicalAddrCode = updateSupplierDTO.PhysicalAddrCode;
                    pbSupplierToUpdate.PostalAddr1 = updateSupplierDTO.PostalAddr1;
                    pbSupplierToUpdate.PostalAddr2 = updateSupplierDTO.PostalAddr2;
                    pbSupplierToUpdate.PostalAddr3 = updateSupplierDTO.PostalAddr3;
                    pbSupplierToUpdate.PostalAddrCode = updateSupplierDTO.PostalAddrCode;
                    pbSupplierToUpdate.SuppliesGlass = updateSupplierDTO.SuppliesGlass;
                    pbSupplierToUpdate.AccountCode = updateSupplierDTO.AccountCode;
                    pbSupplierToUpdate.OnHold = updateSupplierDTO.OnHold;
                    pbSupplierToUpdate.OnHoldReason = updateSupplierDTO.OnHoldReason;
                    pbSupplierToUpdate.ModifiedBy = updateSupplierDTO.ActionPerformedBy;
                    pbSupplierToUpdate.ModifiedDate = DateTime.Now;
                    pbSupplierToUpdate.PaymentsLessRebateStructure = updateSupplierDTO.PaymentsLessRebateStructure;
                    pbSupplierToUpdate.Obselete = updateSupplierDTO.Obselete;

                    if (updateSupplierDTO.SupplierType != null && updateSupplierDTO.SupplierType != "")
                    {
                        pbSupplierToUpdate.SupplierType = updateSupplierDTO.SupplierType;
                    }
                    if (updateSupplierDTO.SupplierGroupId != null && updateSupplierDTO.SupplierGroupId != "")
                    {
                        pbSupplierToUpdate.SupplierGroupId = Guid.Parse(updateSupplierDTO.SupplierGroupId);
                    }
                    if (updateSupplierDTO.RegionId != null && updateSupplierDTO.RegionId != "")
                    {
                        pbSupplierToUpdate.RegionId = Guid.Parse(updateSupplierDTO.RegionId);
                    }
                    else if (updateSupplierDTO.RegionId == "")
                    {
                        pbSupplierToUpdate.RegionId = null;
                        pbSupplierToUpdate.CityId = null;
                        pbSupplierToUpdate.SuburbId = null;
                    }
                    if (updateSupplierDTO.SuburbId != null && updateSupplierDTO.SuburbId != "")
                    {
                        pbSupplierToUpdate.SuburbId = Guid.Parse(updateSupplierDTO.SuburbId);
                    }
                    else if (updateSupplierDTO.SuburbId == "")
                    {
                        pbSupplierToUpdate.SuburbId = null;
                    }

                    if (updateSupplierDTO.CityId != null && updateSupplierDTO.CityId != "")
                    {
                        pbSupplierToUpdate.CityId = Guid.Parse(updateSupplierDTO.CityId);

                        if ((from s in _dbContext.PbSupplierSupplyAreas
                             where s.SupplierId.ToString() == updateSupplierDTO.SupplierId
                             select s).Any() == false)
                        {
                            Guid CityID = new Guid(updateSupplierDTO.CityId);
                            var addSuppArea = new PbSupplierSupplyArea()
                            {
                                SupplyAreaId = Guid.NewGuid(),
                                SupplierId = Guid.Parse(updateSupplierDTO.SupplierId),
                                CityId = CityID
                            };
                            addSuppArea.CreatedBy = updateSupplierDTO.ActionPerformedBy;
                            addSuppArea.CreatedDate = DateTime.Now;
                            await _dbContext.PbSupplierSupplyAreas.AddAsync(addSuppArea);
                        }
                    }
                    else if (updateSupplierDTO.CityId == "")
                    {
                        pbSupplierToUpdate.CityId = null;
                        pbSupplierToUpdate.SuburbId = null;
                    }

                    _dbContext.PbSuppliers.Update(pbSupplierToUpdate);

                    await _dbContext.SaveChangesAsync();

                    return new ResponseDTO()
                    {
                        KeyId = 1,
                        ResponseCode = ResponseCode.Success,
                        ResponseMessage = ResponseMessages.SupplierEdited
                    };
                }
            }
            catch (System.Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }

        public async Task<ResponseDTO> UpdateSupplierClientAsync(UpdateSupplierClientDTO updateSupplierClientDTO)
        {
            var supplierClientToUpdate = _dbContext.PbClientSuppliers.Where(x => x.ClientSupplierId.ToString() == updateSupplierClientDTO.ClientSupplierId).FirstOrDefault();

            if (supplierClientToUpdate == null)
            {
                throw new Exception(ResponseMessages.NoSupplierClientExists);
            }
            else
            {
                supplierClientToUpdate.AccountCode = updateSupplierClientDTO.AccountCode == "" ? null : updateSupplierClientDTO.AccountCode;
                supplierClientToUpdate.ModifiedBy = updateSupplierClientDTO.ActionPerformedBy;
                supplierClientToUpdate.ModifiedDate = DateTime.Now;

                _dbContext.PbClientSuppliers.Update(supplierClientToUpdate);
                await _dbContext.SaveChangesAsync();
                return new ResponseDTO()
                {
                    KeyId = 1,
                    ResponseCode = ResponseCode.Success,
                    ResponseMessage = ResponseMessages.SupplierClientUpdated
                };
            }
        }

        public async Task<ResponseDTO> UpdateSupplierExternalNameAsync(UpdateSupplierExternalNameDTO updateSupplierExternalNameDTO)
        {
            var importSupplierMappingToUpdate = _dbContext.ImportSupplierMappings.Where(x => x.SupplierMappingId.ToString() == updateSupplierExternalNameDTO.SupplierMappingId).FirstOrDefault();
            if (importSupplierMappingToUpdate == null)
            {
                throw new Exception(ResponseMessages.NoSupplierExternalNameExist);
            }
            else
            {
                importSupplierMappingToUpdate.SupplierNameExternal = updateSupplierExternalNameDTO.ExternalName;
                importSupplierMappingToUpdate.ModifiedBy = updateSupplierExternalNameDTO.ActionPerformedBy;
                importSupplierMappingToUpdate.ModifiedDate = DateTime.Now;

                _dbContext.ImportSupplierMappings.Update(importSupplierMappingToUpdate);

                await _dbContext.SaveChangesAsync();

                return new ResponseDTO()
                {
                    KeyId = 1,
                    ResponseCode = ResponseCode.Success,
                    ResponseMessage = ResponseMessages.SupplierExternalNameUpdated
                };
            }
        }

        private void SearchByName(ref IEnumerable<GetSuppliersDTO> studentLists, string SearchValue)
        {
            if (!studentLists.Any() || string.IsNullOrWhiteSpace(SearchValue))
                return;
            studentLists = studentLists.Where(o => o.SupplierId.ToString().ToLower().Contains(SearchValue.Trim().ToLower()) ||
            o.SupplierName.ToLower().Contains(SearchValue.Trim().ToLower()) || o.Email.ToLower().Contains(SearchValue.Trim().ToLower())
            || o.SupplierTradingName.ToLower().Contains(SearchValue.Trim().ToLower()));
        }
        private void SearchByName(ref IEnumerable<GetSuppliersNameDTO> supplierNameList, string SearchValue)
        {
            if (!supplierNameList.Any() || string.IsNullOrWhiteSpace(SearchValue))
                return;
            supplierNameList = supplierNameList.Where(o => o.SupplierId.ToString().ToLower().Contains(SearchValue.Trim().ToLower()) ||
            o.SupplierName.ToLower().Contains(SearchValue.Trim().ToLower()));
        }

        private void SearchByName(ref IEnumerable<GetRequestedSuppliersDTO> requestedSupplierList, string SearchValue)
        {
            if (!requestedSupplierList.Any() || string.IsNullOrWhiteSpace(SearchValue))
                return;
            requestedSupplierList = requestedSupplierList.Where(o => o.SupplierRegisterId.ToString().ToLower().Contains(SearchValue.Trim().ToLower()) ||
            o.SupplierName.ToLower().Contains(SearchValue.Trim().ToLower()) || o.Email.ToLower().Contains(SearchValue.Trim().ToLower())
            || o.CompanyRegNumber.ToLower().Contains(SearchValue.Trim().ToLower()));
        }
        private void SearchByName(ref IEnumerable<GetFilteredSuppliersDTO> supplierList, string SearchValue)
        {
            if (!supplierList.Any() || string.IsNullOrWhiteSpace(SearchValue))
                return;
            supplierList = supplierList.Where(o => o.SupplierName.ToString().ToLower().Contains(SearchValue.Trim().ToLower()));
        }
        private async Task<decimal> GetSupplierTotalRebateAsync(string SupplierId)
        {
            decimal totalRebate = 0;
            var model = new SearchRebatePercentBySupplierDTO()
            {
                SupplierId = Guid.Parse(SupplierId),
                InsurerId = null,
                ClientId = null,
                ShowDistinct = true
            };
            var response = await CollectionsAsync<GetRebatePercentBySupplierDTO>(StoreProcedures.GetRebatePercentBySupplier, model);

            foreach (var item in response)
            {
                if (item.ClientName.Contains("Default") && item.InsurerName.Contains("Default"))
                {
                    totalRebate = item.TotalPercent;
                    break;
                }
            }
            return totalRebate;
        }
        private AssignedLocations GetSupplierAssignedLocations(string SupplierId)
        {
            List<Guid?> parentLocationIds = (from l in _dbContext.Locations
                                             join x in _dbContext.PbSupplierSupplyAreas
                                             on l.LocationId equals x.CityId
                                             where x.SupplierId.ToString() == SupplierId
                                             select l.ParentLocationId
                                            ).ToList();

            var assignedRegions = (from s in _dbContext.Locations
                                   where parentLocationIds.Contains(s.LocationId)
                                   orderby s.Description
                                   select new AssignedLocation
                                   {
                                       LocationId = s.LocationId,
                                       Type = s.Type,
                                       Description = s.Description,
                                       ParentLocationId = s.ParentLocationId,
                                       IsAssigned = true,
                                       IsRemoved = false
                                   }).ToList();

            var assignedCities = (from s in _dbContext.Locations
                                  join x in _dbContext.PbSupplierSupplyAreas on s.LocationId equals x.CityId
                                  where x.SupplierId.ToString() == SupplierId
                                  orderby s.Description
                                  select new AssignedLocation
                                  {
                                      LocationId = s.LocationId,
                                      Type = s.Type,
                                      Description = s.Description,
                                      ParentLocationId = s.ParentLocationId,
                                      IsAssigned = true,
                                      IsRemoved = false
                                  }).ToList();

            return new AssignedLocations()
            {
                AssignedCities = assignedCities,
                AssignedRegions = assignedRegions
            };
        }

        public async Task<ResponseDTO> UpdateSupplyLocationsAsync(UpdateSupplyLocationsDTO updateSupplyLocationsDTO)
        {
            var locationsToRemove = updateSupplyLocationsDTO.SupplyLocations.Where(x => x.IsRemoved == true).Select(x => x.LocationId).ToList();
            var locationsToAdd = updateSupplyLocationsDTO.SupplyLocations.Where(x => x.IsAssigned == true).Select(x => x.LocationId).ToList();

            if (locationsToRemove.Count > 0)
            {
                foreach (var location in locationsToRemove)
                {
                    var locationToRemove = _dbContext.PbSupplierSupplyAreas.Where(x => x.SupplierId.ToString() == updateSupplyLocationsDTO.SupplierId && x.CityId.ToString() == location).FirstOrDefault();

                    _dbContext.PbSupplierSupplyAreas.Remove(locationToRemove);

                    await _dbContext.SaveChangesAsync();
                }
            }

            if (locationsToAdd.Count > 0)
            {
                foreach (var location in locationsToAdd)
                {
                    var locationInDb = _dbContext.PbSupplierSupplyAreas.Where(x => x.SupplierId.ToString() == updateSupplyLocationsDTO.SupplierId && x.CityId == Guid.Parse(location)).FirstOrDefault();
                    if (locationInDb == null)
                    {
                        var locationToAdd = new PbSupplierSupplyArea();

                        locationToAdd.SupplyAreaId = Guid.NewGuid();
                        locationToAdd.SupplierId = Guid.Parse(updateSupplyLocationsDTO.SupplierId);
                        locationToAdd.CityId = Guid.Parse(location);
                        locationToAdd.CreatedBy = updateSupplyLocationsDTO.ActionPerformedBy;
                        locationToAdd.CreatedDate = DateTime.Now;
                        locationToAdd.ModifiedBy = updateSupplyLocationsDTO.ActionPerformedBy;
                        locationToAdd.ModeifiedDate = DateTime.Now;

                        await _dbContext.PbSupplierSupplyAreas.AddAsync(locationToAdd);
                        await _dbContext.SaveChangesAsync();
                    }

                }

            }

            return new ResponseDTO()
            {
                KeyId = 1,
                ResponseCode = ResponseCode.Success,
                ResponseMessage = ResponseMessages.SupplyLocationsUpdated
            };

        }

        public IEnumerable<GetUnassignedSupplierBrandsDTO> GetUnassignedSupplierBrands(SearchUnassignedSupplierBrandsDTO searchUnassignedSupplierBrandsDTO)
        {
            if (searchUnassignedSupplierBrandsDTO.SupplierId != null && searchUnassignedSupplierBrandsDTO.SupplierId != "")
            {
                IEnumerable<GetUnassignedSupplierBrandsDTO> brandsList = (from b in _dbContext.PbBrands
                                                                          select new GetUnassignedSupplierBrandsDTO
                                                                          {
                                                                              BrandId = b.BrandId,
                                                                              Brand = b.Brand
                                                                          }).ToList();

                var supplierBrands = (from sb in _dbContext.PbSupplierBrands
                                      join b in _dbContext.PbBrands
                                      on sb.BrandId equals b.BrandId
                                      where sb.SupplierId.ToString() == searchUnassignedSupplierBrandsDTO.SupplierId
                                      select new
                                      {
                                          BrandId = sb.BrandId,
                                          Brand = b.Brand
                                      }).ToList();

                brandsList = brandsList.Where(x => !supplierBrands.Any(y => y.BrandId == x.BrandId)).ToList();
                return brandsList.OrderBy(x => x.Brand);
            }
            return new List<GetUnassignedSupplierBrandsDTO>();
        }

        public async Task<ResponseDTO> AddSupplierRequestAsync(AddSupplierRequestDTO addSupplierRequestDTO)
        {
            try
            {
                if (addSupplierRequestDTO.SupplierName == "" || addSupplierRequestDTO.CompanyRegNumber == "" || addSupplierRequestDTO.EstimatedMonthlyPurchases == 0)
                {
                    throw new Exception(ResponseMessages.AddRequiredFields);
                }
                else
                {
                    Guid requestId = Guid.NewGuid();

                    var newSupplierRequest = new PbSuppliersRequest();
                    newSupplierRequest.RequestId = requestId;
                    newSupplierRequest.SupplierName = addSupplierRequestDTO.SupplierName;
                    newSupplierRequest.CompanyRegNumber = addSupplierRequestDTO.CompanyRegNumber;
                    newSupplierRequest.Email = addSupplierRequestDTO.Email;
                    newSupplierRequest.TelNumber = addSupplierRequestDTO.TelNumber;
                    newSupplierRequest.CellNumber = addSupplierRequestDTO.CellNumber;
                    newSupplierRequest.FaxNumber = addSupplierRequestDTO.FaxNumber;
                    newSupplierRequest.PhysicalAddr1 = addSupplierRequestDTO.PhysicalAddress1;
                    newSupplierRequest.PhysicalAddr2 = addSupplierRequestDTO.PhysicalAddress2;
                    newSupplierRequest.PhysicalAddr3 = addSupplierRequestDTO.PhysicalAddress3;
                    newSupplierRequest.PhysicalAddrCode = addSupplierRequestDTO.PhysicalAddressCode;
                    newSupplierRequest.EstimatedMonthlyPurchases = addSupplierRequestDTO.EstimatedMonthlyPurchases;
                    newSupplierRequest.PostalAddr1 = addSupplierRequestDTO.PostalAddress1;
                    newSupplierRequest.PostalAddr2 = addSupplierRequestDTO.PostalAddress2;
                    newSupplierRequest.PostalAddr3 = addSupplierRequestDTO.PostalAddressCode;
                    newSupplierRequest.CreatedBy = addSupplierRequestDTO.ActionPerformedBy;
                    newSupplierRequest.CreatedDate = DateTime.Now;
                    newSupplierRequest.Completed = false;

                    await _dbContext.PbSuppliersRequests.AddAsync(newSupplierRequest);

                    var recipients = (from x in _dbContext.AdministrationConfigs
                                      where x.Category == "SUPPLIERREQUEST" && x.Item == "RECIPIENTS"
                                      select x).FirstOrDefault();

                    var sendEmail = new PbCorrespondance();
                    sendEmail.CorrespondanceId = Guid.NewGuid();
                    sendEmail.Username = addSupplierRequestDTO.ActionPerformedBy;
                    sendEmail.MessageCategory = "New Supplier Request";
                    sendEmail.MessageType = "EMAIL";
                    sendEmail.Recipients = recipients.Value;
                    sendEmail.MessageContent = "<p>Good day,</p> <p>This email is requesting the creation of a new supplier.</p> <table>  <tbody>  <tr> ";
                    sendEmail.MessageContent += "<td>Supplier Name:</td>    ";
                    sendEmail.MessageContent += "<td>" + addSupplierRequestDTO.SupplierName + "</td> </tr>  <tr> <td>Telephone Number:</td> <td> " + addSupplierRequestDTO.TelNumber + "  </td> </tr> <tr>  <td>Email:</td>  <td>" + addSupplierRequestDTO.Email + "</td> </tr>  <tr>  <td>Requested By:</td>  <td>" + addSupplierRequestDTO.ActionPerformedBy + "</td> </tr>  ";
                    sendEmail.MessageContent += "</tbody> </table> ";
                    sendEmail.MessageContent += "<strong>This is an automated email, please do not reply to this address.";
                    sendEmail.MessageContent += "<p>&nbsp;</p>  <div> <p>Many thanks,</p>";
                    sendEmail.MessageContent += "<p>With kind regards.</p>  ";
                    sendEmail.MessageContent += "<p><strong>Demo FINANCIAL SERVICES</strong></p>  ";
                    sendEmail.MessageContent += "<p>031&nbsp;818 0080 &ndash; Office <strong>I </strong>031&nbsp;818 0081 &ndash; Fax</p>";
                    sendEmail.MessageContent += "45 Old Main Road, Kloof <strong>I</strong> PO Box 1032, Wandsbeck, 3631</div> ";
                    sendEmail.MessageSubject = "New Supplier Request";
                    sendEmail.LogDate = DateTime.Now;

                    await _dbContext.PbCorrespondances.AddAsync(sendEmail);

                    var res = await _dbContext.SaveChangesAsync();

                    return new ResponseDTO()
                    {
                        KeyId = 1,
                        ResponseCode = ResponseCode.Success,
                        ResponseMessage = ResponseMessages.SupplierRequested
                    };
                }                
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}