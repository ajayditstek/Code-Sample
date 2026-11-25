using System.Collections.Generic;
using AutoMapper;
using Demo.Core.DTOs.Response;
using Demo.Core.Interfaces;
using Demo.Core.Model;
using System.Linq;
using System;
using Demo.Repository.Common.StoreProcedures;
using System.Threading.Tasks;
using Demo.Core.DTOs.Request;
using Demo.Repository.Enums;
using Demo.Repository.GenricRepo;
using System.Data.Entity;

namespace Demo.Repository.Repository
{
    public class PanelBeatersRepository : GenericRepository<PbClient>, IPanelBeatersRepository
    {
        private readonly UATDemoPortalContext _dbContext;
        public PanelBeatersRepository(UATDemoPortalContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
        }

        public async Task<IEnumerable<GetPanelBeaterDropdownDTO>> GetPanelBeaterDropdownsAsync(SearchPanelBeaterDropdownDTO searchPanelBeaterDropdownDTO)
        {
            IEnumerable<GetPanelBeaterDropdownDTO> listData = null;
            if (searchPanelBeaterDropdownDTO.Type == "Bank Allocation")
            {
                listData = await CollectionsAsync<GetPanelBeaterDropdownDTO>(StoreProcedures.GetUsersInRole, new { Role = "pbBankAllocation" });
            }
            else if (searchPanelBeaterDropdownDTO.Type == "Final Invoice Notification Email")
            {
                listData = await CollectionsAsync<GetPanelBeaterDropdownDTO>(StoreProcedures.GetUsersInRole, new { Role = "glrDemo" });
            }
            else if (searchPanelBeaterDropdownDTO.Type == "Mettle Debtor")
            {
                listData = await CollectionsAsync<GetPanelBeaterDropdownDTO>(StoreProcedures.GetUsersInRole, new { Role = "MettleDebtFact" });
            }
            else if (searchPanelBeaterDropdownDTO.Type == "Final Invoice Payment")
            {
                listData = await CollectionsAsync<GetPanelBeaterDropdownDTO>(StoreProcedures.GetUsersInRole, new { Role = "praxClaimAdministrator" });
            }
            else if (searchPanelBeaterDropdownDTO.Type == "WIP Alert Person" || searchPanelBeaterDropdownDTO.Type == "Parts Summary Alert Person" || searchPanelBeaterDropdownDTO.Type == "Parts Summary Alert Person(Pop Up)" || searchPanelBeaterDropdownDTO.Type == "Debtor")
            {
                listData = await CollectionsAsync<GetPanelBeaterDropdownDTO>(StoreProcedures.GetUsersInRole, new { Role = "praxClaimController" });
            }

            return listData.OrderBy(x => x.Username);
        }

        public GetNextPanelBeaterClientExternalIdDTO GetNextPanelBeaterClientExternalId()
        {
            var lastExternalId = _dbContext.PbClients.Where(x => x.ExternalId != null).Select(x => Convert.ToInt32(x.ExternalId)).ToList().Max();

            return new GetNextPanelBeaterClientExternalIdDTO()
            {
                ExternalId = (lastExternalId + 1)
            };
        }

        public GetPanelBeaterClientDetailsDTO GetPanelBeaterClientDetails(SearchPanelBeaterClientDeatilsDTO searchPanelBeaterClientDeatilsDTO)
        {
            var panelBeaterDetails = (from pbc in _dbContext.PbClients
                                      where pbc.ClientId.ToString() == searchPanelBeaterClientDeatilsDTO.ClientId
                                      select new GetPanelBeaterClientDetailsDTO
                                      {
                                          ClientId = pbc.ClientId,
                                          ClientName = pbc.ClientName,
                                          ClientTradingName = pbc.ClientTradingName,
                                          CompanyRegNumber = pbc.CompanyRegNumber,
                                          VATRegNumber = pbc.VatregNumber,
                                          TMSClientCode = pbc.TmsclientCode,
                                          Email = pbc.Email,
                                          NotificationEmailAddress = pbc.NotificationEmailAddress,
                                          PartsAuthEmailAddress = pbc.PartsAuthEmailAddress,
                                          TMSNotificationEmailAddress = pbc.TmsnotificationEmailAddress,
                                          PaymentNotificationEMail = pbc.PaymentNotificationEmail,
                                          TMSNotificationEmailAddressNewReference = pbc.TmsnotificationEmailAddressNewReference,
                                          TMSNotificationEmailAddressPartsSummaries = pbc.TmsnotificationEmailAddressPartsSummaries,
                                          TelNumber = pbc.TelNumber,
                                          FaxNumber = pbc.FaxNumber,
                                          CellNumber = pbc.CellNumber,
                                          PhysicalAddr1 = pbc.PhysicalAddr1,
                                          PhysicalAddr2 = pbc.PhysicalAddr2,
                                          PhysicalAddr3 = pbc.PhysicalAddr3,
                                          PhysicalAddrCode = pbc.PhysicalAddrCode,
                                          PostalAddr1 = pbc.PostalAddr1,
                                          PostalAddr2 = pbc.PostalAddr2,
                                          PostalAddr3 = pbc.PostalAddr3,
                                          PostalAddrCode = pbc.PostalAddrCode,
                                          AccountCode = pbc.AccountCode,
                                          LoanAccountCode = pbc.LoanAccountCode,
                                          ExternalId = pbc.ExternalId,
                                          OnHold = (pbc.OnHold == null ? false : pbc.OnHold),
                                          OnHoldReason = (pbc.OnHoldReason == null ? "" : pbc.OnHoldReason),
                                          PayAndClear = (pbc.PayAndClear == null ? false : pbc.PayAndClear),
                                          RemittanceContactEmail = pbc.RemittanceContactEmail,
                                          RemittanceContactPerson = pbc.RemittanceContactPerson,
                                          Active = (pbc.Active == null ? false : pbc.OnHold),
                                          Legal = (pbc.Legal == null ? false : pbc.Legal),
                                          DeductionCODFeeEnabled = pbc.DeductionCodfeeEnabled,
                                          FactorerId = pbc.FactorerId,
                                          EnableDeductions = (pbc.EnableDeductions == null ? true : pbc.EnableDeductions),
                                          IgnoreInsurerRebate = (pbc.EnableDeductions == null ? false : pbc.EnableDeductions),
                                          FinalInvoiceNotificationEmail = pbc.FinalInvoiceNotificationEmail,
                                          RegionId = pbc.RegionId,
                                          CityId = pbc.CityId,
                                          SuburbId = pbc.SuburbId,
                                          BatchPayments = (pbc.BatchPayments == null ? false : true),
                                          DefaultFunding = pbc.DefaultFunding,
                                          ContingencyPercent = pbc.ContingencyPercent,
                                          ClaimAdministrator = pbc.ClaimAdministrator,
                                          WIPAlertPerson = pbc.WipalertPerson,
                                          PartsSummaryAlertPerson = pbc.PartsSummaryAlertPerson,
                                          PopUpPartsSummaryAlertPerson = pbc.PopUpPartsSummaryAlertPerson,
                                          ClaimController = pbc.ClaimController,
                                          ClaimControllerAlt = pbc.ClaimControllerAlt,
                                          BankAllocation = pbc.BankAllocation,
                                          Rating = pbc.Rating,
                                          Recipients = (from x in _dbContext.PbReportScheduleRecipients
                                                        join s in _dbContext.PbReportToPdfs
                                                        on x.ReportId equals s.ReportsToPdfid
                                                        select new Recipient
                                                        {
                                                            ReportSchedulerRecipients = x.ReportSchedulerRecipients,
                                                            Recipients = x.Recipients,
                                                            DisplayName = s.DisplayName,
                                                            ReportsToPDFID = s.ReportsToPdfid
                                                        }).ToList(),
                                          PanelBeaterClientSuppliers = (from pbcs in _dbContext.PbClientSuppliers
                                                                        join c in _dbContext.PbClients
                                                                        on pbcs.ClientId equals c.ClientId
                                                                        join s in _dbContext.PbSuppliers
                                                                        on pbcs.SupplierId equals s.SupplierId
                                                                        where c.ClientId == pbc.ClientId
                                                                        select new PanelBeaterClientSupplier
                                                                        {
                                                                            ClientSupplierId = pbcs.ClientSupplierId,
                                                                            ClientId = pbcs.ClientId,
                                                                            SupplierId = pbcs.SupplierId,
                                                                            AccountCode = pbcs.AccountCode,
                                                                            SupplierName = s.SupplierName,
                                                                            NotificationEmailAddress = pbcs.NotificationEmailAddress
                                                                        }).ToList()
                                      }).FirstOrDefault();
            return panelBeaterDetails;
        }

        public IEnumerable<GetPanelBeaterClientsDTO> GetPanelBeaterClients(SearchPanelBeaterClientsDTO searchPanelBeaterClientsDTO)
        {
            IEnumerable<GetPanelBeaterClientsDTO> panelBeaterClients = (from c in _dbContext.PbClients
                                                                        select new GetPanelBeaterClientsDTO
                                                                        {
                                                                            ClientId = c.ClientId,
                                                                            ClientName = c.ClientName
                                                                        }).OrderBy(x => x.ClientName);

            if (searchPanelBeaterClientsDTO.ClientId != null)
                panelBeaterClients = panelBeaterClients.Where(x => x.ClientId.ToString() == searchPanelBeaterClientsDTO.ClientId);

            SearchByName(ref panelBeaterClients, searchPanelBeaterClientsDTO.SearchValue);

            if (searchPanelBeaterClientsDTO.OrderByDescending == true)
            {
                if (searchPanelBeaterClientsDTO.OrderBy != null)
                {
                    panelBeaterClients = panelBeaterClients.OrderByDescending(x => x.GetType().GetProperty(searchPanelBeaterClientsDTO.OrderBy).GetValue(x));
                }
            }
            else
            {
                if (searchPanelBeaterClientsDTO.OrderBy != null)
                {
                    panelBeaterClients = panelBeaterClients.OrderBy(x => x.GetType().GetProperty(searchPanelBeaterClientsDTO.OrderBy).GetValue(x));
                }
            }
            int count = panelBeaterClients.Count();

            if (searchPanelBeaterClientsDTO.AllRecords)
                panelBeaterClients = panelBeaterClients.ToList();
            else
                panelBeaterClients = panelBeaterClients.Skip((searchPanelBeaterClientsDTO.PageNo - 1) * searchPanelBeaterClientsDTO.PageSize).Take(searchPanelBeaterClientsDTO.PageSize).ToList();


            return panelBeaterClients;
        }

        private void SearchByName(ref IEnumerable<GetPanelBeaterClientsDTO> panelBeaterClients, string SearchValue)
        {
            if (!panelBeaterClients.Any() || string.IsNullOrWhiteSpace(SearchValue))
                return;
            panelBeaterClients = panelBeaterClients.Where(o => o.ClientId.ToString().ToLower().Contains(SearchValue.Trim().ToLower()) ||
            o.ClientName.ToLower().Contains(SearchValue.Trim().ToLower()));
        }

        public IEnumerable<GetFundedByDTO> GetFactors()
        {
            var factorerList = (from f in _dbContext.Factorers
                                select new GetFundedByDTO
                                {
                                    FactorerId = f.FactorerId,
                                    FactorerName = f.FactorerName
                                }).ToList();
            return factorerList;
        }

        public async Task<ResponseDTO> AddPanelBeaterClientAsync(AddPanelBeaterClientDTO addPanelBeaterClientDTO)
        {

            var pbClientWithSameNameCount = _dbContext.PbClients.Where(x => x.ClientName == addPanelBeaterClientDTO.ClientName).Count();
            if (pbClientWithSameNameCount > 0)
            {
                return new ResponseDTO()
                {
                    KeyId = -1,
                    ResponseCode = 500,
                    ResponseMessage = ResponseMessages.PanelBeaterClientWithSameNameExists
                };
            }
            else
            {
                var pbClient = new PbClient();

                pbClient.ClientId = Guid.NewGuid();
                pbClient.ClientName = addPanelBeaterClientDTO.ClientName;
                pbClient.ClientTradingName = addPanelBeaterClientDTO.ClientTradingName;
                pbClient.CompanyRegNumber = addPanelBeaterClientDTO.CompanyRegNumber;
                pbClient.VatregNumber = addPanelBeaterClientDTO.VATRegNumber;
                pbClient.ExternalId = addPanelBeaterClientDTO.ExternalID;
                pbClient.TmsclientCode = addPanelBeaterClientDTO.TMSClientCode;
                pbClient.Email = addPanelBeaterClientDTO.Email;
                pbClient.NotificationEmailAddress = addPanelBeaterClientDTO.NotificationEmailAddress;
                pbClient.PartsAuthEmailAddress = addPanelBeaterClientDTO.PartsAuthEmailAddress;
                pbClient.TmsnotificationEmailAddress = addPanelBeaterClientDTO.TMSNotificationEmailAddress;
                pbClient.TmsnotificationEmailAddressNewReference = addPanelBeaterClientDTO.tmsNotificationEmailAddressNewReference;
                pbClient.TmsnotificationEmailAddressPartsSummaries = addPanelBeaterClientDTO.tmsNotificationEmailAddressPartsSummaries;
                pbClient.PaymentNotificationEmail = addPanelBeaterClientDTO.PaymentNotificationEMail;
                pbClient.TelNumber = addPanelBeaterClientDTO.TelNumber;
                pbClient.FaxNumber = addPanelBeaterClientDTO.FaxNumber;
                pbClient.CellNumber = addPanelBeaterClientDTO.CellNumber;
                pbClient.PhysicalAddr1 = addPanelBeaterClientDTO.PhysicalAddr1;
                pbClient.PhysicalAddr2 = addPanelBeaterClientDTO.PhysicalAddr2;
                pbClient.PhysicalAddr3 = addPanelBeaterClientDTO.PhysicalAddr3;
                pbClient.PhysicalAddrCode = addPanelBeaterClientDTO.PhysicalAddrCode;
                pbClient.PostalAddr1 = addPanelBeaterClientDTO.PostalAddr1;
                pbClient.PostalAddr2 = addPanelBeaterClientDTO.PostalAddr2;
                pbClient.PostalAddr3 = addPanelBeaterClientDTO.PostalAddr3;
                pbClient.PostalAddrCode = addPanelBeaterClientDTO.PostalAddrCode;
                pbClient.WipalertPerson = addPanelBeaterClientDTO.WIPAlertPerson;
                pbClient.AccountCode = addPanelBeaterClientDTO.AccountCode;
                pbClient.LoanAccountCode = addPanelBeaterClientDTO.LoanAccountCode;
                pbClient.Rating = addPanelBeaterClientDTO.Rating;
                pbClient.RemittanceContactEmail = addPanelBeaterClientDTO.RemittanceContactEmail;
                pbClient.RemittanceContactPerson = addPanelBeaterClientDTO.RemittanceContactPerson;
                pbClient.PayAndClear = addPanelBeaterClientDTO.PayAndClear;
                pbClient.ClaimAdministrator = addPanelBeaterClientDTO.ClaimAdministrator;
                pbClient.PartsSummaryAlertPerson = addPanelBeaterClientDTO.PartsSummaryAlertPerson;
                pbClient.EnableDeductions = addPanelBeaterClientDTO.EnableDeductions;
                pbClient.FinalInvoiceNotificationEmail = addPanelBeaterClientDTO.FinalInvoiceNotificationEmail;
                pbClient.BatchPayments = addPanelBeaterClientDTO.BatchPayments == true ? 1 : 0;
                pbClient.IgnoreInsurerRebate = addPanelBeaterClientDTO.IgnoreInsurerRebate;
                pbClient.PopUpPartsSummaryAlertPerson = addPanelBeaterClientDTO.PopUpPartsSummaryAlertPerson;
                pbClient.ClaimController = addPanelBeaterClientDTO.ClaimController;
                pbClient.ClaimControllerAlt = addPanelBeaterClientDTO.ClaimControllerAlt;
                pbClient.BankAllocation = addPanelBeaterClientDTO.BankAllocation;
                pbClient.OnHold = addPanelBeaterClientDTO.OnHold;
                pbClient.OnHoldReason = addPanelBeaterClientDTO.OnHoldReason;
                pbClient.DeductionCodfeeEnabled = addPanelBeaterClientDTO.DeductionCodfeeEnabled;
                pbClient.IgnoreInsurerRebate = addPanelBeaterClientDTO.IgnoreInsurerRebate;

                if (addPanelBeaterClientDTO.RegionId != null && addPanelBeaterClientDTO.RegionId != "")
                {
                    pbClient.RegionId = Guid.Parse(addPanelBeaterClientDTO.RegionId);
                }
                if (addPanelBeaterClientDTO.CityId != null && addPanelBeaterClientDTO.CityId != "")
                {
                    pbClient.CityId = Guid.Parse(addPanelBeaterClientDTO.CityId);
                }
                if (addPanelBeaterClientDTO.SuburbId != null && addPanelBeaterClientDTO.SuburbId != "")
                {
                    pbClient.SuburbId = Guid.Parse(addPanelBeaterClientDTO.SuburbId);
                }
                if (addPanelBeaterClientDTO.FactorerId != null && addPanelBeaterClientDTO.FactorerId != "")
                {
                    pbClient.FactorerId = Guid.Parse(addPanelBeaterClientDTO.FactorerId);
                }

                pbClient.DefaultFunding = addPanelBeaterClientDTO.DefaultFunding;
                pbClient.ContingencyPercent = addPanelBeaterClientDTO.ContingencyPercent;
                pbClient.CreatedBy = addPanelBeaterClientDTO.ActionPerformedBy;
                pbClient.CreatedDate = DateTime.Now;
                pbClient.ModifiedBy = addPanelBeaterClientDTO.ActionPerformedBy;
                pbClient.ModifiedDate = DateTime.Now;

                await _dbContext.PbClients.AddAsync(pbClient);

                await _dbContext.SaveChangesAsync();
                return new ResponseDTO()
                {
                    KeyId = 1,
                    ResponseCode = ResponseCode.Success,
                    ResponseMessage = ResponseMessages.PanelBeaterClientAdded
                };
            }
        }

        public async Task<ResponseDTO> UpdatePanelBeaterClientAsync(UpdatePanelBeaterClientDTO updatePanelBeaterClientDTO)
        {
            var pbClientToUpdate = (from pbc in _dbContext.PbClients
                                    where pbc.ClientId.ToString() == updatePanelBeaterClientDTO.ClientId
                                    select pbc).FirstOrDefault();

            if (pbClientToUpdate == null)
            {
                return new ResponseDTO()
                {
                    KeyId = -1,
                    ResponseCode = 500,
                    ResponseMessage = ResponseMessages.NoPanelBeaterExists
                };
            }
            else
            {
                pbClientToUpdate.ClientName = updatePanelBeaterClientDTO.ClientName;
                pbClientToUpdate.ClientTradingName = updatePanelBeaterClientDTO.ClientTradingName;
                pbClientToUpdate.CompanyRegNumber = updatePanelBeaterClientDTO.CompanyRegNumber;
                pbClientToUpdate.VatregNumber = updatePanelBeaterClientDTO.VATRegNumber;
                pbClientToUpdate.TmsclientCode = updatePanelBeaterClientDTO.TMSClientCode;
                pbClientToUpdate.Email = updatePanelBeaterClientDTO.Email;
                pbClientToUpdate.NotificationEmailAddress = updatePanelBeaterClientDTO.NotificationEmailAddress;
                pbClientToUpdate.PartsAuthEmailAddress = updatePanelBeaterClientDTO.PartsAuthEmailAddress;
                pbClientToUpdate.TmsnotificationEmailAddress = updatePanelBeaterClientDTO.TMSNotificationEmailAddress;
                pbClientToUpdate.PaymentNotificationEmail = updatePanelBeaterClientDTO.PaymentNotificationEMail;
                pbClientToUpdate.TelNumber = updatePanelBeaterClientDTO.TelNumber;
                pbClientToUpdate.FaxNumber = updatePanelBeaterClientDTO.FaxNumber;
                pbClientToUpdate.CellNumber = updatePanelBeaterClientDTO.CellNumber;
                pbClientToUpdate.PhysicalAddr1 = updatePanelBeaterClientDTO.PhysicalAddr1;
                pbClientToUpdate.PhysicalAddr2 = updatePanelBeaterClientDTO.PhysicalAddr2;
                pbClientToUpdate.PhysicalAddr3 = updatePanelBeaterClientDTO.PhysicalAddr3;
                pbClientToUpdate.PhysicalAddrCode = updatePanelBeaterClientDTO.PhysicalAddrCode;
                pbClientToUpdate.PostalAddr1 = updatePanelBeaterClientDTO.PostalAddr1;
                pbClientToUpdate.PostalAddr2 = updatePanelBeaterClientDTO.PostalAddr2;
                pbClientToUpdate.PostalAddr3 = updatePanelBeaterClientDTO.PostalAddr3;
                pbClientToUpdate.PostalAddrCode = updatePanelBeaterClientDTO.PostalAddrCode;
                pbClientToUpdate.WipalertPerson = updatePanelBeaterClientDTO.WIPAlertPerson;
                pbClientToUpdate.AccountCode = updatePanelBeaterClientDTO.AccountCode;
                pbClientToUpdate.LoanAccountCode = updatePanelBeaterClientDTO.LoanAccountCode;
                pbClientToUpdate.Rating = updatePanelBeaterClientDTO.Rating;
                pbClientToUpdate.RemittanceContactEmail = updatePanelBeaterClientDTO.RemittanceContactEmail;
                pbClientToUpdate.RemittanceContactPerson = updatePanelBeaterClientDTO.RemittanceContactPerson;
                pbClientToUpdate.PayAndClear = updatePanelBeaterClientDTO.PayAndClear;
                pbClientToUpdate.EnableDeductions = updatePanelBeaterClientDTO.EnableDeductions;
                pbClientToUpdate.FinalInvoiceNotificationEmail = updatePanelBeaterClientDTO.FinalInvoiceNotificationEmail;
                pbClientToUpdate.BatchPayments = updatePanelBeaterClientDTO.BatchPayments == true ? 1 : 0;
                pbClientToUpdate.PopUpPartsSummaryAlertPerson = updatePanelBeaterClientDTO.PopUpPartsSummaryAlertPerson;
                pbClientToUpdate.IgnoreInsurerRebate = updatePanelBeaterClientDTO.IgnoreInsurerRebate;
                pbClientToUpdate.Active = updatePanelBeaterClientDTO.Active;
                pbClientToUpdate.Legal = updatePanelBeaterClientDTO.Legal;
                pbClientToUpdate.OnHold = updatePanelBeaterClientDTO.OnHold;
                pbClientToUpdate.OnHoldReason = updatePanelBeaterClientDTO.OnHoldReason;
                pbClientToUpdate.PartsSummaryAlertPerson = updatePanelBeaterClientDTO.PartsSummaryAlertPerson;
                pbClientToUpdate.TmsnotificationEmailAddressNewReference = updatePanelBeaterClientDTO.tmsNotificationEmailAddressNewReference;
                pbClientToUpdate.TmsnotificationEmailAddressPartsSummaries = updatePanelBeaterClientDTO.tmsNotificationEmailAddressPartsSummaries;
                pbClientToUpdate.ClaimAdministrator = updatePanelBeaterClientDTO.ClaimAdministrator;
                pbClientToUpdate.PopUpPartsSummaryAlertPerson = updatePanelBeaterClientDTO.PartsSummaryAlertPerson;
                pbClientToUpdate.ClaimController = updatePanelBeaterClientDTO.ClaimController;
                pbClientToUpdate.BankAllocation = updatePanelBeaterClientDTO.BankAllocation;
                pbClientToUpdate.ClaimControllerAlt = updatePanelBeaterClientDTO.ClaimControllerAlt;
                pbClientToUpdate.ModifiedBy = updatePanelBeaterClientDTO.ActionPerformedBy;
                pbClientToUpdate.ModifiedDate = DateTime.Now;
                pbClientToUpdate.DeductionCodfeeEnabled = updatePanelBeaterClientDTO.DeductionCodfeeEnabled;
                pbClientToUpdate.PartsSummaryAlertPerson = updatePanelBeaterClientDTO.PartsSummaryAlertPerson;
                pbClientToUpdate.DefaultFunding = updatePanelBeaterClientDTO.DefaultFunding;
                pbClientToUpdate.ContingencyPercent = updatePanelBeaterClientDTO.ContingencyPercent;


                if (updatePanelBeaterClientDTO.FactorerId != null && updatePanelBeaterClientDTO.FactorerId != "")
                {
                    pbClientToUpdate.FactorerId = Guid.Parse(updatePanelBeaterClientDTO.FactorerId);
                }

                if (updatePanelBeaterClientDTO.CityId != null && updatePanelBeaterClientDTO.CityId != "")
                {
                    pbClientToUpdate.CityId = Guid.Parse(updatePanelBeaterClientDTO.CityId);
                }
                if (updatePanelBeaterClientDTO.SuburbId != null && updatePanelBeaterClientDTO.SuburbId != "")
                {
                    pbClientToUpdate.SuburbId = Guid.Parse(updatePanelBeaterClientDTO.SuburbId);
                }
                if (updatePanelBeaterClientDTO.RegionId != null && updatePanelBeaterClientDTO.RegionId != "")
                {
                    pbClientToUpdate.RegionId = Guid.Parse(updatePanelBeaterClientDTO.RegionId);
                }


                _dbContext.PbClients.Update(pbClientToUpdate);

                await _dbContext.SaveChangesAsync();
                return new ResponseDTO()
                {
                    KeyId = -1,
                    ResponseCode = ResponseCode.Success,
                    ResponseMessage = ResponseMessages.PanelBeaterClientUpdated
                };
            }
        }

        public async Task<ResponseDTO> UpdatePanelBeaterClientSupplierAsync(UpdatePanelBeaterClientSupplierDTO updatePanelBeaterClientSupplierDTO)
        {

            var pbClientSupplierToUpdate = (from pbcs in _dbContext.PbClientSuppliers
                                            where pbcs.ClientSupplierId.ToString() == updatePanelBeaterClientSupplierDTO.ClientSupplierId
                                            select pbcs
                                            ).FirstOrDefault();

            if (pbClientSupplierToUpdate == null)
            {
                throw new Exception(ResponseMessages.NoPbClientSupplierExists);
            }
            else
            {

                pbClientSupplierToUpdate.AccountCode = updatePanelBeaterClientSupplierDTO.AccountCode == "" ? null : updatePanelBeaterClientSupplierDTO.AccountCode;
                pbClientSupplierToUpdate.ModifiedBy = updatePanelBeaterClientSupplierDTO.ActionPerformedBy;
                pbClientSupplierToUpdate.ModifiedDate = DateTime.Now;

                _dbContext.PbClientSuppliers.Update(pbClientSupplierToUpdate);
                await _dbContext.SaveChangesAsync();

                return new ResponseDTO()
                {
                    KeyId = -1,
                    ResponseCode = ResponseCode.Success,
                    ResponseMessage = ResponseMessages.PbClientSupplierUpdated
                };
            }
        }

        public IEnumerable<GetDefaultFundingDTO> GetDefaultFundings()
        {
            var defaultFundingsList = (from df in _dbContext.PbProductDefinitions
                                       select new GetDefaultFundingDTO
                                       {
                                           ProductDefinitionId = df.ProductDefinitionId,
                                           InvoiceDiscountPercentage = df.InvoiceDiscountPercentage,
                                           Description = df.Description
                                       }).ToList();
            return defaultFundingsList;
        }

        public async Task<ResponseDTO> UpdateSupplierNotificationEmailAsync(UpdateSupplierNotificationEmailDTO updateSupplierNotificationEmailDTO)
        {
            var clientSupplierToUpdate = _dbContext.PbClientSuppliers.Where(x => x.ClientSupplierId.ToString() == updateSupplierNotificationEmailDTO.ClientSupplierId).FirstOrDefault();

            if (clientSupplierToUpdate == null)
            {
                throw new Exception(ResponseMessages.NoPbClientSupplierExists);
            }
            else
            {

                clientSupplierToUpdate.NotificationEmailAddress = updateSupplierNotificationEmailDTO.NotificationEmailAddress == "" ? null : updateSupplierNotificationEmailDTO.NotificationEmailAddress;
                clientSupplierToUpdate.ModifiedBy = updateSupplierNotificationEmailDTO.ActionPerformedBy;
                clientSupplierToUpdate.ModifiedDate = DateTime.Now;

                _dbContext.PbClientSuppliers.Update(clientSupplierToUpdate);
                await _dbContext.SaveChangesAsync();
                return new ResponseDTO()
                {
                    KeyId = 1,
                    ResponseCode = ResponseCode.Success,
                    ResponseMessage = ResponseMessages.SupplyNotificationEmailUpdated
                };
            }
        }

        public async Task<ResponseDTO> UpdateClientEmailAddressesAsync(UpdateClientEmailAddressesDTO updateClientEmailAddressesDTO)
        {
            var clientToUpdate = _dbContext.PbClients.Where(x => x.ClientId.ToString() == updateClientEmailAddressesDTO.ClientId).FirstOrDefault();

            if (clientToUpdate == null)
            {
                throw new Exception(ResponseMessages.NoPanelBeaterExists);
            }
            else
            {

                clientToUpdate.NotificationEmailAddress = updateClientEmailAddressesDTO.NotificationEmailAddress == "" ? null : updateClientEmailAddressesDTO.NotificationEmailAddress;
                clientToUpdate.PaymentNotificationEmail = updateClientEmailAddressesDTO.PaymentNotificationEmail == "" ? null : updateClientEmailAddressesDTO.PaymentNotificationEmail;
                clientToUpdate.TmsnotificationEmailAddress = updateClientEmailAddressesDTO.tmsNotificationEmailAddress == "" ? null : updateClientEmailAddressesDTO.tmsNotificationEmailAddress;
                clientToUpdate.Email = updateClientEmailAddressesDTO.Email == "" ? null : updateClientEmailAddressesDTO.Email;
                clientToUpdate.ModifiedBy = updateClientEmailAddressesDTO.ActionPerformedBy;
                clientToUpdate.ModifiedDate = DateTime.Now;

                _dbContext.PbClients.Update(clientToUpdate);
                await _dbContext.SaveChangesAsync();
                return new ResponseDTO()
                {
                    KeyId = 1,
                    ResponseCode = ResponseCode.Success,
                    ResponseMessage = ResponseMessages.ClientEmailsUpdated
                };
            }
        }

        public async Task<IEnumerable<GetPanelBeaterAssignedSuppliersDTO>> GetPanelBeaterAssignedSuppliersAsync(SearchPanelBeaterAssignedSuppliersDTO searchPanelBeaterAssignedSuppliersDTO)
        {
            if (searchPanelBeaterAssignedSuppliersDTO.OrderBy != null)
            {
                searchPanelBeaterAssignedSuppliersDTO.OrderBy = char.ToUpper(searchPanelBeaterAssignedSuppliersDTO.OrderBy[0]) + searchPanelBeaterAssignedSuppliersDTO.OrderBy.Substring(1);
            }

            var pbAssignedSuppliersList = await CollectionsAsync<GetPanelBeaterAssignedSuppliersDTO>(StoreProcedures.GetAssignedSuppliers, new {ClientId = searchPanelBeaterAssignedSuppliersDTO.ClientId});

            SearchByName(ref pbAssignedSuppliersList, searchPanelBeaterAssignedSuppliersDTO.SearchValue);

            if (searchPanelBeaterAssignedSuppliersDTO.OrderByDescending == true)
            {
                if (searchPanelBeaterAssignedSuppliersDTO.OrderBy != null)
                {
                    pbAssignedSuppliersList = pbAssignedSuppliersList.OrderByDescending(x => x.GetType().GetProperty(searchPanelBeaterAssignedSuppliersDTO.OrderBy).GetValue(x));
                }
            }
            else
            {
                if (searchPanelBeaterAssignedSuppliersDTO.OrderBy != null)
                {
                    pbAssignedSuppliersList = pbAssignedSuppliersList.OrderBy(x => x.GetType().GetProperty(searchPanelBeaterAssignedSuppliersDTO.OrderBy).GetValue(x));
                }
            }
            int count = pbAssignedSuppliersList.Count();

            if (searchPanelBeaterAssignedSuppliersDTO.AllRecords)
                pbAssignedSuppliersList = pbAssignedSuppliersList.ToList();
            else
                pbAssignedSuppliersList = pbAssignedSuppliersList.Skip((searchPanelBeaterAssignedSuppliersDTO.PageNo - 1) * searchPanelBeaterAssignedSuppliersDTO.PageSize).Take(searchPanelBeaterAssignedSuppliersDTO.PageSize).ToList();

            return pbAssignedSuppliersList;
        }

        private void SearchByName(ref IEnumerable<GetPanelBeaterAssignedSuppliersDTO> pbAssignedSuppliersList, string SearchValue)
        {
            if (!pbAssignedSuppliersList.Any() || string.IsNullOrWhiteSpace(SearchValue))
                return;
            pbAssignedSuppliersList = pbAssignedSuppliersList.Where(o => o.SupplierName.ToString().ToLower().Contains(SearchValue.Trim().ToLower()));
        }

        public async Task<ResponseDTO> UnassignPanelBeaterSupplierAsync(UnassignPanelBeaterSupplierDTO unassignPanelBeaterSupplierDTO)
        {
            var supplierToUnassign = (from s in _dbContext.PbClientSuppliers
                                      where s.ClientId.ToString() == unassignPanelBeaterSupplierDTO.ClientId && s.SupplierId.ToString() == unassignPanelBeaterSupplierDTO.SupplierId select s).FirstOrDefault();

            if(supplierToUnassign != null)
            {
                _dbContext.PbClientSuppliers.Remove(supplierToUnassign);
                await _dbContext.SaveChangesAsync();

                return new ResponseDTO()
                {
                    KeyId = 1,
                    ResponseCode = ResponseCode.Success,
                    ResponseMessage = ResponseMessages.SupplierUnassigned
                };
            }
            else
            {
                throw new Exception(ResponseMessages.NoAssignedSupplierExists);
            }
        }

        public async Task<ResponseDTO> AssignSupplierToPanelBeaterAsync(AssignSupplierToPanelBeaterDTO assignSupplierToPanelBeaterDTO)
        {
            Guid supplierId = Guid.Parse(assignSupplierToPanelBeaterDTO.SupplierId);
            Guid clientId = Guid.Parse(assignSupplierToPanelBeaterDTO.ClientId);

            var supplierDetails = _dbContext.PbSuppliers.Where(x => x.SupplierId == supplierId).Select(x => new { PaymentTerms = x.PaymentTerms ?? "", x.SupplierName, x.NoCodfee }).FirstOrDefault();

            var newClientSupplier = new PbClientSupplier();
            newClientSupplier.ClientSupplierId = Guid.NewGuid();
            newClientSupplier.SupplierId = supplierId;
            newClientSupplier.ClientId = clientId;
            newClientSupplier.CreatedBy = assignSupplierToPanelBeaterDTO.ActionPerformedBy;
            newClientSupplier.CreatedDate = DateTime.Now;
            newClientSupplier.ModifiedBy = "";
            newClientSupplier.ModifiedDate = DateTime.Now;

            await _dbContext.PbClientSuppliers.AddAsync(newClientSupplier);

            await _dbContext.SaveChangesAsync();

            return new ResponseDTO()
            {
               KeyId = 1,
               ResponseCode = ResponseCode.Success,
               ResponseMessage = ResponseMessages.SupplierAssigned
            };
        }

        public async Task<GetUnassignedSuppliersDataDTO> GetUnassignedSuppliersAsync(SearchUnassignedSuppliersDTO searchUnassignedSuppliersDTO)
        {
            if (searchUnassignedSuppliersDTO.OrderBy != null)
            {
                searchUnassignedSuppliersDTO.OrderBy = char.ToUpper(searchUnassignedSuppliersDTO.OrderBy[0]) + searchUnassignedSuppliersDTO.OrderBy.Substring(1);
            }

            var unassignedSuppliersList = await CollectionsAsync<GetUnassignedSuppliersDTO>(StoreProcedures.GetUnassignedAssignedSuppliers, new { ClientId = searchUnassignedSuppliersDTO.ClientId });

            // Filtering starts here
            if (searchUnassignedSuppliersDTO.SupplierType != null && searchUnassignedSuppliersDTO.SupplierType != "")
            {
                unassignedSuppliersList = unassignedSuppliersList.Where(x => x.SupplierType == searchUnassignedSuppliersDTO.SupplierType).Select(x => x).ToList();
            }
           
            if (searchUnassignedSuppliersDTO.RegionId != null && searchUnassignedSuppliersDTO.RegionId != "")
            {
                Guid? regionId = new Guid(searchUnassignedSuppliersDTO.RegionId);
                unassignedSuppliersList = unassignedSuppliersList.Where(x => x.RegionId == regionId).Select(x => x).ToList();
            }
           
            if (searchUnassignedSuppliersDTO.SupplierGroupId != null && searchUnassignedSuppliersDTO.SupplierGroupId != "")
            {
                Guid? supplierGroupId = new Guid(searchUnassignedSuppliersDTO.SupplierGroupId);
                unassignedSuppliersList = unassignedSuppliersList.Where(x => x.SupplierGroupId == supplierGroupId).Select(x => x).ToList();
            }
          
            if (searchUnassignedSuppliersDTO.SuppliesToCityId != null && searchUnassignedSuppliersDTO.SuppliesToCityId != "")
            {
                Guid? suppliesTo = new Guid(searchUnassignedSuppliersDTO.SuppliesToCityId);
                unassignedSuppliersList = unassignedSuppliersList.Where(x => x.SuppliesTo == suppliesTo).Select(x => x).ToList();
            }


            // Filtering based on brands
            List<Guid> brandIds = new();

            if (searchUnassignedSuppliersDTO.Brands?.Count > 0)
            {
                foreach (var brand in searchUnassignedSuppliersDTO.Brands)
                {
                    brandIds.Add(Guid.Parse(brand.BrandId));
                }

                unassignedSuppliersList = unassignedSuppliersList.Where(x => brandIds.Any(c => c.Equals(x.BrandId))).Select(x => x).ToList();
            }

            unassignedSuppliersList = unassignedSuppliersList.OrderBy(x => x.SupplierName);

            unassignedSuppliersList = unassignedSuppliersList.GroupBy(x => x.SupplierName).Select(x => x.First());


            // Searching, Sorting 

            SearchByName(ref unassignedSuppliersList, searchUnassignedSuppliersDTO.SupplierName);


            if (searchUnassignedSuppliersDTO.OrderByDescending == true)
            {
                if (searchUnassignedSuppliersDTO.OrderBy != null)
                {
                    unassignedSuppliersList = unassignedSuppliersList.OrderByDescending(x => x.GetType().GetProperty(searchUnassignedSuppliersDTO.OrderBy).GetValue(x));
                }
            }
            else
            {
                if (searchUnassignedSuppliersDTO.OrderBy != null)
                {
                    unassignedSuppliersList = unassignedSuppliersList.OrderBy(x => x.GetType().GetProperty(searchUnassignedSuppliersDTO.OrderBy).GetValue(x));
                }
            }
            int count = unassignedSuppliersList.Count();

            if (searchUnassignedSuppliersDTO.AllRecords)
                unassignedSuppliersList = unassignedSuppliersList.ToList();

            // here we are getting brand

           

            var response = new GetUnassignedSuppliersDataDTO()
            {
                SupplierNoAdditionalCharges = unassignedSuppliersList.Where(x => x.TotalRebate > 0 || (x.NoCODFee ?? false) == true).ToList(),
                SupplierAdditionalCharges = unassignedSuppliersList.Where(x => x.TotalRebate == 0 && (x.NoCODFee ?? false) == false).ToList()
            };
            return response;
        }

        private void SearchByName(ref IEnumerable<GetUnassignedSuppliersDTO> unassignedSuppliersList, string SearchValue)
        {
            if (!unassignedSuppliersList.Any() || string.IsNullOrWhiteSpace(SearchValue))
                return;
            unassignedSuppliersList = unassignedSuppliersList.Where(o => o.SupplierName.ToString().ToLower().Contains(SearchValue.Trim().ToLower()));
        }
    }
}