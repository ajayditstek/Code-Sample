using System.Collections.Generic;
using AutoMapper;
using Demo.Core.DTOs.Response;
using Demo.Core.Interfaces;
using Demo.Core.Model;
using System.Linq;
using System.Threading.Tasks;
using Demo.Core.DTOs.Request;
using Demo.Repository.Enums;
using System;
using Demo.Repository.Common.StoreProcedures;
using Demo.Repository.Common.Helper;
using System.IO;
using Demo.Repository.GenricRepo;
using System.Security.Claims;

namespace Demo.Repository.Repository
{
    public class ClaimsRepository : GenericRepository<PbClaim>, IClaimsRepository
    {
        private readonly UATDemoPortalContext _dbContext;
        public ClaimsRepository(UATDemoPortalContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<AddClaimResponseDTO> AddClaimAsync(AddClaimDTO addClaimDTO)
        {

            bool GET_NEW_Demo_NUMBER = false;
            string Demo_NUMBER = string.Empty;
            var CLAIM_ID = Guid.NewGuid();
            Guid ClaimId = Guid.Empty;
            // checking whether insurance claim number already exits

            var data = await CollectionsAsync<dynamic>(StoreProcedures.CheckDuplicayForVehicleRegAndInsurerClaimNo, new { InsurerClaimNumber = addClaimDTO.InsurerClaimNumber, VehicleRegistrationNumber = addClaimDTO.VehicleRegistrationNumber });

            if (data.Count<dynamic>() > 0)
            {
                throw new Exception(ResponseMessages.InsurerClaimNumberAlreadyInUse);
            }

            // checking job no already exist

            var claim = _dbContext.PbClaims.Where(x => x.ClientId.ToString() == addClaimDTO.ClientId && x.Ronumber == addClaimDTO.JobCardNo).Select(x => x).FirstOrDefault();

            if (claim != null)
            {
                throw new Exception(ResponseMessages.JobCardNoAlreadyExists);
            }

            var nextSeq = await CommandAsync<NextSequenceNumber>(StoreProcedures.GetNextSequenceNumber, new { SeqName = "DemoSeqNo" });

            var pbClaimToAdd = new PbClaim();

            pbClaimToAdd.ClaimId = ClaimId = CLAIM_ID;
            pbClaimToAdd.ClientId = Guid.Parse(addClaimDTO.ClientId);
            pbClaimToAdd.InsurerId = Guid.Parse(addClaimDTO.InsurerId);
            pbClaimToAdd.DemoSeqNo = nextSeq.retVal;
            pbClaimToAdd.InsurerClaimNumber = addClaimDTO.InsurerClaimNumber.ToUpper();
            pbClaimToAdd.VehicleRegistrationNumber = addClaimDTO.VehicleRegistrationNumber.ToUpper();
            pbClaimToAdd.VehicleMake = addClaimDTO.VehicleMake;
            pbClaimToAdd.VehicleModel = addClaimDTO.VehicleModel;
            pbClaimToAdd.InsuredName = addClaimDTO.InsuredName.ToUpper();
            pbClaimToAdd.InsuredPhoneNumber = addClaimDTO.InsuredPhoneNumber;
            pbClaimToAdd.ClaimAmount = addClaimDTO.ClaimAmount;
            pbClaimToAdd.ClaimStatus = "Accepted";
            pbClaimToAdd.Ronumber = addClaimDTO.JobCardNo;
            pbClaimToAdd.ClaimExcess = addClaimDTO.ClaimExcess;
            pbClaimToAdd.ClaimPartsValue = addClaimDTO.ClaimPartsValue;
            pbClaimToAdd.InvoiceType = addClaimDTO.InvoiceType;
            pbClaimToAdd.InitialClaimAmount = addClaimDTO.ClaimAmount;
            pbClaimToAdd.CreatedBy = addClaimDTO.ActionPerformedBy;
            pbClaimToAdd.CreatedDate = DateTime.Now;
            pbClaimToAdd.ModifiedBy = addClaimDTO.ActionPerformedBy;
            pbClaimToAdd.ModifiedDate = DateTime.Now;

            var config = _dbContext.AdministrationConfigs.Where(c => c.Category == "CLAIMS" && c.Item == "GET_NEW_Demo_NUMBER").FirstOrDefault();

            if (config != null)
            {
                GET_NEW_Demo_NUMBER = Convert.ToBoolean(config.Value);
            }

            if (GET_NEW_Demo_NUMBER)
            {
                var clientNumber = 0;
                clientNumber = Convert.ToInt32(_dbContext.PbClients.Where(x => x.ClientId.ToString() == addClaimDTO.ClientId).Select(x => x.ExternalId).FirstOrDefault());

                Demo_NUMBER = clientNumber.ToString() + "/" + nextSeq.retVal.ToString();
            }

            pbClaimToAdd.DemoNumber = Demo_NUMBER;

            await _dbContext.PbClaims.AddAsync(pbClaimToAdd);

            if (addClaimDTO.ClaimSuppliers.Count > 0)
            {
                foreach (var supplier in addClaimDTO.ClaimSuppliers)
                {
                    var claimSupplierToAdd = new PbClaimSupplier();

                    claimSupplierToAdd.ClaimSupplierId = Guid.NewGuid();
                    claimSupplierToAdd.ClaimId = CLAIM_ID;
                    claimSupplierToAdd.SupplierId = Guid.Parse(supplier.SupplierId);
                    claimSupplierToAdd.CreatedBy = addClaimDTO.ActionPerformedBy;
                    claimSupplierToAdd.CreatedDate = DateTime.Now;
                    claimSupplierToAdd.ModifiedBy = addClaimDTO.ActionPerformedBy;
                    claimSupplierToAdd.ModifiedDate = DateTime.Now;

                    await _dbContext.PbClaimSuppliers.AddAsync(claimSupplierToAdd);
                }
            }

            var dummyClaimEmailToAdd = new PbClaimEmail();

            dummyClaimEmailToAdd.ClaimEmailId = Guid.NewGuid();
            dummyClaimEmailToAdd.ClaimId = CLAIM_ID;
            dummyClaimEmailToAdd.CreatedBy = "Dummy from System";
            dummyClaimEmailToAdd.CreatedDate = DateTime.Now;

            await _dbContext.PbClaimEmails.AddAsync(dummyClaimEmailToAdd);



            var claimLogToAdd = new PbClaimLog();

            claimLogToAdd.ClaimLogId = Guid.NewGuid();
            claimLogToAdd.ClaimId = CLAIM_ID;
            claimLogToAdd.Category = "Claims";
            claimLogToAdd.Description = "Created new claim";
            claimLogToAdd.CreatedBy = addClaimDTO.ActionPerformedBy;
            claimLogToAdd.CreatedDate = DateTime.Now;

            await _dbContext.PbClaimLogs.AddAsync(claimLogToAdd);


            await _dbContext.SaveChangesAsync();
            return new AddClaimResponseDTO()
            {
                KeyId = 1,
                ResponseCode = ResponseCode.Success,
                ResponseMessage = ResponseMessages.ClaimAdded + " Demo Number : " + Demo_NUMBER,
                DemoNumber = Demo_NUMBER,
                ClaimId = ClaimId
            };
        }

        public async Task<AddClaimRequestResponseDTO> AddClaimRequestAsync(AddClaimRequestDTO addClaimRequestDTO)
        {
            Guid claimId = Guid.Empty;
            if (addClaimRequestDTO.ClaimId != null && addClaimRequestDTO.ClaimId != "")
            {
                claimId = Guid.Parse(addClaimRequestDTO.ClaimId);
            }
            else
            {
                claimId = Guid.NewGuid();
            }


            // here we adding assessor details

            //var dataCompany = (from s in _dbContext.PbAssessorCompanies
            //                    where s.CompanyName == addClaimRequestDTO.AssessorCompany
            //                    select s).FirstOrDefault();

            //if (dataCompany != null)
            //{
            //    if (addClaimRequestDTO.Assessor != "")
            //    {
            //        var dataAssessor = (from s in _dbContext.PbAssessorDetails
            //                            where s.AssessorCompanyId == dataCompany.AssessorCompanyId
            //                            && s.AssessorName == addClaimRequestDTO.Assessor
            //                            select s).FirstOrDefault();
            //        //if the person exists then update the contact details
            //        if (dataAssessor != null)
            //        {
            //            if (addClaimRequestDTO.AssessorContactDetails != null && addClaimRequestDTO.AssessorContactDetails != "")
            //            {
            //                dataAssessor.ContactDetails = addClaimRequestDTO.AssessorContactDetails;

            //                _dbContext.PbAssessorDetails.Update(dataAssessor);
            //                await _dbContext.SaveChangesAsync();
            //            }  
            //        }
            //        else //the person doesnt exist and therefore has to be created
            //        {

            //            var assesorDetailsToAdd = new PbAssessorDetail()
            //            {
            //                AssessorDetailId = Guid.NewGuid(),
            //                AssessorCompanyId = dataCompany.AssessorCompanyId,  
            //                AssessorName = addClaimRequestDTO.Assessor,
            //                CreatedBy = addClaimRequestDTO.ActionPerformedBy,
            //                CreatedDate = DateTime.Now
            //            };

            //            if(addClaimRequestDTO.AssessorContactDetails != null && addClaimRequestDTO.AssessorContactDetails != "")
            //            {
            //                assesorDetailsToAdd.ContactDetails = addClaimRequestDTO.AssessorContactDetails;
            //            }

            //            await _dbContext.PbAssessorDetails.AddAsync(assesorDetailsToAdd);
            //            await _dbContext.SaveChangesAsync();
            //        }
            //    }
            //}
            //else //if the company doesnt exist it needs to be created
            //{
            //    var assessorCompanyToAdd = new PbAssessorCompany()
            //    {
            //        AssessorCompanyId = Guid.NewGuid(),
            //        CompanyName = addClaimRequestDTO.AssessorCompany,
            //        CreatedBy =  addClaimRequestDTO.ActionPerformedBy,
            //        CreatedDate = DateTime.Now
            //    };

            //    await _dbContext.PbAssessorCompanies.AddAsync(assessorCompanyToAdd);

            //    var assessorDetailsToAdd = new PbAssessorDetail()
            //    {
            //        AssessorDetailId = Guid.NewGuid(),
            //        AssessorCompanyId = assessorCompanyToAdd.AssessorCompanyId,
            //        AssessorName = addClaimRequestDTO.Assessor,
            //        CreatedBy = addClaimRequestDTO.ActionPerformedBy,
            //        CreatedDate = DateTime.Now,
            //    };

            //    if(addClaimRequestDTO.AssessorContactDetails != null && addClaimRequestDTO.AssessorContactDetails != "")
            //    {
            //        assessorDetailsToAdd.ContactDetails = addClaimRequestDTO.AssessorContactDetails;
            //    }

            //    await _dbContext.PbAssessorDetails.AddAsync(assessorDetailsToAdd);

            //    await _dbContext.SaveChangesAsync();
            //}

            // here we are checking registration Number and Insurer number already exists or not

            //if (!addClaimRequestDTO.ClaimIsNotADuplicate)
            //{
            //    var data = await CollectionsAsync<GetVehicleRegistrationCheckResponseDTO>(StoreProcedures.CheckDuplicayForVehicleRegAndInsurerClaimNo, new { InsurerClaimNumber = addClaimRequestDTO.InsurerClaimNumber, VehicleRegistrationNumber = addClaimRequestDTO.VehicleRegistrationNumber });

            //    if(data.Any())
            //    {
            //        if (data.Max(x => x.IsDuplicateVehicleRegistrationNumber) > 0)
            //        {
            //            throw new Exception(ResponseMessages.VehicleRegistrationAlreadyInUse);
            //        }
            //    }
            //}


            //var InsurerClaimNo = _dbContext.PbInsurers.Where(i => i.InsurerId.ToString() == addClaimRequestDTO.InsurerId).Select(x => new { x.ClaimNoPrefixText, x.ClaimNoSufixText }).FirstOrDefault();
            //if (!String.IsNullOrEmpty(InsurerClaimNo.ClaimNoPrefixText))
            //{
            //    if (addClaimRequestDTO.InsurerClaimNumber.Contains(InsurerClaimNo.ClaimNoPrefixText))
            //    {
            //        throw new Exception(ResponseMessages.ClaimNumberPrefixIncorrect + InsurerClaimNo.ClaimNoPrefixText);
            //    }
            //}
            //if (!String.IsNullOrEmpty(InsurerClaimNo.ClaimNoSufixText))
            //{
            //    if (addClaimRequestDTO.InsurerClaimNumber.Contains(InsurerClaimNo.ClaimNoSufixText))
            //    {
            //        throw new Exception(ResponseMessages.ClaimNumberSuffixIncorrect + InsurerClaimNo.ClaimNoSufixText);
            //    }
            //}

            var cliamRequestToAdd = new PbClaimRequest
            {
                ClaimRequestId = Guid.NewGuid(),
                ClaimId = claimId,
                ClientId = Guid.Parse(addClaimRequestDTO.ClientId),
                InsurerId = Guid.Parse(addClaimRequestDTO.InsurerId),
                InsurerClaimNumber = addClaimRequestDTO.InsurerClaimNumber,
                VehicleRegistrationNumber = addClaimRequestDTO.VehicleRegistrationNumber,
                VehicleMake = addClaimRequestDTO.VehicleMake,
                VehicleModel = addClaimRequestDTO.VehicleModel,
                InsuredName = addClaimRequestDTO.InsuredName,
                InsuredPhoneNumber = addClaimRequestDTO.InsuredPhoneNumber,
                Labour = addClaimRequestDTO.Labour,
                Paint = addClaimRequestDTO.Paint,
                Year = addClaimRequestDTO.Year,
                TotalPartsValue = addClaimRequestDTO.TotalPartsValue,
                NetClaimAmount = addClaimRequestDTO.NetClaimAmount,
                VINNumber = addClaimRequestDTO.VINNumber,
                ClaimPartsValue = addClaimRequestDTO.ClaimPartsValue,
                ClaimAmount = addClaimRequestDTO.ClaimAmount,
                ClaimExcess = addClaimRequestDTO.ClaimExcess,
                Ronumber = addClaimRequestDTO.JobCardNo,
                EstimatedDaysToCompleted = addClaimRequestDTO.EstimatedDaysToComplete,
                CreatedBy = addClaimRequestDTO.ActionPerformedBy,
                CreatedDate = DateTime.Now,
            };

            //if (addClaimRequestDTO.NoParts)
            //{
            //    cliamRequestToAdd.InvoiceType = "No Parts";
            //}
            //else
            //{
            //    cliamRequestToAdd.InvoiceType = "Parts Only";
            //}

            //string InsurerType = (from s in _dbContext.Lookups
            //                      join x in _dbContext.PbInsurers on s.LookupId equals x.InsurerTypeId
            //                      where x.InsurerId.ToString() == addClaimRequestDTO.InsurerId
            //                      select s.Description).FirstOrDefault();
            //if (InsurerType == "Self Insured" || InsurerType == "Commercial Insurer")
            //{
            //    cliamRequestToAdd.InsurerIdsecondary = Guid.Parse(addClaimRequestDTO.InsurerId);
            //}
            //else
            //{
            //    if (cliamRequestToAdd.InsurerId != Guid.Parse(addClaimRequestDTO.InsurerId))
            //    {
            //        cliamRequestToAdd.InsurerId = Guid.Parse(addClaimRequestDTO.InsurerId);
            //    }
            //}

            await _dbContext.PbClaimRequests.AddAsync(cliamRequestToAdd);

            var claimLog = new PbClaimLog
            {
                ClaimLogId = Guid.NewGuid(),
                ClaimId = claimId,
                Category = "Claims",
                Description = "Panel beater Claim Request created by " + addClaimRequestDTO.ActionPerformedBy,
                CreatedBy = addClaimRequestDTO.ActionPerformedBy,
                CreatedDate = DateTime.Now
            };

            await _dbContext.PbClaimLogs.AddAsync(claimLog);


            if (addClaimRequestDTO.ClaimId != null && addClaimRequestDTO.ClaimId != "")
            {
                foreach (var partSupplier in addClaimRequestDTO.SupplierPartDetails)
                {
                    var supplierId = Guid.Parse(partSupplier.SupplierId);
                    if (partSupplier.ClaimPartSupplierId != null && partSupplier.ClaimPartSupplierId != "" && partSupplier.IsPartSupplierDeleted == true)
                    {
                        var claimPartSupplierToDelete = _dbContext.PbClaimPartSuppliers.Where(x => x.ClaimPartSupplierId.ToString() == partSupplier.ClaimPartSupplierId && x.IsDeleted == false).FirstOrDefault();

                        claimPartSupplierToDelete.IsDeleted = true;
                        claimPartSupplierToDelete.DeletedBy = addClaimRequestDTO.ActionPerformedBy;
                        claimPartSupplierToDelete.DeletedDate = DateTime.Now;

                        _dbContext.PbClaimPartSuppliers.Update(claimPartSupplierToDelete);

                    }

                    else if (partSupplier.ClaimPartSupplierId != null && partSupplier.ClaimPartSupplierId != "" && partSupplier.IsPartSupplierDeleted == false)
                    {
                        var claimPartSupplierToUpdate = _dbContext.PbClaimPartSuppliers.Where(x => x.ClaimPartSupplierId.ToString() == partSupplier.ClaimPartSupplierId && x.IsDeleted == false).FirstOrDefault();
                        if (claimPartSupplierToUpdate != null)
                        {
                            claimPartSupplierToUpdate.SupplierTotal = partSupplier.SupplierTotal;
                            claimPartSupplierToUpdate.ModifiedBy = addClaimRequestDTO.ActionPerformedBy;
                            claimPartSupplierToUpdate.ModifiedDate = DateTime.Now;

                            _dbContext.PbClaimPartSuppliers.Update(claimPartSupplierToUpdate);

                            foreach (var part in partSupplier.PartDetails)
                            {
                                if (part.ClaimSupplierPartId == null)
                                {
                                    var partInDb = _dbContext.PbSupplierParts.Where(x => x.SupplierId == supplierId && x.PartName == part.PartName && x.IsDeleted == false).FirstOrDefault();

                                    if (partInDb == null)
                                    {
                                        var partToAdd = new PbSupplierPart()
                                        {
                                            SupplierPartId = Guid.NewGuid(),
                                            SupplierId = supplierId,
                                            PartName = part.PartName,
                                            Price = part.Price,
                                            PartId = Guid.NewGuid(),
                                            CreatedBy = addClaimRequestDTO.ActionPerformedBy,
                                            CreatedDate = DateTime.Now
                                        };

                                        await _dbContext.PbSupplierParts.AddAsync(partToAdd);
                                    }

                                    var supplierPartToAdd = new PbClaimSupplierPart()
                                    {
                                        ClaimSupplierPartId = Guid.NewGuid(),
                                        ClaimPartSupplierId = claimPartSupplierToUpdate.ClaimPartSupplierId,
                                        PartName = part.PartName,
                                        Price = part.Price,
                                        CreatedBy = addClaimRequestDTO.ActionPerformedBy,
                                        CreatedDate = DateTime.Now

                                    };

                                    await _dbContext.PbClaimSupplierParts.AddAsync(supplierPartToAdd);
                                }
                                else if (part.ClaimSupplierPartId != null && part.IsDeleted == false)
                                {
                                    var supplierPartToUpdate = _dbContext.PbClaimSupplierParts.Where(x => x.ClaimSupplierPartId.ToString() == part.ClaimSupplierPartId && x.IsDeleted == false).FirstOrDefault();
                                    if (supplierPartToUpdate != null)
                                    {
                                        supplierPartToUpdate.PartName = part.PartName;
                                        supplierPartToUpdate.Price = part.Price;
                                        supplierPartToUpdate.ModifiedBy = addClaimRequestDTO.ActionPerformedBy;
                                        supplierPartToUpdate.ModifiedDate = DateTime.Now;

                                        _dbContext.PbClaimSupplierParts.Update(supplierPartToUpdate);

                                    }
                                }
                                else if (part.ClaimSupplierPartId != null && part.IsDeleted == true)
                                {
                                    var supplierPartToDelete = _dbContext.PbClaimSupplierParts.Where(x => x.ClaimSupplierPartId.ToString() == part.ClaimSupplierPartId && x.IsDeleted == false).FirstOrDefault();
                                    if (supplierPartToDelete != null)
                                    {
                                        supplierPartToDelete.IsDeleted = true;
                                        supplierPartToDelete.DeletedBy = addClaimRequestDTO.ActionPerformedBy;
                                        supplierPartToDelete.DeletedDate = DateTime.Now;

                                        _dbContext.PbClaimSupplierParts.Update(supplierPartToDelete);

                                    }
                                }

                            }
                        }
                    }
                    else
                    {
                        var claimPartSupplierId = Guid.NewGuid();

                        var partSupplierToAdd = new PbClaimPartSupplier()
                        {
                            ClaimPartSupplierId = claimPartSupplierId,
                            ClaimId = claimId,
                            SupplierId = supplierId,
                            SupplierTotal = partSupplier.SupplierTotal,
                            CreatedBy = addClaimRequestDTO.ActionPerformedBy,
                            CreatedDate = DateTime.Now
                        };

                        await _dbContext.PbClaimPartSuppliers.AddAsync(partSupplierToAdd);

                        foreach (var part in partSupplier.PartDetails)
                        {
                            var partInDb = _dbContext.PbSupplierParts.Where(x => x.SupplierId == supplierId && x.PartName == part.PartName && x.IsDeleted == false).FirstOrDefault();

                            if (partInDb == null)
                            {
                                var partToAdd = new PbSupplierPart()
                                {
                                    SupplierPartId = Guid.NewGuid(),
                                    SupplierId = supplierId,
                                    PartName = part.PartName,
                                    Price = part.Price,
                                    PartId = Guid.NewGuid(),
                                    CreatedBy = addClaimRequestDTO.ActionPerformedBy,
                                    CreatedDate = DateTime.Now
                                };

                                await _dbContext.PbSupplierParts.AddAsync(partToAdd);
                            }

                            var supplierPartToAdd = new PbClaimSupplierPart()
                            {
                                ClaimSupplierPartId = Guid.NewGuid(),
                                ClaimPartSupplierId = claimPartSupplierId,
                                PartName = part.PartName,
                                Price = part.Price,
                                CreatedBy = addClaimRequestDTO.ActionPerformedBy,
                                CreatedDate = DateTime.Now

                            };

                            await _dbContext.PbClaimSupplierParts.AddAsync(supplierPartToAdd);
                        }




                    }
                }
            }
            else
            {
                foreach (var partSupplier in addClaimRequestDTO.SupplierPartDetails)
                {
                    var supplierId = Guid.Parse(partSupplier.SupplierId);
                    var claimPartSupplierId = Guid.NewGuid();
                    var partSupplierToAdd = new PbClaimPartSupplier()
                    {
                        ClaimPartSupplierId = claimPartSupplierId,
                        ClaimId = claimId,
                        SupplierId = supplierId,
                        SupplierTotal = partSupplier.SupplierTotal,
                        CreatedBy = addClaimRequestDTO.ActionPerformedBy,
                        CreatedDate = DateTime.Now
                    };

                    await _dbContext.PbClaimPartSuppliers.AddAsync(partSupplierToAdd);

                    foreach (var part in partSupplier.PartDetails)
                    {
                        var partInDb = _dbContext.PbSupplierParts.Where(x => x.SupplierId == supplierId && x.PartName == part.PartName && x.IsDeleted == false).FirstOrDefault();
                        if (partInDb == null)
                        {
                            var partToAdd = new PbSupplierPart()
                            {
                                SupplierPartId = Guid.NewGuid(),
                                SupplierId = supplierId,
                                PartName = part.PartName,
                                Price = part.Price,
                                PartId = Guid.NewGuid(),
                                CreatedBy = addClaimRequestDTO.ActionPerformedBy,
                                CreatedDate = DateTime.Now
                            };

                            await _dbContext.PbSupplierParts.AddAsync(partToAdd);
                        }

                        var supplierPartToAdd = new PbClaimSupplierPart()
                        {
                            ClaimSupplierPartId = Guid.NewGuid(),
                            ClaimPartSupplierId = claimPartSupplierId,
                            PartName = part.PartName,
                            Price = part.Price,
                            CreatedBy = addClaimRequestDTO.ActionPerformedBy,
                            CreatedDate = DateTime.Now

                        };

                        await _dbContext.PbClaimSupplierParts.AddAsync(supplierPartToAdd);

                    }
                }
            }










            //if (addClaimRequestDTO.ClaimRequestSuppliers.Count > 0)
            //{
            //    foreach (var supplier in addClaimRequestDTO.ClaimRequestSuppliers)
            //    {
            //        var supplierToAdd = new PbClaimRequestSupplier();
            //        supplierToAdd.ClaimRequestSupplierId = Guid.NewGuid();
            //        supplierToAdd.ClaimRequestId = cliamRequestToAdd.ClaimRequestId;
            //        supplierToAdd.SupplierId = Guid.Parse(supplier.SupplierId);
            //        supplierToAdd.CreatedBy = addClaimRequestDTO.ActionPerformedBy;
            //        supplierToAdd.CreatedDate = DateTime.Now;

            //        await _dbContext.PbClaimRequestSuppliers.AddAsync(supplierToAdd);
            //    }
            //}

            var claimDraftToUpdate = _dbContext.PbClaimDrafts.Where(x => x.ClaimDraftId.ToString() == addClaimRequestDTO.ClaimDraftId).FirstOrDefault();

            if(claimDraftToUpdate != null)
            {
                claimDraftToUpdate.SubmittedBy = addClaimRequestDTO.ActionPerformedBy;
                claimDraftToUpdate.SubmittedDate = DateTime.Now;

                _dbContext.PbClaimDrafts.Update(claimDraftToUpdate);
            }
           

            if (_dbContext.PbClaims.Where(x => x.InsurerId.ToString() == addClaimRequestDTO.InsurerId && x.InsurerClaimNumber == addClaimRequestDTO.InsurerClaimNumber).Any())
            {
                throw new Exception(ResponseMessages.InsurerClaimNumberAlreadyInUse);
            }

            try
            {
                await _dbContext.SaveChangesAsync();
            }
            catch(Exception ex)
            {
                throw ex;
            }
            

            return new AddClaimRequestResponseDTO()
            {
                KeyId = 1,
                ResponseCode = ResponseCode.Success,
                ResponseMessage = ResponseMessages.ClaimRequested,
                ClaimId = claimId.ToString()
            };

        }

        public async Task<ResponseDTO> AddClaimDocumentAsync(AddClaimDocumentDTO addClaimDocumentDTO)
        {
            bool boolCheck = false;
            Guid claimDocumentId = Guid.Empty;
            var uploadDocumentImage = new UploadImages();
            byte[] documentBytes = null;
            var filePath = uploadDocumentImage.UploadImage("ClaimDocuments", addClaimDocumentDTO.DocumentName, addClaimDocumentDTO.Document);
            var fileSize = uploadDocumentImage.FormatSize(addClaimDocumentDTO.Document.Length);

            //var checkDocuments = (from cd in _dbContext.PbClaimDocuments
            //                      where cd.ClaimId.ToString() == addClaimDocumentDTO.ClaimId
            //                      select cd).ToList();



            if (filePath != null)
            {
                using (var ms = new MemoryStream())
                {
                    addClaimDocumentDTO.Document.CopyTo(ms);
                    documentBytes = ms.ToArray();
                }
            }

            //foreach (var doc in checkDocuments)
            //{
            //    if (doc.DocumentName == addClaimDocumentDTO.DocumentName)
            //    {
            //        boolCheck = true;
            //        claimDocumentId = doc.ClaimDocumentId;
            //        break;
            //    }
            //}

            //if (!boolCheck)
            //{
                var claimDocument = new PbClaimDocument
                {
                    ClaimDocumentId = Guid.NewGuid(),
                    ClaimId = Guid.Parse(addClaimDocumentDTO.ClaimId),
                    DocumentName = addClaimDocumentDTO.DocumentName,
                    DocumentType = addClaimDocumentDTO.DocumentType,
                    DocumentData = documentBytes,
                    Description = addClaimDocumentDTO.Description,
                    DocumentUrl = filePath,
                    DocumentSize = fileSize,
                    CreatedBy = addClaimDocumentDTO.ActionPerformedBy,
                    CreatedDate = DateTime.Now
                };

                await _dbContext.PbClaimDocuments.AddAsync(claimDocument);
            //}
            //else
            //{
            //    var claimDocumentToUpdate = (from cd in _dbContext.PbClaimDocuments
            //                                 where cd.ClaimDocumentId == claimDocumentId
            //                                 select cd
            //                                ).FirstOrDefault();

            //    claimDocumentToUpdate.DocumentName = addClaimDocumentDTO.DocumentName;
            //    claimDocumentToUpdate.DocumentData = documentBytes;
            //    claimDocumentToUpdate.DocumentType = addClaimDocumentDTO.DocumentType;
            //    claimDocumentToUpdate.ModifiedBy = addClaimDocumentDTO.ActionPerformedBy;
            //    claimDocumentToUpdate.ModifiedDate = DateTime.Now;
            //    claimDocumentToUpdate.Description = addClaimDocumentDTO.Description;

            //    _dbContext.PbClaimDocuments.Update(claimDocumentToUpdate);
            //}

            var claimLog = new PbClaimLog
            {
                ClaimLogId = Guid.NewGuid(),
                ClaimId = Guid.Parse(addClaimDocumentDTO.ClaimId),
                Category = "Claims",
                Description = "Document Uploaded",
                CreatedBy = addClaimDocumentDTO.ActionPerformedBy,
                CreatedDate = DateTime.Now
            };

            await _dbContext.PbClaimLogs.AddAsync(claimLog);


            await _dbContext.SaveChangesAsync();

            return new ResponseDTO()
            {
                KeyId = -1,
                ResponseCode = ResponseCode.Success,
                ResponseMessage = ResponseMessages.ClaimDocumentAdded
            };
        }

        public async Task<ResponseDTO> AddClaimNoteAsync(AddClaimNotesDTO addClaimNotesDTO)
        {
            if (addClaimNotesDTO.Note != null && addClaimNotesDTO.Note != "")
            {
                var claimNoteToAdd = new PbClaimLog();
                claimNoteToAdd.ClaimLogId = Guid.NewGuid();
                claimNoteToAdd.ClaimId = Guid.Parse(addClaimNotesDTO.ClaimId);
                claimNoteToAdd.Category = "Note";
                claimNoteToAdd.Description = addClaimNotesDTO.Note;
                claimNoteToAdd.CreatedBy = addClaimNotesDTO.ActionPerformedBy;
                claimNoteToAdd.CreatedDate = DateTime.Now;

                await _dbContext.PbClaimLogs.AddAsync(claimNoteToAdd);
                await _dbContext.SaveChangesAsync();

                return new ResponseDTO()
                {
                    KeyId = 1,
                    ResponseCode = ResponseCode.Success,
                    ResponseMessage = ResponseMessages.ClaimNotedAdded
                };
            }
            else
            {
                throw new Exception(ResponseMessages.AddClaimNoteFirst);
            }
        }

        public GetClaimDetailsDTO GetClaimDetails(SearchClaimDetailsDTO searchClaimDetailsDTO)
        {
            var claimDetails = (from c in _dbContext.PbClaims
                                join i in _dbContext.PbInsurers
                                on c.InsurerId equals i.InsurerId
                                join pbc in _dbContext.PbClients
                                on c.ClientId equals pbc.ClientId
                                where c.ClaimId.ToString() == searchClaimDetailsDTO.ClaimId
                                select new GetClaimDetailsDTO()
                                {
                                    ClaimId = c.ClaimId,
                                    ClientId = pbc.ClientId,
                                    InsurerId = c.InsurerId,
                                    ClientName = pbc.ClientName,
                                    ClientTradingName = pbc.ClientTradingName,
                                    PrimaryInsurer = i.InsurerName,
                                    InsurerClaimNumber = c.InsurerClaimNumber,
                                    vehicleRegistrationNumber = c.VehicleRegistrationNumber,
                                    VehicleMake = c.VehicleMake,
                                    VehicleModel = c.VehicleModel,
                                    DemoNumber = c.DemoNumber,
                                    InsuredName = c.InsuredName,
                                    InsuredPhoneNumber = c.InsuredPhoneNumber,
                                    ClaimAmount = c.ClaimAmount,
                                    NetClaimAmount = c.NetClaimAmount,
                                    JobCardNo = c.Ronumber,
                                    ClaimExcess = c.ClaimExcess,
                                    ClaimPartsValue = c.ClaimPartsValue,
                                    InvoiceType = c.InvoiceType,
                                    CreatedDate = c.CreatedDate,
                                    EstimatedDaysToComplete = c.EstimatedDaysToComplete,
                                    ClientSuppliers = (from cs in _dbContext.PbClaimSuppliers
                                                       where cs.ClaimId == c.ClaimId
                                                       select new SuppliersInClaim()
                                                       {
                                                           SupplierId = cs.SupplierId
                                                       }).ToList()

                                }).FirstOrDefault();
            return claimDetails;
        }

        public IEnumerable<GetClaimDocumentsDTO> GetClaimDocuments(SearchClaimdocumentsDTO searchClaimdocumentsDTO)
        {
            var claimDocuments = _dbContext.PbClaimDocuments.Where(x => x.ClaimId.ToString() == searchClaimdocumentsDTO.ClaimId).ToList();

            var claimDocumentList = new List<GetClaimDocumentsDTO>();
            foreach (var document in claimDocuments)
            {
                if (document.DocumentType == "Document Pdf")
                {
                    claimDocumentList.Add(new GetClaimDocumentsDTO()
                    {
                        ClaimDocumentId = document.ClaimDocumentId,
                        DocumentName = document.DocumentName,
                        DocumentType = document.DocumentType,
                        Document = "data:application/pdf;base64," + Convert.ToBase64String(document.DocumentData),
                        Description = document.Description,
                        DocumentSize = document.DocumentSize,
                        DocumentUrl = document.DocumentUrl
                    });
                }
                else if (document.DocumentType == "Document Image")
                {
                    claimDocumentList.Add(new GetClaimDocumentsDTO()
                    {
                        ClaimDocumentId = document.ClaimDocumentId,
                        DocumentName = document.DocumentName,
                        DocumentType = document.DocumentType,
                        Document = "data:image/png;base64," + Convert.ToBase64String(document.DocumentData),
                        Description = document.Description,
                        DocumentSize = document.DocumentSize,
                        DocumentUrl = document.DocumentUrl
                    });
                }
            }

            return claimDocumentList;
        }

        public IEnumerable<GetClaimsDTO> GetClaimsList(SearchClaimsDTO searchClaimsDTO)
        {
            if (searchClaimsDTO.OrderBy != null)
            {
                searchClaimsDTO.OrderBy = char.ToUpper(searchClaimsDTO.OrderBy[0]) + searchClaimsDTO.OrderBy.Substring(1);
            }

            IEnumerable<GetClaimsDTO> claimsList = (from c in _dbContext.PbClaims
                                                    join cl in _dbContext.PbClients
                                                    on c.ClientId equals cl.ClientId
                                                    where c.ClaimStatus != "Parts Summary Requested"
                                                    orderby c.ModifiedDate descending
                                                    select new GetClaimsDTO()
                                                    {
                                                        ClaimId = c.ClaimId,
                                                        ClientId = c.ClientId,
                                                        InsurerId = c.InsurerId,
                                                        DemoNumber = c.DemoNumber,
                                                        ClientName = cl.ClientName,
                                                        InsurerClaimNumber = c.InsurerClaimNumber,
                                                        InvoiceType = c.InvoiceType,
                                                        InsuredName = c.InsuredName,
                                                        Make = c.VehicleMake,
                                                        JobCardNo = c.Ronumber,
                                                        VehicleRegistrationNumber = c.VehicleRegistrationNumber,
                                                        ClaimAmount = c.ClaimAmount,
                                                        InvoiceToInsurer = c.InvoiceToInsurer,
                                                        ConfirmedWithInsurer = c.ConfirmedWithInsurer,
                                                        ClaimStatus = c.ClaimStatus,
                                                        CreatedBy = c.CreatedBy,
                                                        CreatedDate = c.CreatedDate,

                                                    }).ToList();
            SearchByName(ref claimsList, searchClaimsDTO.SearchValue);

            if (searchClaimsDTO.InsurerId != null && searchClaimsDTO.InsurerId != "")
            {
                claimsList = claimsList.Where(x => x.InsurerId == Guid.Parse(searchClaimsDTO.InsurerId)).ToList();
            }

            if (searchClaimsDTO.InvoiceType != null && searchClaimsDTO.InvoiceType != "")
            {
                claimsList = claimsList.Where(x => x.InvoiceType == searchClaimsDTO.InvoiceType).ToList();
            }

            if (searchClaimsDTO.ClaimId != null)
            {
                claimsList = claimsList.Where(x => x.ClaimId.ToString() == searchClaimsDTO.ClaimId).ToList();
            }

            if (searchClaimsDTO.OrderByDescending == true)
            {
                if (searchClaimsDTO.OrderBy != null)
                {
                    claimsList = claimsList.OrderByDescending(x => x.GetType().GetProperty(searchClaimsDTO.OrderBy).GetValue(x));
                }
            }
            else
            {
                if (searchClaimsDTO.OrderBy != null)
                {
                    claimsList = claimsList.OrderBy(x => x.GetType().GetProperty(searchClaimsDTO.OrderBy).GetValue(x));
                }
            }
            int count = claimsList.Count();

            if (searchClaimsDTO.AllRecords)
                claimsList = claimsList.ToList();
            else
                claimsList = claimsList.Skip((searchClaimsDTO.PageNo - 1) * searchClaimsDTO.PageSize).Take(searchClaimsDTO.PageSize).ToList();

            return claimsList;
        }

        public IEnumerable<GetClaimsLogDTO> GetClaimsLogList(SearchClaimsLogDTO searchClaimsLogDTO)
        {
            if (searchClaimsLogDTO.OrderBy != null)
            {
                searchClaimsLogDTO.OrderBy = char.ToUpper(searchClaimsLogDTO.OrderBy[0]) + searchClaimsLogDTO.OrderBy.Substring(1);
            }
            IEnumerable<GetClaimsLogDTO> claimsLog = (from cl in _dbContext.PbClaimLogs
                                                      where cl.ClaimId.ToString() == searchClaimsLogDTO.ClaimId
                                                      select new GetClaimsLogDTO()
                                                      {
                                                          ClaimLogId = cl.ClaimLogId,
                                                          ClaimId = cl.ClaimId,
                                                          Category = cl.Category,
                                                          Description = cl.Description,
                                                          CreatedBy = cl.CreatedBy,
                                                          CreatedDate = cl.CreatedDate
                                                      }).OrderByDescending(x => x.CreatedDate).ToList();

            SearchByName(ref claimsLog, searchClaimsLogDTO.SearchValue);

            if (searchClaimsLogDTO.ClaimId != null)
            {
                claimsLog = claimsLog.Where(x => x.ClaimId.ToString() == searchClaimsLogDTO.ClaimId).ToList();
            }

            if (searchClaimsLogDTO.OrderByDescending == true)
            {
                if (searchClaimsLogDTO.OrderBy != null)
                {
                    claimsLog = claimsLog.OrderByDescending(x => x.GetType().GetProperty(searchClaimsLogDTO.OrderBy).GetValue(x));
                }
            }
            else
            {
                if (searchClaimsLogDTO.OrderBy != null)
                {
                    claimsLog = claimsLog.OrderBy(x => x.GetType().GetProperty(searchClaimsLogDTO.OrderBy).GetValue(x));
                }
            }
            int count = claimsLog.Count();

            if (searchClaimsLogDTO.AllRecords)
                claimsLog = claimsLog.ToList();
            else
                claimsLog = claimsLog.Skip((searchClaimsLogDTO.PageNo - 1) * searchClaimsLogDTO.PageSize).Take(searchClaimsLogDTO.PageSize).ToList();

            return claimsLog;
        }

        public GetClaimsViewDTO GetClaimsView(SearchClaimsViewDTO searchClaimsViewDTO)
        {
            var response = new GetClaimsViewDTO();

            if (searchClaimsViewDTO.ClaimStatus == "Not Submitted")
            {
                var claim = _dbContext.PbClaimDrafts.Where(x => x.ClaimId.ToString() == searchClaimsViewDTO.ClaimId && x.SubmittedBy == null && x.SubmittedDate == null).FirstOrDefault();

                var claimSuppliers = (from cs in _dbContext.PbClaimDraftSuppliers
                                      join s in _dbContext.PbSuppliers
                                      on cs.SupplierId equals s.SupplierId
                                      where cs.ClaimDraftId == claim.ClaimDraftId
                                      select new Supplier()
                                      {
                                          SupplierId = s.SupplierId,
                                          SupplierName = s.SupplierName
                                      }).ToList();
                var insurer = _dbContext.PbInsurers.Where(x => x.InsurerId == claim.InsurerId).FirstOrDefault();

                var client = _dbContext.PbClients.Where(x => x.ClientId == claim.ClientId).FirstOrDefault();

                 response = new GetClaimsViewDTO()
                {
                    ClientId = client.ClientId,
                    ClaimId = claim.ClaimId,
                    InsurerId = insurer.InsurerId,
                    InsuredName = claim.InsuredName,
                    InsuredPhoneNumber = claim.InsuredPhoneNumber,
                    InsurerClaimNumber = claim.InsurerClaimNumber,
                    InsurerName = insurer.InsurerName,
                    ClientName = client.ClientName,
                    DemoNumber = null,
                    ClaimAmount = claim.ClaimAmount,
                    VehicleMake = claim.VehicleMake,
                    VehicleRegistrationNumber = claim.VehicleRegistrationNumber,
                    Suppliers = claimSuppliers,

                };
            }
            else if (searchClaimsViewDTO.ClaimStatus == "Submitted Pending Approval")
            {
                var claim = _dbContext.PbClaimRequests.Where(x => x.ClaimId.ToString() == searchClaimsViewDTO.ClaimId && x.ApprovedBy == null && x.ApprovedDate == null).FirstOrDefault();

                var claimSuppliers = (from cs in _dbContext.PbClaimRequestSuppliers
                                      join s in _dbContext.PbSuppliers
                                      on cs.SupplierId equals s.SupplierId
                                      where cs.ClaimRequestId == claim.ClaimRequestId
                                      select new Supplier()
                                      {
                                          SupplierId = s.SupplierId,
                                          SupplierName = s.SupplierName
                                      }).ToList();
                var insurer = _dbContext.PbInsurers.Where(x => x.InsurerId == claim.InsurerId).FirstOrDefault();

                var client = _dbContext.PbClients.Where(x => x.ClientId == claim.ClientId).FirstOrDefault();

                 response = new GetClaimsViewDTO()
                {
                    ClientId = client.ClientId,
                    ClaimId = claim.ClaimId,
                    InsurerId = insurer.InsurerId,
                    InsuredName = claim.InsuredName,
                    InsuredPhoneNumber = claim.InsuredPhoneNumber,
                    InsurerClaimNumber = claim.InsurerClaimNumber,
                    InsurerName = insurer.InsurerName,
                    ClientName = client.ClientName,
                    DemoNumber = null,
                    ClaimAmount = claim.ClaimAmount,
                    VehicleMake = claim.VehicleMake,
                    VehicleRegistrationNumber = claim.VehicleRegistrationNumber,
                    Suppliers = claimSuppliers,

                };
            }
            else if(searchClaimsViewDTO.ClaimStatus == "Claim Approved" || searchClaimsViewDTO.ClaimStatus == "Update Pending Approval")
            {
                var claim = _dbContext.PbClaims.Where(x => x.ClaimId.ToString() == searchClaimsViewDTO.ClaimId).FirstOrDefault();

                var claimSuppliers = (from cs in _dbContext.PbClaimSuppliers
                                      join s in _dbContext.PbSuppliers
                                      on cs.SupplierId equals s.SupplierId
                                      where cs.ClaimId.ToString() == searchClaimsViewDTO.ClaimId
                                      select new Supplier()
                                      {
                                          SupplierId = s.SupplierId,
                                          SupplierName = s.SupplierName
                                      }).ToList();
                var insurer = _dbContext.PbInsurers.Where(x => x.InsurerId == claim.InsurerId).FirstOrDefault();

                var client = _dbContext.PbClients.Where(x => x.ClientId == claim.ClientId).FirstOrDefault();

                response = new GetClaimsViewDTO()
                {
                    ClientId = client.ClientId,
                    ClaimId = claim.ClaimId,
                    InsurerId = insurer.InsurerId,
                    InsuredName = claim.InsuredName,
                    InsuredPhoneNumber = claim.InsuredPhoneNumber,
                    InsurerClaimNumber = claim.InsurerClaimNumber,
                    InsurerName = insurer.InsurerName,
                    ClientName = client.ClientName,
                    DemoNumber = claim.DemoNumber,
                    ClaimAmount = claim.ClaimAmount,
                    VehicleMake = claim.VehicleMake,
                    VehicleRegistrationNumber = claim.VehicleRegistrationNumber,
                    Suppliers = claimSuppliers,

                };
            }
           
     

            var claimDocuments = _dbContext.PbClaimDocuments.Where(x => x.ClaimId.ToString() == searchClaimsViewDTO.ClaimId).ToList();

            var claimDocumentList = new List<ClaimDocument>();
            foreach (var document in claimDocuments)
            {
                claimDocumentList.Add(new ClaimDocument()
                {
                    ClaimDocumentId = document.ClaimDocumentId,
                    DocumentName = document.DocumentName,
                    DocumentType = document.DocumentName,
                    Document = "data:image/png;base64," + Convert.ToBase64String(document.DocumentData),
                    Description = document.Description,
                    DocumentSize = document.DocumentSize,
                    DocumentUrl = document.DocumentUrl
                });
            }

            response.ClaimDocuments = claimDocumentList;

            return response;
        }

        public GetClientDetailsDTO GetClientDetails(SearchClientDetailsDTO searchClientDetailsDTO)
        {
            var clientSuppliers = (from cs in _dbContext.PbClientSuppliers
                                   join s in _dbContext.PbSuppliers
                                   on cs.SupplierId equals s.SupplierId
                                   where cs.ClientId.ToString() == searchClientDetailsDTO.ClientId && s.Obselete == false
                                   select new ClientSupplier()
                                   {
                                       SupplierId = s.SupplierId,
                                       SupplierName = s.SupplierName
                                   }).OrderBy(x => x.SupplierName).ToList();

            var clientInsurers = (from ci in _dbContext.PbClientInsurers
                                  join i in _dbContext.PbInsurers
                                  on ci.InsurerId equals i.InsurerId
                                  where ci.ClientId.ToString() == searchClientDetailsDTO.ClientId
                                  select new ClientInsurer()
                                  {
                                      InsurerId = i.InsurerId,
                                      InsurerName = i.InsurerName
                                  }).OrderBy(x => x.InsurerName).ToList();

            var response = new GetClientDetailsDTO()
            {
                ClientId = Guid.Parse(searchClientDetailsDTO.ClientId),
                ClientSuppliers = clientSuppliers,
                ClientInsurers = clientInsurers
            };
            return response;
        }

        public IEnumerable<GetClientInsurersDTO> GetClientInsurers(SearchClientInsurersDTO searchClientInsurersDTO)
        {
            var clientInsurers = (from ci in _dbContext.PbClientInsurers
                                  join i in _dbContext.PbInsurers
                                  on ci.InsurerId equals i.InsurerId
                                  join l in _dbContext.Lookups
                                  on i.InsurerTypeId equals l.LookupId
                                  where ci.ClientId.ToString() == searchClientInsurersDTO.ClientId //&& i.Obsolete == false
                                  select new GetClientInsurersDTO()
                                  {
                                      InsurerId = i.InsurerId,
                                      InsurerType = l.Description,
                                      InsurerName = i.InsurerName
                                  }).ToList();
            return clientInsurers;
        }

        public IEnumerable<GetCorrespondanceDTO> GetCorrespondaceList(SearchCorrespondanceDTO searchCorrespondanceDTO)
        {
            IEnumerable<GetCorrespondanceDTO> correspondaceList = _dbContext.PbCorrespondances.Where(x => x.ClaimId == Guid.Parse(searchCorrespondanceDTO.ClaimId)).Select(x => new GetCorrespondanceDTO()
            {
                CorrespondenceId = x.CorrespondanceId,
                ClaimId = x.ClaimId,
                Username = x.Username,
                MessageCategory = x.MessageCategory,
                MessageType = x.MessageType,
                MessageContent = x.MessageContent,
                MessageSubject = x.MessageSubject,
                Recipients = x.Recipients,
                SentDate = x.SentDate,
                LogDate = x.LogDate
            });

            SearchByName(ref correspondaceList, searchCorrespondanceDTO.SearchValue);

            if (searchCorrespondanceDTO.ClaimId != null)
            {
                correspondaceList = correspondaceList.Where(x => x.ClaimId.ToString() == searchCorrespondanceDTO.ClaimId).ToList();
            }

            if (searchCorrespondanceDTO.OrderByDescending == true)
            {
                if (searchCorrespondanceDTO.OrderBy != null)
                {
                    correspondaceList = correspondaceList.OrderByDescending(x => x.GetType().GetProperty(searchCorrespondanceDTO.OrderBy).GetValue(x));
                }
            }
            else
            {
                if (searchCorrespondanceDTO.OrderBy != null)
                {
                    correspondaceList = correspondaceList.OrderBy(x => x.GetType().GetProperty(searchCorrespondanceDTO.OrderBy).GetValue(x));
                }
            }
            int count = correspondaceList.Count();

            if (searchCorrespondanceDTO.AllRecords)
                correspondaceList = correspondaceList.ToList();
            else
                correspondaceList = correspondaceList.Skip((searchCorrespondanceDTO.PageNo - 1) * searchCorrespondanceDTO.PageSize).Take(searchCorrespondanceDTO.PageSize).ToList();

            return correspondaceList;
        }

        public IEnumerable<GetPanelBeaterInsurersDTO> GetPanelBeaterInsurers()
        {
            IEnumerable<GetPanelBeaterInsurersDTO> insurersList = (from i in _dbContext.PbInsurers
                                                                   where i.Obsolete == false
                                                                   select new GetPanelBeaterInsurersDTO()
                                                                   {
                                                                       InsurerId = i.InsurerId,
                                                                       InsurerName = i.InsurerName
                                                                   }).ToList();
            return insurersList;
        }

        public async Task<ResponseDTO> RequestPartsSummaryAsync(RequestPartsSummaryDTO requestPartsSummaryDTO)
        {
            var claimToUpdate = _dbContext.PbClaims.Where(x => x.ClaimId.ToString() == requestPartsSummaryDTO.ClaimId).FirstOrDefault();

            if (claimToUpdate == null)
            {
                throw new Exception(ResponseMessages.NoClaimExists);
            }
            else
            {

                claimToUpdate.FinalCostingRequestedBy = requestPartsSummaryDTO.ActionPerformedBy;
                claimToUpdate.FinalCostingRequestedDate = DateTime.Now;

                _dbContext.PbClaims.Update(claimToUpdate);

                var claimLog = new PbClaimLog();
                claimLog.ClaimLogId = Guid.NewGuid();
                claimLog.ClaimId = Guid.Parse(requestPartsSummaryDTO.ClaimId);
                claimLog.Category = "Claims";
                claimLog.Description = "Final costings requested";
                claimLog.CreatedBy = requestPartsSummaryDTO.ActionPerformedBy;
                claimLog.CreatedDate = DateTime.Now;

                await _dbContext.PbClaimLogs.AddAsync(claimLog);

                await _dbContext.SaveChangesAsync();
                return new ResponseDTO()
                {
                    KeyId = 1,
                    ResponseCode = ResponseCode.Success,
                    ResponseMessage = ResponseMessages.PartSummaryRequested
                };
            }
        }

        public async Task<ResponseDTO> UpdateClaimAsync(UpdateClaimDTO updateClaimDTO)
        {
            bool alreadyLogged = false;
            bool isInsurerChanged = false;

            var claimToUpdate = _dbContext.PbClaims.Where(x => x.ClaimId.ToString() == updateClaimDTO.ClaimId).FirstOrDefault();

            if (claimToUpdate == null)
            {
                throw new Exception(ResponseMessages.NoClaimExists);
            }
            else
            {
                //here we check if the user has changed the invoice Type 
                //_____________________________________________________________
                //1. Users Cannot change to no parts if a parts invoice has already been loaded against it
                //2. Cannot change the Invoice type if the claim has been final invoice authorised

                if (claimToUpdate.InvoiceType != updateClaimDTO.InvoiceType)
                {
                    if (updateClaimDTO.InvoiceType == "No Parts")
                    {
                        if (_dbContext.ImportedSupplierDocuments.Where(x => x.ClaimId.ToString() == updateClaimDTO.ClaimId).Any())
                        {
                            throw new Exception(ResponseMessages.CannotSetToNoParts);
                        }
                    }

                    if (claimToUpdate.FinalInvoiceAuthorisedDate != null)
                    {
                        throw new Exception(ResponseMessages.CannotChangeInvoiceType);
                    }

                    var invoiceTypeLog = new PbClaimLog();

                    invoiceTypeLog.ClaimLogId = Guid.NewGuid();
                    invoiceTypeLog.ClaimId = claimToUpdate.ClaimId;
                    invoiceTypeLog.Category = "Claims";
                    invoiceTypeLog.CreatedBy = updateClaimDTO.ActionPerformedBy;
                    invoiceTypeLog.CreatedDate = DateTime.Now;
                    invoiceTypeLog.Description = "Invocie type changed from to: " + updateClaimDTO.InvoiceType + " from: " + claimToUpdate.InvoiceType;

                    await _dbContext.PbClaimLogs.AddAsync(invoiceTypeLog);

                    claimToUpdate.InvoiceType = updateClaimDTO.InvoiceType;

                }

                // Checking insuerer changed or not

                string insurerType = (from l in _dbContext.Lookups
                                      join i in _dbContext.PbInsurers
                                      on l.LookupId equals i.InsurerTypeId
                                      where i.InsurerId.ToString() == updateClaimDTO.InsurerId
                                      select l.Description).FirstOrDefault();

                if (insurerType == "Self Insured" || insurerType == "Commercial Insurer")
                {
                    if (claimToUpdate.InsurerIdsecondary != Guid.Parse(updateClaimDTO.InsurerId))
                    {
                        isInsurerChanged = true;
                        string oldInsurer = _dbContext.PbInsurers.Where(x => x.InsurerId == claimToUpdate.InsurerIdsecondary).Select(x => x.InsurerName).FirstOrDefault();
                        string newInsurer = _dbContext.PbInsurers.Where(x => x.InsurerId == Guid.Parse(updateClaimDTO.InsurerId)).Select(x => x.InsurerName).FirstOrDefault();

                        var secondaryInsurerChangedLog = new PbClaimLog();

                        secondaryInsurerChangedLog.ClaimLogId = Guid.NewGuid();
                        secondaryInsurerChangedLog.ClaimId = claimToUpdate.ClaimId;
                        secondaryInsurerChangedLog.Category = "Claims";
                        secondaryInsurerChangedLog.CreatedBy = updateClaimDTO.ActionPerformedBy;
                        secondaryInsurerChangedLog.CreatedDate = DateTime.Now;
                        secondaryInsurerChangedLog.Description = "Edited Claim Information - Secondary Insurer changed from: " + oldInsurer + " to: " + newInsurer + " by: " + updateClaimDTO.ActionPerformedBy;

                        await _dbContext.PbClaimLogs.AddAsync(secondaryInsurerChangedLog);

                        alreadyLogged = true;
                    }

                    claimToUpdate.InsurerIdsecondary = Guid.Parse(updateClaimDTO.InsurerId);
                }
                else
                {
                    if (claimToUpdate.InsurerId != Guid.Parse(updateClaimDTO.InsurerId))
                    {
                        isInsurerChanged = true;
                        string oldInsurer = _dbContext.PbInsurers.Where(x => x.InsurerId == claimToUpdate.InsurerId).Select(x => x.InsurerName).FirstOrDefault();
                        string newInsurer = _dbContext.PbInsurers.Where(x => x.InsurerId == Guid.Parse(updateClaimDTO.InsurerId)).Select(x => x.InsurerName).FirstOrDefault();

                        var insurerChangedLog = new PbClaimLog();

                        insurerChangedLog.ClaimLogId = Guid.NewGuid();
                        insurerChangedLog.ClaimId = claimToUpdate.ClaimId;
                        insurerChangedLog.Category = "Claims";
                        insurerChangedLog.CreatedBy = updateClaimDTO.ActionPerformedBy;
                        insurerChangedLog.CreatedDate = DateTime.Now;
                        insurerChangedLog.Description = "Edited Claim Information - Insurer changed from: " + oldInsurer + " to: " + newInsurer + " by: " + updateClaimDTO.ActionPerformedBy;

                        await _dbContext.PbClaimLogs.AddAsync(insurerChangedLog);

                        alreadyLogged = true;
                    }
                    claimToUpdate.InsurerId = Guid.Parse(updateClaimDTO.InsurerId);
                }


                // checking whether ClaimAmount or not 
                if (claimToUpdate.ClaimAmount != updateClaimDTO.ClaimAmount)
                {
                    var claimAmountChangedLog = new PbClaimLog();

                    claimAmountChangedLog.ClaimLogId = Guid.NewGuid();
                    claimAmountChangedLog.ClaimId = claimToUpdate.ClaimId;
                    claimAmountChangedLog.Category = "Claims";
                    claimAmountChangedLog.CreatedBy = updateClaimDTO.ActionPerformedBy;
                    claimAmountChangedLog.CreatedDate = DateTime.Now;
                    claimAmountChangedLog.Description = "Edited Claim Information - Claim amount changed from: " + claimToUpdate.ClaimAmount + " to: " + updateClaimDTO.ClaimAmount + " by: " + updateClaimDTO.ActionPerformedBy;

                    await _dbContext.PbClaimLogs.AddAsync(claimAmountChangedLog);
                    alreadyLogged = true;
                }

                if (!alreadyLogged)
                {
                    var claimEditedLog = new PbClaimLog();

                    claimEditedLog.ClaimLogId = Guid.NewGuid();
                    claimEditedLog.ClaimId = claimToUpdate.ClaimId;
                    claimEditedLog.Category = "Claims";
                    claimEditedLog.CreatedBy = updateClaimDTO.ActionPerformedBy;
                    claimEditedLog.CreatedDate = DateTime.Now;
                    claimEditedLog.Description = "Edited Claim Information - Claim amount changed from: " + claimToUpdate.ClaimAmount + " to: " + updateClaimDTO.ClaimAmount + " by: " + updateClaimDTO.ActionPerformedBy;

                    await _dbContext.PbClaimLogs.AddAsync(claimEditedLog);
                }


                claimToUpdate.InsurerClaimNumber = updateClaimDTO.InsurerClaimNumber;
                claimToUpdate.VehicleRegistrationNumber = updateClaimDTO.VehicleRegistrationNumber;
                claimToUpdate.VehicleMake = updateClaimDTO.VehicleMake;
                claimToUpdate.VehicleModel = updateClaimDTO.VehicleModel;
                claimToUpdate.DemoNumber = updateClaimDTO.DemoNumber;
                claimToUpdate.EstimatedDaysToComplete = updateClaimDTO.EstimatedDaysToComplete;
                claimToUpdate.InsuredName = updateClaimDTO.InsuredName;
                claimToUpdate.InsuredPhoneNumber = updateClaimDTO.InsuredPhoneNumber;
                claimToUpdate.ClaimAmount = updateClaimDTO.ClaimAmount;
                claimToUpdate.Ronumber = updateClaimDTO.JobCardNo;
                claimToUpdate.ClaimExcess = updateClaimDTO.ClaimExcess;
                claimToUpdate.ClaimPartsValue = updateClaimDTO.ClaimPartsValue;
                claimToUpdate.ClaimStatus = "Update Pending Approval";
                claimToUpdate.ModifiedBy = updateClaimDTO.ActionPerformedBy;
                claimToUpdate.ModifiedDate = DateTime.Now;
                claimToUpdate.CreatedDate = DateTime.Now;

                var lastClaimSuppliers = _dbContext.PbClaimSuppliers.Where(x => x.ClaimId == claimToUpdate.ClaimId).ToList();

                // here we are deleting initial supplier which are not in new list
                foreach (var supplier in lastClaimSuppliers)
                {
                    var tempSupplier = updateClaimDTO.ClaimSuppliers.Where(x => x.SupplierId == supplier.SupplierId.ToString()).FirstOrDefault();

                    if (tempSupplier == null)
                    {
                        _dbContext.PbClaimSuppliers.Remove(supplier);
                    }
                }

                var claimSupplierAfterDeleting = _dbContext.PbClaimSuppliers.Where(x => x.ClaimId == claimToUpdate.ClaimId).ToList();

                //  here we are adding new suppliers
                foreach (var supplier in updateClaimDTO.ClaimSuppliers)
                {
                    var tempSupplier = claimSupplierAfterDeleting.Where(x => x.ClaimId == claimToUpdate.ClaimId && x.SupplierId.ToString() == supplier.SupplierId).FirstOrDefault();

                    if (tempSupplier == null)
                    {
                        var claimSupplierToAdd = new PbClaimSupplier();

                        claimSupplierToAdd.ClaimId = claimToUpdate.ClaimId;
                        claimSupplierToAdd.ClaimSupplierId = Guid.NewGuid();
                        claimSupplierToAdd.SupplierId = Guid.Parse(supplier.SupplierId);
                        claimSupplierToAdd.CreatedBy = updateClaimDTO.ActionPerformedBy;
                        claimSupplierToAdd.CreatedDate = DateTime.Now;
                        claimSupplierToAdd.ModifiedBy = updateClaimDTO.ActionPerformedBy;
                        claimSupplierToAdd.ModifiedDate = DateTime.Now;

                        await _dbContext.PbClaimSuppliers.AddAsync(claimSupplierToAdd);

                    }
                }

                _dbContext.PbClaims.Update(claimToUpdate);

                await _dbContext.SaveChangesAsync();
                return new ResponseDTO()
                {
                    KeyId = 1,
                    ResponseCode = ResponseCode.Success,
                    ResponseMessage = ResponseMessages.ClaimUpdated
                };
            }
        }

        private void SearchByName(ref IEnumerable<GetClaimsDTO> claimsList, string SearchValue)
        {
            if (!claimsList.Any() || string.IsNullOrWhiteSpace(SearchValue))
                return;
            claimsList = claimsList.Where(o => o.DemoNumber.ToString().ToLower().Contains(SearchValue.Trim().ToLower()) ||
            o.InsurerClaimNumber.ToLower().Contains(SearchValue.Trim().ToLower()) || o.InsuredName.ToLower().Contains(SearchValue.Trim().ToLower())
            || o.Make.ToLower().Contains(SearchValue.Trim().ToLower()) || o.VehicleRegistrationNumber.ToLower().Contains(SearchValue.Trim().ToLower()) || o.JobCardNo.ToLower().Contains(SearchValue.Trim().ToLower()) || o.ClientName.ToLower().Contains(SearchValue.Trim().ToLower()));
        }
        private void SearchByName(ref IEnumerable<GetClaimsLogDTO> claimsLogList, string SearchValue)
        {
            if (!claimsLogList.Any() || string.IsNullOrWhiteSpace(SearchValue))
                return;
            claimsLogList = claimsLogList.Where(o => o.Description.ToString().ToLower().Contains(SearchValue.Trim().ToLower()) ||
            o.CreatedBy.ToLower().Contains(SearchValue.Trim().ToLower()));
        }
        private void SearchByName(ref IEnumerable<GetCorrespondanceDTO> correspondanceList, string SearchValue)
        {
            if (!correspondanceList.Any() || string.IsNullOrWhiteSpace(SearchValue))
                return;
            correspondanceList = correspondanceList.Where(o => o.MessageSubject.ToString().ToLower().Contains(SearchValue.Trim().ToLower()) ||
            o.MessageCategory.ToLower().Contains(SearchValue.Trim().ToLower()));
        }

        public async Task<IEnumerable<GetRequestedClaimsDTO>> GetRequestedClaimsAsync(SearchRequestedClaimsDTO searchRequestedClaimsDTO)
        {
            var responseData = await CollectionsAsync<GetRequestedClaimsDTO>(StoreProcedures.GetRequestedClaims);

            responseData = responseData.OrderByDescending(x => x.CreatedDate).ToList();

            SearchByName(ref responseData, searchRequestedClaimsDTO.SearchValue);

            if (searchRequestedClaimsDTO.ClientId != null && searchRequestedClaimsDTO.ClientId != "")
            {
                var clientName = _dbContext.PbClients.Where(x => x.ClientId == Guid.Parse(searchRequestedClaimsDTO.ClientId)).Select(x => x.ClientName).FirstOrDefault();
                responseData = responseData.Where(x => x.ClientName == clientName).ToList();
            }

            if (searchRequestedClaimsDTO.InvoiceType != null && searchRequestedClaimsDTO.InvoiceType != "")
            {
                responseData = responseData.Where(x => x.InvoiceType == searchRequestedClaimsDTO.InvoiceType).ToList();
            }

            if (searchRequestedClaimsDTO.OrderByDescending == true)
            {
                if (searchRequestedClaimsDTO.OrderBy != null)
                {
                    responseData = responseData.OrderByDescending(x => x.GetType().GetProperty(searchRequestedClaimsDTO.OrderBy).GetValue(x));
                }
            }
            else
            {
                if (searchRequestedClaimsDTO.OrderBy != null)
                {
                    responseData = responseData.OrderBy(x => x.GetType().GetProperty(searchRequestedClaimsDTO.OrderBy).GetValue(x));
                }
            }
            int count = responseData.Count();

            if (searchRequestedClaimsDTO.AllRecords)
                responseData = responseData.ToList();
            else
                responseData = responseData.Skip((searchRequestedClaimsDTO.PageNo - 1) * searchRequestedClaimsDTO.PageSize).Take(searchRequestedClaimsDTO.PageSize).ToList();

            return responseData;
        }

        private void SearchByName(ref IEnumerable<GetRequestedClaimsDTO> claimsRequestsList, string SearchValue)
        {
            if (!claimsRequestsList.Any() || string.IsNullOrWhiteSpace(SearchValue))
                return;
            claimsRequestsList = claimsRequestsList.Where(o => o.Ronumber.ToString().ToLower().Contains(SearchValue.Trim().ToLower()) ||
            o.InsurerClaimNumber.ToLower().Contains(SearchValue.Trim().ToLower()) ||
            o.VehicleRegistrationNumber.ToLower().Contains(SearchValue.Trim().ToLower()) ||
            o.InsuredName.ToLower().Contains(SearchValue.Trim().ToLower()));
        }

        public GetRequestedClaimDetailsDTO GetRequestedClaimDetails(SearchRequestedClaimDetailsDTO searchRequestedClaimDetailsDTO)
        {
            var response = (from rc in _dbContext.PbClaimRequests
                            join c in _dbContext.PbClients on rc.ClientId equals c.ClientId
                            join i in _dbContext.PbInsurers on rc.InsurerId equals i.InsurerId
                            where rc.ClaimRequestId.ToString() == searchRequestedClaimDetailsDTO.ClaimRequestId
                            select new GetRequestedClaimDetailsDTO()
                            {
                                ClaimRequestId = rc.ClaimRequestId,
                                ClientId = rc.ClientId,
                                ClaimId = rc.ClaimId,
                                InsurerId = rc.InsurerId,
                                ClientName = c.ClientName,
                                CreatedDate = rc.CreatedDate,
                                CreatedBy = rc.CreatedBy,
                                InsurerName = i.InsurerName,
                                InsurerClaimNumber = rc.InsurerClaimNumber,
                                VehicleRegistrationNumber = rc.VehicleRegistrationNumber,
                                VehicleMake = rc.VehicleMake,
                                VehicleModel = rc.VehicleModel,
                                InsuredName = rc.InsuredName,
                                InsuredPhoneNumber = rc.InsuredPhoneNumber,
                                ClaimAmount = rc.ClaimAmount,
                                ClaimExcess = rc.ClaimExcess,
                                JobCardNo = rc.Ronumber,
                                Year = rc.Year,
                                Paint = rc.Paint,
                                Labour = rc.Labour,
                                VINNumber = rc.VINNumber,
                                ClaimPartsValue = rc.ClaimPartsValue,
                                InvoiceType = rc.InvoiceType,
                                EstimatedDaysToComplete = rc.EstimatedDaysToCompleted,
                                RequestedClaimSuppliers = (from crs in _dbContext.PbClaimRequestSuppliers
                                                           join s in _dbContext.PbSuppliers on crs.SupplierId equals s.SupplierId
                                                           where crs.ClaimRequestId.ToString() == searchRequestedClaimDetailsDTO.ClaimRequestId
                                                           select new RequestedClaimSuppliers()
                                                           {
                                                               SupplierId = crs.SupplierId,
                                                               SupplierName = s.SupplierName
                                                           }).ToList()

                            }).FirstOrDefault();
            return response;
        }

        public async Task<ResponseDTO> CancelClaimRequestAsync(CancelClaimRequestDTO cancelClaimRequestDTO)
        {
            var claimRequestToCancel = _dbContext.PbClaimRequests.Where(x => x.ClaimId.ToString() == cancelClaimRequestDTO.ClaimId).FirstOrDefault();
            if (claimRequestToCancel != null)
            {
                claimRequestToCancel.DeclinedBy = cancelClaimRequestDTO.ActionPerformedBy;
                claimRequestToCancel.DeclinedDate = DateTime.Now;

                _dbContext.PbClaimRequests.Update(claimRequestToCancel);

                await _dbContext.SaveChangesAsync();

                return new ResponseDTO()
                {
                    KeyId = 1,
                    ResponseCode = ResponseCode.Success,
                    ResponseMessage = ResponseMessages.ClaimRequestedDeclined
                };
            }
            else
            {
                throw new Exception(ResponseMessages.NoClaimRequestExists);
            }
        }

        public async Task<AddRequestedClaimResponseDTO> AddRequestedClaimAsync(AddRequestedClaimDTO addRequestedClaimDTO)
        {
            bool ClientOnHold = false;
            bool InsurerOnHold = false;
            bool GET_NEW_Demo_NUMBER = false;
            string THE_Demo_NUMBER = "";
            Guid ClientId = Guid.Parse(addRequestedClaimDTO.ClientId);
            Guid InsurerId = Guid.Parse(addRequestedClaimDTO.InsurerId);
            Guid ClaimId = Guid.Parse(addRequestedClaimDTO.ClaimId);

            if (addRequestedClaimDTO.ClaimSuppliers.Count == 0 && addRequestedClaimDTO.InvoiceType != "No Parts")
            {
                throw new Exception(ResponseMessages.InvoiceTypeError);
            }
            if (addRequestedClaimDTO.ClaimSuppliers.Count > 0 && addRequestedClaimDTO.InvoiceType == "No Parts")
            {
                throw new Exception(ResponseMessages.InvoiceTypeConflict);
            }
            if (addRequestedClaimDTO.EstimatedDaysToComplete < 1)
            {
                throw new Exception(ResponseMessages.EstimatedDaysToCompleteError);
            }

            // checking whether client or Insurer are on Hold
            ClientOnHold = Convert.ToBoolean(_dbContext.PbClients.Where(x => x.ClientId == ClientId).Select(x => x.OnHold ?? false).FirstOrDefault());
            InsurerOnHold = Convert.ToBoolean(_dbContext.PbInsurers.Where(x => x.InsurerId == InsurerId).Select(x => x.OnHold ?? false).FirstOrDefault());

            // here we are getting hold details
            if (ClientOnHold)
            {
                var holdDetails = _dbContext.PbClients.Where(x => x.ClientId == ClientId).Select(x => new { x.ClientName, x.OnHoldReason }).FirstOrDefault();
                throw new Exception(holdDetails.ClientName.ToUpper() + " has been placed on hold because: " + holdDetails.OnHoldReason);
            }
            if (InsurerOnHold)
            {
                var holdDetails = _dbContext.PbInsurers.Where(x => x.InsurerId == InsurerId).Select(x => new { x.InsurerName, x.OnHoldReason }).FirstOrDefault();
                throw new Exception(holdDetails.InsurerName + " has been placed on hold because: " + holdDetails.OnHoldReason);
            }

            // here we are checking whether the suppliers that are selected is there any one on hold
            foreach (var supplier in addRequestedClaimDTO.ClaimSuppliers)
            {
                Guid supplierId = Guid.Parse(supplier.SupplierId);

                var isSupplierOnHold = _dbContext.PbSuppliers.Where(x => x.SupplierId == supplierId).Select(x => x.OnHold ?? false).FirstOrDefault();
                if (isSupplierOnHold)
                {
                    var holdDetails = _dbContext.PbSuppliers.Where(x => x.SupplierId == supplierId).Select(x => new { x.SupplierName, x.OnHoldReason }).FirstOrDefault();
                    throw new Exception(holdDetails.SupplierName + " has been placed on hold because: " + holdDetails.OnHoldReason);
                }
            }

            // checking whether vehicle registration no. or Insure claim no. already exists
            if (_dbContext.PbClaims.Where(x => x.InsurerClaimNumber == addRequestedClaimDTO.InsurerClaimNumber && x.InsurerId == Guid.Parse(addRequestedClaimDTO.InsurerId)).Any())
            {
                throw new Exception("Insurer claim number already in use");
            }

            var nextSeq = await CommandAsync<NextSequenceNumber>(StoreProcedures.GetNextSequenceNumber, new { SeqName = "DemoSeqNo" });

            var newClaimToAdd = new PbClaim();

            newClaimToAdd.ClaimId = ClaimId;
            newClaimToAdd.ClientId = Guid.Parse(addRequestedClaimDTO.ClientId);
            newClaimToAdd.InsurerId = Guid.Parse(addRequestedClaimDTO.InsurerId);
            newClaimToAdd.DemoSeqNo = nextSeq.retVal;
            newClaimToAdd.InsurerClaimNumber = addRequestedClaimDTO.InsurerClaimNumber;
            newClaimToAdd.VehicleRegistrationNumber = addRequestedClaimDTO.VehicleRegistrationNumber;
            newClaimToAdd.VehicleMake = addRequestedClaimDTO.VehicleMake;
            newClaimToAdd.VehicleModel = addRequestedClaimDTO.VehicleModel;
            newClaimToAdd.InsuredName = addRequestedClaimDTO.InsuredName;
            newClaimToAdd.InsuredPhoneNumber = addRequestedClaimDTO.InsuredPhoneNumber;
            newClaimToAdd.ClaimAmount = addRequestedClaimDTO.ClaimAmount;
            newClaimToAdd.ClaimStatus = "Claim Approved";
            newClaimToAdd.Ronumber = addRequestedClaimDTO.JobCardNo;
            newClaimToAdd.ClaimExcess = addRequestedClaimDTO.ClaimExcess;
            newClaimToAdd.ClaimPartsValue = addRequestedClaimDTO.ClaimPartsValue;
            newClaimToAdd.InvoiceType = addRequestedClaimDTO.InvoiceType;
            newClaimToAdd.InitialClaimAmount = addRequestedClaimDTO.ClaimAmount;
            newClaimToAdd.EstimatedDaysToComplete = addRequestedClaimDTO.EstimatedDaysToComplete;
            newClaimToAdd.CreatedBy = addRequestedClaimDTO.ActionPerformedBy;
            newClaimToAdd.CreatedDate = DateTime.Now;
            newClaimToAdd.ModifiedBy = addRequestedClaimDTO.ActionPerformedBy;
            newClaimToAdd.ModifiedDate = DateTime.Now;

            newClaimToAdd.EstimatedBookInDate = _dbContext.PbClaimRequests.Where(x => x.ClaimRequestId == Guid.Parse(addRequestedClaimDTO.ClaimRequestId)).Select(x => x.EstimatedBookInDate).FirstOrDefault();

            var ClaimRequest = _dbContext.PbClaimRequests.Where(x => x.ClaimId == ClaimId).Select(x => x).FirstOrDefault();
            ClaimRequest.ApprovedBy = addRequestedClaimDTO.ActionPerformedBy;
            ClaimRequest.ApprovedDate = DateTime.Now;

            // here we are genrating Demo number
            AdministrationConfig config = _dbContext.AdministrationConfigs.Where(c => c.Category == "CLAIMS" && c.Item == "GET_NEW_Demo_NUMBER").FirstOrDefault();

            if (config != null)
            {
                GET_NEW_Demo_NUMBER = Convert.ToBoolean(config.Value);
            }

            if (GET_NEW_Demo_NUMBER)
            {
                var clientName = _dbContext.PbClients.Where(x => x.ClientId == ClientId).Select(x => x.ClientName).FirstOrDefault();
                if (!clientName.ToUpper().Contains("TEST"))
                {
                    int clientNumber = 0;
                    clientNumber = Convert.ToInt32(_dbContext.PbClients.Where(c => c.ClientId == ClientId).Select(x => x.ExternalId).FirstOrDefault());


                    int value = nextSeq.retVal;
                    string alphabet = "0123456789ABCDEFGHJKLMNPQRSTUVWXYZ";
                    var stack = new Stack<char>();
                    while (value > 0)
                    {
                        stack.Push(alphabet[value % alphabet.Length]);
                        value /= alphabet.Length;
                    }
                    string output = new string(stack.ToArray()).PadLeft(5, '0');

                    THE_Demo_NUMBER = clientNumber.ToString() + "/" + output;

                    newClaimToAdd.DemoNumber = THE_Demo_NUMBER;
                    newClaimToAdd.DemoSeqNo = nextSeq.retVal;
                }
                else
                {
                    THE_Demo_NUMBER = ClaimId.ToString().Substring(0, 6);
                    newClaimToAdd.DemoNumber = THE_Demo_NUMBER;
                }
            }

            await _dbContext.PbClaims.AddAsync(newClaimToAdd);

            // here we adding claim suppliers
            foreach (var supplier in addRequestedClaimDTO.ClaimSuppliers)
            {
                var newSupplier = new PbClaimSupplier();

                newSupplier.ClaimSupplierId = Guid.NewGuid();
                newSupplier.ClaimId = ClaimId;
                newSupplier.SupplierId = Guid.Parse(supplier.SupplierId);
                newSupplier.CreatedBy = addRequestedClaimDTO.ActionPerformedBy;
                newSupplier.CreatedDate = DateTime.Now;
                newSupplier.ModifiedBy = addRequestedClaimDTO.ActionPerformedBy;
                newSupplier.ModifiedDate = DateTime.Now;

                await _dbContext.PbClaimSuppliers.AddAsync(newSupplier);
            }

            // here creating a claim log

            var claimLog = new PbClaimLog();
            claimLog.ClaimLogId = Guid.NewGuid();
            claimLog.ClaimId = ClaimId;
            claimLog.Category = "Claims";
            claimLog.Description = "Created new claim";
            claimLog.CreatedBy = addRequestedClaimDTO.ActionPerformedBy;
            claimLog.CreatedDate = DateTime.Now;

            await _dbContext.PbClaimLogs.AddAsync(claimLog);

            await _dbContext.SaveChangesAsync();

            return new AddRequestedClaimResponseDTO()
            {
                KeyId = 1,
                ResponseCode = ResponseCode.Success,
                ResponseMessage = ResponseMessages.RequestedClaimAdded + THE_Demo_NUMBER,
                DemoNumber = THE_Demo_NUMBER
            };
        }

        public IEnumerable<GetClaimStatusDTO> GetStatusList()
        {
            var claimStatusList = _dbContext.PbClaims.OrderBy(x => x.ClaimStatus).Select(x => new GetClaimStatusDTO() { Status = x.ClaimStatus }).ToList();
            return claimStatusList.GroupBy(x => x.Status).Select(x => x.First());
        }

        public IEnumerable<GetAssessorsDTO> GetAssesors()
        {
            var assessors = (from ac in _dbContext.PbAssessorCompanies
                             select new GetAssessorsDTO()
                             {
                                 AssessorComapnyId = ac.AssessorCompanyId,
                                 CompanyName = ac.CompanyName,
                                 AssessorDetails = (from ad in _dbContext.PbAssessorDetails
                                                    where ad.AssessorCompanyId == ac.AssessorCompanyId
                                                    select new AssessorDetails()
                                                    {
                                                        AssessorDetailId = ad.AssessorDetailId,
                                                        AssessorComapnyId = ad.AssessorCompanyId,
                                                        AssessorName = ad.AssessorName,
                                                        ContactDetails = ad.ContactDetails
                                                    }).ToList()
                             }).ToList();
            return assessors;
        }

        public async Task<IEnumerable<GetVehicleRegistrationCheckResponseDTO>> GetRegistrationCheckResponseAsync(SearchVehicleRegistrationCheckDTO searchVehicleRegistrationCheckDTO)
        {
            var data = await CollectionsAsync<GetVehicleRegistrationCheckResponseDTO>(StoreProcedures.CheckDuplicayForVehicleRegAndInsurerClaimNo, new { InsurerClaimNumber = searchVehicleRegistrationCheckDTO.InsurerClaimNumber, VehicleRegistrationNumber = searchVehicleRegistrationCheckDTO.VehicleRegistrationNumber });

            if (data.Max(x => x.IsDuplicateVehicleRegistrationNumber) > 0)
            {
                return data.Where(x => x.IsDuplicateVehicleRegistrationNumber > 0);
            }
            return Enumerable.Empty<GetVehicleRegistrationCheckResponseDTO>();
        }

        public IEnumerable<GetAllClaimsDTO> GetAllClaimList(SearchAllClaimsDTO searchAllClaimsDTO)
        {

            if (searchAllClaimsDTO.OrderBy != null)
            {
                searchAllClaimsDTO.OrderBy = char.ToUpper(searchAllClaimsDTO.OrderBy[0]) + searchAllClaimsDTO.OrderBy.Substring(1);
            }

            //var allDraftClaimsList = (from pbcd in _dbContext.PbClaimDrafts
            //                            join pbc in _dbContext.PbClients on pbcd.ClientId equals pbc.ClientId
            //                            where pbcd.SubmittedBy == null && pbcd.SubmittedDate == null && pbcd.IsDeleted == false && pbcd.ClientId.ToString() == searchAllClaimsDTO.ClientId
            //                          select new GetAllClaimsDTO()
            //                            {
            //                                ClaimId = pbcd.ClaimId,
            //                                ClientName = pbc.ClientName,
            //                                JobCardNo = pbcd.Ronumber,
            //                                PBFinalInvoiceNo = null,
            //                                DemoNo = null,
            //                                InsurerClaimNumber = pbcd.InsurerClaimNumber,
            //                                InsuredName = pbcd.InsuredName,
            //                                VehicleMake = pbcd.VehicleMake,
            //                                VehicleRegistrationNumber = pbcd.VehicleRegistrationNumber,
            //                                ClaimAmount = pbcd.ClaimAmount,
            //                                CreatedBy = pbcd.CreatedBy,
            //                                CreatedDate = pbcd.CreatedDate,
            //                                Status = pbcd.Status,
            //                            }).ToList();

            //// here we are getting data from requested claims
            //var allRequestClaimsList = (from pbcr in _dbContext.PbClaimRequests
            //                     join pbc in _dbContext.PbClients on pbcr.ClientId equals pbc.ClientId
            //                     join cr in (from c in _dbContext.PbClaimDrafts
            //                                 where c.SubmittedBy != null && c.SubmittedDate != null
            //                                 select c) on pbcr.ClaimId equals cr.ClaimId
            //                            where pbcr.ApprovedBy == null && pbcr.ApprovedDate == null && pbcr.ClientId.ToString() == searchAllClaimsDTO.ClientId
            //                            select new GetAllClaimsDTO()
            //                     {
            //                         ClaimId = pbcr.ClaimId,
            //                         ClientName = pbc.ClientName,
            //                         JobCardNo = pbcr.Ronumber,
            //                         PBFinalInvoiceNo = null,
            //                         DemoNo = null,
            //                         InsurerClaimNumber = pbcr.InsurerClaimNumber,
            //                         InsuredName = pbcr.InsuredName,
            //                         VehicleMake = pbcr.VehicleMake,
            //                         VehicleRegistrationNumber = pbcr.VehicleRegistrationNumber,
            //                         ClaimAmount = pbcr.ClaimAmount,
            //                         CreatedBy = pbcr.CreatedBy,
            //                         CreatedDate = pbcr.CreatedDate,
            //                         Status = "Submitted Pending Approval"
            //                     }).ToList();

            //// here we are getting data from authorized claims
            //var allAuthorizedClaimsList = (from pbcr in _dbContext.PbClaims
            //                     join pbc in _dbContext.PbClients on pbcr.ClientId equals pbc.ClientId
            //                     join cr in (from c in _dbContext.PbClaimRequests where c.ApprovedBy != null && c.ApprovedDate != null
            //                                 select c) on pbcr.ClaimId equals cr.ClaimId
            //                        where pbcr.ClientId.ToString() == searchAllClaimsDTO.ClientId
            //                               select new GetAllClaimsDTO()
            //                     {
            //                         ClaimId = pbcr.ClaimId,
            //                         ClientName = pbc.ClientName,
            //                         JobCardNo = pbcr.Ronumber,
            //                         PBFinalInvoiceNo = null,
            //                         DemoNo = pbcr.DemoNumber,
            //                         InsurerClaimNumber = pbcr.InsurerClaimNumber,
            //                         InsuredName = pbcr.InsuredName,
            //                         VehicleMake = pbcr.VehicleMake,
            //                         VehicleRegistrationNumber = pbcr.VehicleRegistrationNumber,
            //                         ClaimAmount = pbcr.ClaimAmount,
            //                         CreatedBy = pbcr.CreatedBy,
            //                         CreatedDate = pbcr.CreatedDate,
            //                         Status = pbcr.ClaimStatus
            //                     }).ToList();

            var allAuthorizedClaimsList = (from pbcr in _dbContext.PbClaims
                                           join pbc in _dbContext.PbClients on pbcr.ClientId equals pbc.ClientId
                                           where pbcr.ClientId.ToString() == searchAllClaimsDTO.ClientId
                                           select new GetAllClaimsDTO()
                                           {
                                               ClaimId = pbcr.ClaimId,
                                               ClientName = pbc.ClientName,
                                               JobCardNo = pbcr.Ronumber,
                                               PBFinalInvoiceNo = null,
                                               DemoNo = pbcr.DemoNumber,
                                               InsurerClaimNumber = pbcr.InsurerClaimNumber,
                                               InsuredName = pbcr.InsuredName,
                                               VehicleMake = pbcr.VehicleMake,
                                               VehicleRegistrationNumber = pbcr.VehicleRegistrationNumber,
                                               NetClaimAmount = pbcr.NetClaimAmount,
                                               TotalPartsValue = pbcr.TotalPartsValue,
                                               CreatedBy = pbcr.CreatedBy,
                                               CreatedDate = pbcr.CreatedDate,
                                               Status = pbcr.ClaimStatus
                                           }).ToList();

            var allRequestClaimsList = (from pbcr in _dbContext.PbClaimRequests
                                        join pbc in _dbContext.PbClients on pbcr.ClientId equals pbc.ClientId
                                        where pbcr.ApprovedBy == null && pbcr.ApprovedDate == null && pbcr.ClientId.ToString() == searchAllClaimsDTO.ClientId
                                        select new GetAllClaimsDTO()
                                        {
                                            ClaimId = pbcr.ClaimId,
                                            ClientName = pbc.ClientName,
                                            JobCardNo = pbcr.Ronumber,
                                            PBFinalInvoiceNo = null,
                                            DemoNo = null,
                                            InsurerClaimNumber = pbcr.InsurerClaimNumber,
                                            InsuredName = pbcr.InsuredName,
                                            VehicleMake = pbcr.VehicleMake,
                                            VehicleRegistrationNumber = pbcr.VehicleRegistrationNumber,
                                            NetClaimAmount = pbcr.NetClaimAmount,
                                            TotalPartsValue = pbcr.TotalPartsValue,
                                            CreatedBy = pbcr.CreatedBy,
                                            CreatedDate = pbcr.CreatedDate,
                                            Status = "Submitted Pending Approval"
                                        }).ToList();

            var allDraftClaimsList = (from pbcd in _dbContext.PbClaimDrafts
                                      join pbc in _dbContext.PbClients on pbcd.ClientId equals pbc.ClientId
                                      where pbcd.SubmittedBy == null && pbcd.SubmittedDate == null && pbcd.IsDeleted == false && pbcd.ClientId.ToString() == searchAllClaimsDTO.ClientId
                                      select new GetAllClaimsDTO()
                                      {
                                          ClaimId = pbcd.ClaimId,
                                          ClientName = pbc.ClientName,
                                          JobCardNo = pbcd.Ronumber,
                                          PBFinalInvoiceNo = null,
                                          DemoNo = null,
                                          InsurerClaimNumber = pbcd.InsurerClaimNumber,
                                          InsuredName = pbcd.InsuredName,
                                          VehicleMake = pbcd.VehicleMake,
                                          VehicleRegistrationNumber = pbcd.VehicleRegistrationNumber,
                                          NetClaimAmount = pbcd.NetClaimAmount,
                                          TotalPartsValue = pbcd.TotalPartsValue,
                                          CreatedBy = pbcd.CreatedBy,
                                          CreatedDate = pbcd.CreatedDate,
                                          Status = pbcd.Status,
                                      }).ToList();


            List<GetAllClaimsDTO> responseList = new();


            responseList.AddRange(allDraftClaimsList);
            responseList.AddRange(allRequestClaimsList);
            responseList.AddRange(allAuthorizedClaimsList);

            responseList = responseList.OrderByDescending(x => x.CreatedDate).ToList();
            var reponse = responseList.AsEnumerable<GetAllClaimsDTO>();

            SearchByName(ref reponse, searchAllClaimsDTO.SearchValue);

            if (searchAllClaimsDTO.OrderByDescending == true)
            {
                if (searchAllClaimsDTO.OrderBy != null)
                {
                    reponse = reponse.OrderByDescending(x => x.GetType().GetProperty(searchAllClaimsDTO.OrderBy).GetValue(x)).ToList();
                }
            }
            else
            {
                if (searchAllClaimsDTO.OrderBy != null)
                {
                    reponse = reponse.OrderBy(x => x.GetType().GetProperty(searchAllClaimsDTO.OrderBy).GetValue(x)).ToList();
                }
            }

            if (searchAllClaimsDTO.AllRecords)
                reponse = reponse.ToList();
            else
                reponse = reponse.Skip((searchAllClaimsDTO.PageNo - 1) * searchAllClaimsDTO.PageSize).Take(searchAllClaimsDTO.PageSize).ToList();

            return reponse;

        }

        private static void SearchByName(ref IEnumerable<GetAllClaimsDTO> responseList, string SearchValue)
        {
            if (!responseList.Any() || string.IsNullOrWhiteSpace(SearchValue))
                return;
            responseList = responseList.Where(o => (o.JobCardNo ?? "").ToString().ToLower().Contains(SearchValue.Trim().ToLower()) ||
            (o.InsurerClaimNumber ?? "" ).ToLower().Contains(SearchValue.Trim().ToLower()) ||
            (o.VehicleRegistrationNumber ?? "" ).ToLower().Contains(SearchValue.Trim().ToLower()) ||
            (o.InsuredName ?? "").ToLower().Contains(SearchValue.Trim().ToLower()) ||
            (o.Status ?? "").ToLower().Contains(SearchValue.Trim().ToLower()));
        }

        public async Task<AddClaimDraftResponseDTO> AddClaimDraftAsync(AddClaimDraftDTO addClaimDraftDTO)
        {
            Guid claimId = Guid.NewGuid();

            // here we adding assessor details

            //var dataCompany = (from s in _dbContext.PbAssessorCompanies
            //                   where s.CompanyName == addClaimDraftDTO.AssessorCompany
            //                   select s).FirstOrDefault();

            //if (dataCompany != null)
            //{
            //    if (addClaimDraftDTO.Assessor != "")
            //    {
            //        var dataAssessor = (from s in _dbContext.PbAssessorDetails
            //                            where s.AssessorCompanyId == dataCompany.AssessorCompanyId
            //                            && s.AssessorName == addClaimDraftDTO.Assessor
            //                            select s).FirstOrDefault();
            //        //if the person exists then update the contact details
            //        if (dataAssessor != null)
            //        {
            //            if (addClaimDraftDTO.AssessorContactDetails != null && addClaimDraftDTO.AssessorContactDetails != "")
            //            {
            //                dataAssessor.ContactDetails = addClaimDraftDTO.AssessorContactDetails;

            //                _dbContext.PbAssessorDetails.Update(dataAssessor);
            //                await _dbContext.SaveChangesAsync();
            //            }
            //        }
            //        else //the person doesnt exist and therefore has to be created
            //        {

            //            var assesorDetailsToAdd = new PbAssessorDetail()
            //            {
            //                AssessorDetailId = Guid.NewGuid(),
            //                AssessorCompanyId = dataCompany.AssessorCompanyId,
            //                AssessorName = addClaimDraftDTO.Assessor,
            //                CreatedBy = addClaimDraftDTO.ActionPerformedBy,
            //                CreatedDate = DateTime.Now
            //            };

            //            if (addClaimDraftDTO.AssessorContactDetails != null && addClaimDraftDTO.AssessorContactDetails != "")
            //            {
            //                assesorDetailsToAdd.ContactDetails = addClaimDraftDTO.AssessorContactDetails;
            //            }

            //            await _dbContext.PbAssessorDetails.AddAsync(assesorDetailsToAdd);
            //            await _dbContext.SaveChangesAsync();
            //        }
            //    }
            //}
            //else //if the company doesnt exist it needs to be created
            //{
            //    var assessorCompanyToAdd = new PbAssessorCompany()
            //    {
            //        AssessorCompanyId = Guid.NewGuid(),
            //        CompanyName = addClaimDraftDTO.AssessorCompany,
            //        CreatedBy = addClaimDraftDTO.ActionPerformedBy,
            //        CreatedDate = DateTime.Now
            //    };

            //    await _dbContext.PbAssessorCompanies.AddAsync(assessorCompanyToAdd);

            //    var assessorDetailsToAdd = new PbAssessorDetail()
            //    {
            //        AssessorDetailId = Guid.NewGuid(),
            //        AssessorCompanyId = assessorCompanyToAdd.AssessorCompanyId,
            //        AssessorName = addClaimDraftDTO.Assessor,
            //        CreatedBy = addClaimDraftDTO.ActionPerformedBy,
            //        CreatedDate = DateTime.Now,
            //    };

            //    if (addClaimDraftDTO.AssessorContactDetails != null && addClaimDraftDTO.AssessorContactDetails != "")
            //    {
            //        assessorDetailsToAdd.ContactDetails = addClaimDraftDTO.AssessorContactDetails;
            //    }

            //    await _dbContext.PbAssessorDetails.AddAsync(assessorDetailsToAdd);

            //    await _dbContext.SaveChangesAsync();
            //}

            // here we are checking registration Number and Insurer number already exists or not

            //if (!addClaimDraftDTO.ClaimIsNotADuplicate)
            //{
            //    var data = await CollectionsAsync<GetVehicleRegistrationCheckResponseDTO>(StoreProcedures.CheckDuplicayForVehicleRegAndInsurerClaimNo, new { InsurerClaimNumber = addClaimDraftDTO.InsurerClaimNumber, VehicleRegistrationNumber = addClaimDraftDTO.VehicleRegistrationNumber });

            //    if(data.Any())
            //    {
            //        if (data.Max(x => x.IsDuplicateVehicleRegistrationNumber) > 0)
            //        {
            //            throw new Exception(ResponseMessages.VehicleRegistrationAlreadyInUse);
            //        }
            //    }
            //}


            //var InsurerClaimNo = _dbContext.PbInsurers.Where(i => i.InsurerId.ToString() == addClaimDraftDTO.InsurerId).Select(x => new { x.ClaimNoPrefixText, x.ClaimNoSufixText }).FirstOrDefault();
            //if (!String.IsNullOrEmpty(InsurerClaimNo.ClaimNoPrefixText))
            //{
            //    if (addClaimDraftDTO.InsurerClaimNumber.Contains(InsurerClaimNo.ClaimNoPrefixText))
            //    {
            //        throw new Exception(ResponseMessages.ClaimNumberPrefixIncorrect + InsurerClaimNo.ClaimNoPrefixText);
            //    }
            //}
            //if (!String.IsNullOrEmpty(InsurerClaimNo.ClaimNoSufixText))
            //{
            //    if (addClaimDraftDTO.InsurerClaimNumber.Contains(InsurerClaimNo.ClaimNoSufixText))
            //    {
            //        throw new Exception(ResponseMessages.ClaimNumberSuffixIncorrect + InsurerClaimNo.ClaimNoSufixText);
            //    }
            //}

            var cliamDraftToAdd = new PbClaimDraft
            {
                ClaimDraftId = Guid.NewGuid(),
                ClaimId = claimId,
                ClientId = Guid.Parse(addClaimDraftDTO.ClientId),
                InsurerId = Guid.Parse(addClaimDraftDTO.InsurerId),
                InsurerClaimNumber = addClaimDraftDTO.InsurerClaimNumber,
                VehicleRegistrationNumber = addClaimDraftDTO.VehicleRegistrationNumber,
                VehicleMake = addClaimDraftDTO.VehicleMake,
                VehicleModel = addClaimDraftDTO.VehicleModel,
                InsuredName = addClaimDraftDTO.InsuredName,
                InsuredPhoneNumber = addClaimDraftDTO.InsuredPhoneNumber,
                TotalPartsValue = addClaimDraftDTO.TotalPartsValue,
                //InsurerLiaisonPerson = addClaimDraftDTO.InsurerLiaisonPerson,
                Labour = addClaimDraftDTO.Labour,
                NetClaimAmount = addClaimDraftDTO.NetClaimAmount,
                Paint = addClaimDraftDTO.Paint,
                Year = addClaimDraftDTO.Year,
                VINNumber = addClaimDraftDTO.VINNumber,
                ClaimPartsValue = addClaimDraftDTO.ClaimPartsValue,
                ClaimAmount = addClaimDraftDTO.ClaimAmount,
                ClaimExcess = addClaimDraftDTO.ClaimExcess,
                Ronumber = addClaimDraftDTO.JobCardNo,
                EstimatedDaysToCompleted = addClaimDraftDTO.EstimatedDaysToComplete,
                CreatedBy = addClaimDraftDTO.ActionPerformedBy,
                CreatedDate = DateTime.Now,
                Status = "Not Submitted",
                //EstimatedBookInDate = addClaimDraftDTO.EstimatedBookInDate
            };


            foreach(var partSupplier in addClaimDraftDTO.SupplierPartDetails)
            {
                var supplierId = Guid.Parse(partSupplier.SupplierId);
                var claimPartSupplierId = Guid.NewGuid();
                var partSupplierToAdd = new PbClaimPartSupplier()
                {
                    ClaimPartSupplierId = claimPartSupplierId,
                    ClaimId = claimId,
                    SupplierId = supplierId,
                    SupplierTotal = partSupplier.SupplierTotal,
                    CreatedBy = addClaimDraftDTO.ActionPerformedBy,
                    CreatedDate = DateTime.Now
                };

                await _dbContext.PbClaimPartSuppliers.AddAsync(partSupplierToAdd);

                foreach (var part in partSupplier.PartDetails)
                {
                    var partInDb = _dbContext.PbSupplierParts.Where(x => x.SupplierId == supplierId && x.PartName == part.PartName && x.IsDeleted == false).FirstOrDefault();
                    if(partInDb == null)
                    {
                        var partToAdd = new PbSupplierPart()
                        {
                            SupplierPartId = Guid.NewGuid(),
                            SupplierId = supplierId,
                            PartName = part.PartName,
                            Price = part.Price,
                            PartId = Guid.NewGuid(),
                            CreatedBy = addClaimDraftDTO.ActionPerformedBy,
                            CreatedDate = DateTime.Now
                        };

                        await _dbContext.PbSupplierParts.AddAsync(partToAdd);
                    }

                    var supplierPartToAdd = new PbClaimSupplierPart()
                    {
                        ClaimSupplierPartId = Guid.NewGuid(),
                        ClaimPartSupplierId = claimPartSupplierId,
                        PartName = part.PartName,
                        Price = part.Price,
                        CreatedBy = addClaimDraftDTO.ActionPerformedBy,
                        CreatedDate = DateTime.Now

                    };

                    await _dbContext.PbClaimSupplierParts.AddAsync(supplierPartToAdd);

                }
            }

            //if (addClaimDraftDTO.NoParts)
            //{
            //    cliamDraftToAdd.InvoiceType = "No Parts";
            //}
            //else
            //{
            //    cliamDraftToAdd.InvoiceType = "Parts Only";
            //}

            //string InsurerType = (from s in _dbContext.Lookups
            //                      join x in _dbContext.PbInsurers on s.LookupId equals x.InsurerTypeId
            //                      where x.InsurerId.ToString() == addClaimDraftDTO.InsurerId
            //                      select s.Description).FirstOrDefault();
            //if (InsurerType == "Self Insured" || InsurerType == "Commercial Insurer")
            //{
            //    cliamDraftToAdd.InsurerIdsecondary = Guid.Parse(addClaimDraftDTO.InsurerId);
            //}
            //else
            //{
            //    if (cliamDraftToAdd.InsurerId != Guid.Parse(addClaimDraftDTO.InsurerId))
            //    {
            //        cliamDraftToAdd.InsurerId = Guid.Parse(addClaimDraftDTO.InsurerId);
            //    }
            //}

            await _dbContext.PbClaimDrafts.AddAsync(cliamDraftToAdd);

            var claimLog = new PbClaimLog
            {
                ClaimLogId = Guid.NewGuid(),
                ClaimId = claimId,
                Category = "Claims",
                Description = "Panel beater Claim Draft created by " + addClaimDraftDTO.ActionPerformedBy,
                CreatedBy = addClaimDraftDTO.ActionPerformedBy,
                CreatedDate = DateTime.Now
            };

            await _dbContext.PbClaimLogs.AddAsync(claimLog);

            //if (addClaimDraftDTO.ClaimDraftSuppliers.Count > 0)
            //{
            //    foreach (var supplier in addClaimDraftDTO.ClaimDraftSuppliers)
            //    {
            //        var supplierToAdd = new PbClaimDraftSupplier
            //        {
            //            ClaimDraftSupplierId = Guid.NewGuid(),
            //            ClaimDraftId = cliamDraftToAdd.ClaimDraftId,
            //            SupplierId = Guid.Parse(supplier.SupplierId),
            //            CreatedBy = addClaimDraftDTO.ActionPerformedBy,
            //            CreatedDate = DateTime.Now
            //        };

            //        await _dbContext.PbClaimDraftSuppliers.AddAsync(supplierToAdd);
            //    }
            //}

            if (_dbContext.PbClaims.Where(x => x.InsurerId.ToString() == addClaimDraftDTO.InsurerId && x.InsurerClaimNumber == addClaimDraftDTO.InsurerClaimNumber).Any())
            {
                throw new Exception(ResponseMessages.InsurerClaimNumberAlreadyInUse);
            }

            await _dbContext.SaveChangesAsync();

            return new AddClaimDraftResponseDTO()
            {
                KeyId = 1,
                ResponseCode = ResponseCode.Success,
                ResponseMessage = ResponseMessages.ClaimDraftSaved,
                ClaimId = claimId.ToString()
            };
        }

        public async Task<ResponseDTO> DeleteClaimAsync(DeleteClaimDTO deleteClaimDTO)
        {
            var claimDraftToDelete = _dbContext.PbClaimDrafts.Where(x => x.ClaimId.ToString() == deleteClaimDTO.ClaimId && x.SubmittedBy == null && x.SubmittedDate == null).FirstOrDefault();

            var claimRequestToDelete = _dbContext.PbClaimRequests.Where(x => x.ClaimId.ToString() == deleteClaimDTO.ClaimId && x.ApprovedBy == null && x.ApprovedDate == null).FirstOrDefault();

            var declinedClaimToDelete = _dbContext.PbClaims.Where(x => x.ClaimId.ToString() == deleteClaimDTO.ClaimId && x.ClaimStatus == "Declined Claim").FirstOrDefault();

            if(claimDraftToDelete != null)
            {
                claimDraftToDelete.IsDeleted = true;
                claimDraftToDelete.DeletedBy = deleteClaimDTO.ActionPerformedBy;
                claimDraftToDelete.DeletedDate = DateTime.Now;

                _dbContext.PbClaimDrafts.Update(claimDraftToDelete);

                await _dbContext.SaveChangesAsync();

                return new ResponseDTO()
                {
                    KeyId = 1,
                    ResponseCode = ResponseCode.Success,
                    ResponseMessage = ResponseMessages.ClaimDraftDeleted
                };
            }
            else if (claimRequestToDelete != null)
            {
                _dbContext.PbClaimRequests.Remove(claimRequestToDelete);
                await _dbContext.SaveChangesAsync();

                return new ResponseDTO()
                {
                    KeyId = 1,
                    ResponseCode = ResponseCode.Success,
                    ResponseMessage = ResponseMessages.RequestedClaimDeleted
                };
            }
            else if (declinedClaimToDelete != null)
            {
                _dbContext.PbClaims.Remove(declinedClaimToDelete);
                await _dbContext.SaveChangesAsync();

                return new ResponseDTO()
                {
                    KeyId = 1,
                    ResponseCode = ResponseCode.Success,
                    ResponseMessage = ResponseMessages.DeclinedClaimDeleted
                };
            }
            else
            {
                throw new Exception(ResponseMessages.NoClaimExists);
            }
        }

        public GetClaimsDetailDTO GetClaimsDetail(SearchClaimsDetailDTO searchClaimsDetailDTO)
        {
            var claimDraft = _dbContext.PbClaimDrafts.Where(x => x.ClaimId.ToString() == searchClaimsDetailDTO.ClaimId && x.SubmittedBy == null && x.SubmittedDate == null).Select(x => x).FirstOrDefault();

            if(claimDraft != null)
            {
                var claimDraftData = (from c in _dbContext.PbClaimDrafts
                                      join i in _dbContext.PbInsurers
                                      on c.InsurerId equals i.InsurerId
                                      join pbc in _dbContext.PbClients
                                      on c.ClientId equals pbc.ClientId
                                      where c.ClaimId.ToString() == searchClaimsDetailDTO.ClaimId
                                      select new GetClaimsDetailDTO()
                                      {
                                          Id = c.ClaimDraftId,
                                          ClaimId = c.ClaimId,
                                          ClientId = pbc.ClientId,
                                          InsurerId = c.InsurerId,
                                          InsurerName = i.InsurerName,
                                          ClientName = pbc.ClientName,
                                          ClientTradingName = pbc.ClientTradingName,
                                          PrimaryInsurer = i.InsurerName,
                                          ClaimNumber = c.InsurerClaimNumber,
                                          InsurerClaimNumber = c.InsurerClaimNumber,
                                          VehicleRegistrationNumber = c.VehicleRegistrationNumber,
                                          VehicleMake = c.VehicleMake,
                                          VehicleModel = c.VehicleModel,
                                          InsurerLiaisonPerson = c.InsurerLiaisonPerson,
                                          DemoNumber = null,
                                          Year = c.Year,
                                          Labour = c.Labour,
                                          TotalPartsValue = c.TotalPartsValue,
                                          NetClaimAmount = c.NetClaimAmount,
                                          VINNumber = c.VINNumber,
                                          EstimatedBookInDate = c.EstimatedBookInDate,
                                          Paint = c.Paint,
                                          InsuredName = c.InsuredName,
                                          InsuredPhoneNumber = c.InsuredPhoneNumber,
                                          ClaimAmount = c.ClaimAmount,
                                          JobCardNo = c.Ronumber,
                                          ClaimExcess = c.ClaimExcess,
                                          ClaimPartsValue = c.ClaimPartsValue,
                                          InvoiceType = c.InvoiceType,
                                          CreatedDate = c.CreatedDate,
                                          EstimatedDaysToComplete = c.EstimatedDaysToCompleted,
                                          Suppliers = (from cs in _dbContext.PbClaimDraftSuppliers
                                                       join s in _dbContext.PbSuppliers on cs.SupplierId equals s.SupplierId
                                                        where cs.ClaimDraftId == c.ClaimDraftId
                                                        select new ClaimSuppliers()
                                                        {
                                                            SupplierId = cs.SupplierId,
                                                            SupplierName = s.SupplierName
                                                        }).ToList(),
                                          SupplierPartDetails = (from cps in _dbContext.PbClaimPartSuppliers
                                                                 join s in _dbContext.PbSuppliers on cps.SupplierId equals s.SupplierId
                                                                 where cps.ClaimId == c.ClaimId && cps.IsDeleted == false
                                                                 select new SupplierPart()
                                                                 {
                                                                     ClaimPartSupplierId = cps.ClaimPartSupplierId,
                                                                     SupplierId = cps.SupplierId,
                                                                     SupplierName = s.SupplierName,
                                                                     SupplierTotal = cps.SupplierTotal,
                                                                     IsPartSupplierDeleted = false,
                                                                     PartDetails = (from  csp in _dbContext.PbClaimSupplierParts 
                                                                                    where csp.ClaimPartSupplierId == cps.ClaimPartSupplierId && csp.IsDeleted == false
                                                                                    select new Part()
                                                                                    {
                                                                                        ClaimSupplierPartId = csp.ClaimSupplierPartId,
                                                                                        PartName = csp.PartName,
                                                                                        Price = csp.Price,
                                                                                        IsDeleted = false
                                                                                    }).ToList()

                                                                 }).ToList()

                                      }).FirstOrDefault();

                return claimDraftData;
            }

            var declinedClaim = _dbContext.PbClaims.Where(x => x.ClaimId.ToString() == searchClaimsDetailDTO.ClaimId && x.ClaimStatus == "Declined Claim").Select(x => x).FirstOrDefault();

            var approvedClaim = _dbContext.PbClaims.Where(x => x.ClaimId.ToString() == searchClaimsDetailDTO.ClaimId && (x.ClaimStatus == "Accepted" || x.ClaimStatus == "Claim Approved")).Select(x => x).FirstOrDefault();


            if (declinedClaim != null || approvedClaim != null)
            {
                var ClaimData = (from c in _dbContext.PbClaims
                                       join i in _dbContext.PbInsurers
                                      on c.InsurerId equals i.InsurerId
                                      join pbc in _dbContext.PbClients
                                      on c.ClientId equals pbc.ClientId
                                      where c.ClaimId.ToString() == searchClaimsDetailDTO.ClaimId
                                      select new GetClaimsDetailDTO()
                                      {
                                          Id = c.ClaimId,
                                          ClaimId = c.ClaimId,
                                          ClientId = pbc.ClientId,
                                          InsurerId = c.InsurerId,
                                          InsurerName = i.InsurerName,
                                          ClientName = pbc.ClientName,
                                          ClientTradingName = pbc.ClientTradingName,
                                          PrimaryInsurer = i.InsurerName,
                                          InsurerClaimNumber = c.InsurerClaimNumber,
                                          InsurerLiaisonPerson = c.InsurerLiaisonPerson,
                                          VehicleRegistrationNumber = c.VehicleRegistrationNumber,
                                          VehicleMake = c.VehicleMake,
                                          VehicleModel = c.VehicleModel,
                                          DemoNumber = c.DemoNumber,
                                          Year = c.Year,
                                          Labour = c.Labour,
                                          TotalPartsValue = c.TotalPartsValue,
                                          NetClaimAmount = c.NetClaimAmount,
                                          Paint = c.Paint,
                                          VINNumber = c.VINNumber,
                                          EstimatedBookInDate = c.EstimatedBookInDate,
                                          InsuredName = c.InsuredName,
                                          InsuredPhoneNumber = c.InsuredPhoneNumber,
                                          ClaimAmount = c.ClaimAmount,
                                          JobCardNo = c.Ronumber,
                                          ClaimExcess = c.ClaimExcess,
                                          ClaimPartsValue = c.ClaimPartsValue,
                                          InvoiceType = c.InvoiceType,
                                          CreatedDate = c.CreatedDate,
                                          EstimatedDaysToComplete = c.EstimatedDaysToComplete,
                                          Suppliers = (from cs in _dbContext.PbClaimSuppliers
                                                       join s in _dbContext.PbSuppliers on cs.SupplierId equals s.SupplierId
                                                       where cs.ClaimId == c.ClaimId 
                                                       select new ClaimSuppliers()
                                                       {
                                                           SupplierId = cs.SupplierId,
                                                           SupplierName = s.SupplierName
                                                       }).ToList(),
                                        SupplierPartDetails = (from cps in _dbContext.PbClaimPartSuppliers
                                                               join s in _dbContext.PbSuppliers on cps.SupplierId equals s.SupplierId
                                                               where cps.ClaimId == c.ClaimId && cps.IsDeleted == false
                                                               select new SupplierPart()
                                                               {
                                                                   ClaimPartSupplierId = cps.ClaimPartSupplierId,
                                                                   SupplierId = cps.SupplierId,
                                                                   SupplierName = s.SupplierName,
                                                                   SupplierTotal = cps.SupplierTotal,
                                                                   IsPartSupplierDeleted = false,
                                                                   PartDetails = (from csp in _dbContext.PbClaimSupplierParts
                                                                                  where csp.ClaimPartSupplierId == cps.ClaimPartSupplierId && csp.IsDeleted == false
                                                                                  select new Part()
                                                                                  {
                                                                                      ClaimSupplierPartId = csp.ClaimSupplierPartId,
                                                                                      PartName = csp.PartName,
                                                                                      Price = csp.Price,
                                                                                      IsDeleted = false
                                                                                  }).ToList()

                                                               }).ToList()

                                      }).FirstOrDefault();

                return ClaimData;
            }


            

            if(claimDraft == null && declinedClaim == null || approvedClaim == null)
            {
                throw new Exception(ResponseMessages.NoClaimExists);
            }

            return new GetClaimsDetailDTO();

        }

        public async Task<ResponseDTO> UpdateClaimDraftAsync(UpdateClaimDraftDTO updateClaimDraftDTO)
        {
            var claimDraftToUpdate = _dbContext.PbClaimDrafts.Where(x => x.ClaimDraftId.ToString() == updateClaimDraftDTO.ClaimDraftId && x.SubmittedBy == null && x.SubmittedDate == null).FirstOrDefault();

            //SaveAssessorDetails(updateClaimDraftDTO.AssessorCompany, updateClaimDraftDTO.Assessor, updateClaimDraftDTO.AssessorContactDetails, updateClaimDraftDTO.ActionPerformedBy);

            //var dataCompany = (from s in _dbContext.PbAssessorCompanies
            //                   where s.CompanyName == updateClaimDraftDTO.AssessorCompany
            //                   select s).FirstOrDefault();

            //if (dataCompany != null)
            //{
            //    if (updateClaimDraftDTO.Assessor != "")
            //    {
            //        var dataAssessor = (from s in _dbContext.PbAssessorDetails
            //                            where s.AssessorCompanyId == dataCompany.AssessorCompanyId
            //                            && s.AssessorName == updateClaimDraftDTO.Assessor
            //                            select s).FirstOrDefault();
            //        //if the person exists then update the contact details
            //        if (dataAssessor != null)
            //        {
            //            if (updateClaimDraftDTO.AssessorContactDetails != null && updateClaimDraftDTO.AssessorContactDetails != "")
            //            {
            //                dataAssessor.ContactDetails = updateClaimDraftDTO.AssessorContactDetails;

            //                _dbContext.PbAssessorDetails.Update(dataAssessor);
            //                await _dbContext.SaveChangesAsync();
            //            }
            //        }
            //        else //the person doesnt exist and therefore has to be created
            //        {

            //            var assesorDetailsToAdd = new PbAssessorDetail()
            //            {
            //                AssessorDetailId = Guid.NewGuid(),
            //                AssessorCompanyId = dataCompany.AssessorCompanyId,
            //                AssessorName = updateClaimDraftDTO.Assessor,
            //                CreatedBy = updateClaimDraftDTO.ActionPerformedBy,
            //                CreatedDate = DateTime.Now
            //            };

            //            if (updateClaimDraftDTO.AssessorContactDetails != null && updateClaimDraftDTO.AssessorContactDetails != "")
            //            {
            //                assesorDetailsToAdd.ContactDetails = updateClaimDraftDTO.AssessorContactDetails;
            //            }

            //            await _dbContext.PbAssessorDetails.AddAsync(assesorDetailsToAdd);
            //            await _dbContext.SaveChangesAsync();
            //        }
            //    }
            //}
            //else //if the company doesnt exist it needs to be created
            //{
            //    var assessorCompanyToAdd = new PbAssessorCompany()
            //    {
            //        AssessorCompanyId = Guid.NewGuid(),
            //        CompanyName = updateClaimDraftDTO.AssessorCompany,
            //        CreatedBy = updateClaimDraftDTO.ActionPerformedBy,
            //        CreatedDate = DateTime.Now
            //    };

            //    await _dbContext.PbAssessorCompanies.AddAsync(assessorCompanyToAdd);

            //    var assessorDetailsToAdd = new PbAssessorDetail()
            //    {
            //        AssessorDetailId = Guid.NewGuid(),
            //        AssessorCompanyId = assessorCompanyToAdd.AssessorCompanyId,
            //        AssessorName = updateClaimDraftDTO.Assessor,
            //        CreatedBy = updateClaimDraftDTO.ActionPerformedBy,
            //        CreatedDate = DateTime.Now,
            //    };

            //    if (updateClaimDraftDTO.AssessorContactDetails != null && updateClaimDraftDTO.AssessorContactDetails != "")
            //    {
            //        assessorDetailsToAdd.ContactDetails = updateClaimDraftDTO.AssessorContactDetails;
            //    }

            //    await _dbContext.PbAssessorDetails.AddAsync(assessorDetailsToAdd);

            //    await _dbContext.SaveChangesAsync();
            //}


            //if (!updateClaimDraftDTO.ClaimIsNotADuplicate)
            //{
            //    var data = await CollectionsAsync<GetVehicleRegistrationCheckResponseDTO>(StoreProcedures.CheckDuplicayForVehicleRegAndInsurerClaimNo, new { InsurerClaimNumber = updateClaimDraftDTO.InsurerClaimNumber, VehicleRegistrationNumber = updateClaimDraftDTO.VehicleRegistrationNumber });

            //    if (data.Any())
            //    {
            //        if (data.Max(x => x.IsDuplicateVehicleRegistrationNumber) > 0)
            //        {
            //            throw new Exception(ResponseMessages.VehicleRegistrationAlreadyInUse);
            //        }
            //    }
            //}

            //var InsurerClaimNo = _dbContext.PbInsurers.Where(i => i.InsurerId.ToString() == updateClaimDraftDTO.InsurerId).Select(x => new { x.ClaimNoPrefixText, x.ClaimNoSufixText }).FirstOrDefault();
            //if (!String.IsNullOrEmpty(InsurerClaimNo.ClaimNoPrefixText))
            //{
            //    if (updateClaimDraftDTO.InsurerClaimNumber.Contains(InsurerClaimNo.ClaimNoPrefixText))
            //    {
            //        throw new Exception(ResponseMessages.ClaimNumberPrefixIncorrect + InsurerClaimNo.ClaimNoPrefixText);
            //    }
            //}
            //if (!String.IsNullOrEmpty(InsurerClaimNo.ClaimNoSufixText))
            //{
            //    if (updateClaimDraftDTO.InsurerClaimNumber.Contains(InsurerClaimNo.ClaimNoSufixText))
            //    {
            //        throw new Exception(ResponseMessages.ClaimNumberSuffixIncorrect + InsurerClaimNo.ClaimNoSufixText);
            //    }
            //}


            claimDraftToUpdate.ClientId = Guid.Parse(updateClaimDraftDTO.ClientId);
            claimDraftToUpdate.InsurerId = Guid.Parse(updateClaimDraftDTO.InsurerId);
            claimDraftToUpdate.InsurerClaimNumber = updateClaimDraftDTO.InsurerClaimNumber;
            claimDraftToUpdate.VehicleRegistrationNumber = updateClaimDraftDTO.VehicleRegistrationNumber;
            claimDraftToUpdate.VehicleMake = updateClaimDraftDTO.VehicleMake;
            claimDraftToUpdate.VehicleModel = updateClaimDraftDTO.VehicleModel;
            claimDraftToUpdate.InsuredName = updateClaimDraftDTO.InsuredName;
            claimDraftToUpdate.InsuredPhoneNumber = updateClaimDraftDTO.InsuredPhoneNumber;
            //claimDraftToUpdate.InsurerLiaisonPerson = updateClaimDraftDTO.InsurerLiaisonPerson;
            claimDraftToUpdate.Labour = updateClaimDraftDTO.Labour;
            claimDraftToUpdate.TotalPartsValue = updateClaimDraftDTO.TotalPartsValue;
            claimDraftToUpdate.Paint = updateClaimDraftDTO.Paint;
            claimDraftToUpdate.NetClaimAmount = updateClaimDraftDTO.NetClaimAmount;
            claimDraftToUpdate.Year = updateClaimDraftDTO.Year;
            claimDraftToUpdate.VINNumber = updateClaimDraftDTO.VINNumber;
            claimDraftToUpdate.ClaimPartsValue = updateClaimDraftDTO.ClaimPartsValue;
            claimDraftToUpdate.ClaimAmount = updateClaimDraftDTO.ClaimAmount;
            claimDraftToUpdate.ClaimExcess = updateClaimDraftDTO.ClaimExcess;
            claimDraftToUpdate.Ronumber = updateClaimDraftDTO.JobCardNo;
            claimDraftToUpdate.EstimatedDaysToCompleted = updateClaimDraftDTO.EstimatedDaysToComplete;
            claimDraftToUpdate.ModifiedBy = updateClaimDraftDTO.ActionPerformedBy;
            claimDraftToUpdate.ModifiedDate = DateTime.Now;
            claimDraftToUpdate.CreatedDate = DateTime.Now;
            claimDraftToUpdate.Status = "Not Submitted";
            //claimDraftToUpdate.EstimatedBookInDate = updateClaimDraftDTO.EstimatedBookInDate;

            //if (updateClaimDraftDTO.NoParts)
            //{
            //    claimDraftToUpdate.InvoiceType = "No Parts";
            //}
            //else
            //{
            //    claimDraftToUpdate.InvoiceType = "Parts Only";
            //}

            //string InsurerType = (from s in _dbContext.Lookups
            //                        join x in _dbContext.PbInsurers on s.LookupId equals x.InsurerTypeId
            //                        where x.InsurerId.ToString() == updateClaimDraftDTO.InsurerId
            //                        select s.Description).FirstOrDefault();
            //if (InsurerType == "Self Insured" || InsurerType == "Commercial Insurer")
            //{
            //    claimDraftToUpdate.InsurerIdsecondary = Guid.Parse(updateClaimDraftDTO.InsurerId);
            //}
            //else
            //{
            //    if (claimDraftToUpdate.InsurerId != Guid.Parse(updateClaimDraftDTO.InsurerId))
            //    {
            //        claimDraftToUpdate.InsurerId = Guid.Parse(updateClaimDraftDTO.InsurerId);
            //    }
            //}

            //_dbContext.PbClaimDrafts.Update(claimDraftToUpdate);

            foreach (var partSupplier in updateClaimDraftDTO.SupplierPartDetails)
            {
                var supplierId = Guid.Parse(partSupplier.SupplierId);
                
                if(partSupplier.ClaimPartSupplierId != null && partSupplier.ClaimPartSupplierId != "" && partSupplier.IsPartSupplierDeleted == true)
                {
                    var claimPartSupplierToDelete = _dbContext.PbClaimPartSuppliers.Where(x => x.ClaimPartSupplierId.ToString() == partSupplier.ClaimPartSupplierId && x.IsDeleted == false).FirstOrDefault();

                    claimPartSupplierToDelete.IsDeleted = true;
                    claimPartSupplierToDelete.DeletedBy = updateClaimDraftDTO.ActionPerformedBy;
                    claimPartSupplierToDelete.DeletedDate = DateTime.Now;

                    _dbContext.PbClaimPartSuppliers.Update(claimPartSupplierToDelete);

                }
                else if(partSupplier.ClaimPartSupplierId != null && partSupplier.ClaimPartSupplierId != "" && partSupplier.IsPartSupplierDeleted == false)
                {
                    var claimPartSupplierToUpdate = _dbContext.PbClaimPartSuppliers.Where(x => x.ClaimPartSupplierId.ToString() == partSupplier.ClaimPartSupplierId && x.IsDeleted == false).FirstOrDefault();
                    if(claimPartSupplierToUpdate != null)
                    {
                        claimPartSupplierToUpdate.SupplierTotal = partSupplier.SupplierTotal;
                        claimPartSupplierToUpdate.ModifiedBy = updateClaimDraftDTO.ActionPerformedBy;
                        claimPartSupplierToUpdate.ModifiedDate = DateTime.Now;

                        _dbContext.PbClaimPartSuppliers.Update(claimPartSupplierToUpdate);

                        foreach (var part in partSupplier.PartDetails)
                        {
                            if(part.ClaimSupplierPartId == null)
                            {
                                var partInDb = _dbContext.PbSupplierParts.Where(x => x.SupplierId == supplierId && x.PartName == part.PartName && x.IsDeleted == false).FirstOrDefault();

                                if (partInDb == null)
                                {
                                    var partToAdd = new PbSupplierPart()
                                    {
                                        SupplierPartId = Guid.NewGuid(),
                                        SupplierId = supplierId,
                                        PartName = part.PartName,
                                        Price = part.Price,
                                        PartId = Guid.NewGuid(),
                                        CreatedBy = updateClaimDraftDTO.ActionPerformedBy,
                                        CreatedDate = DateTime.Now
                                    };

                                    await _dbContext.PbSupplierParts.AddAsync(partToAdd);
                                }

                                var supplierPartToAdd = new PbClaimSupplierPart()
                                {
                                    ClaimSupplierPartId = Guid.NewGuid(),
                                    ClaimPartSupplierId = claimPartSupplierToUpdate.ClaimPartSupplierId,
                                    PartName = part.PartName,
                                    Price = part.Price,
                                    CreatedBy = updateClaimDraftDTO.ActionPerformedBy,
                                    CreatedDate = DateTime.Now

                                };

                                await _dbContext.PbClaimSupplierParts.AddAsync(supplierPartToAdd);
                            }
                            else if(part.ClaimSupplierPartId != null && part.IsDeleted == false)
                            {
                                var supplierPartToUpdate = _dbContext.PbClaimSupplierParts.Where(x => x.ClaimSupplierPartId.ToString() == part.ClaimSupplierPartId && x.IsDeleted == false).FirstOrDefault();
                                if (supplierPartToUpdate != null)
                                {
                                    supplierPartToUpdate.PartName = part.PartName;
                                    supplierPartToUpdate.Price = part.Price;
                                    supplierPartToUpdate.ModifiedBy = updateClaimDraftDTO.ActionPerformedBy;
                                    supplierPartToUpdate.ModifiedDate = DateTime.Now;

                                    _dbContext.PbClaimSupplierParts.Update(supplierPartToUpdate);

                                }
                            }
                            else if(part.ClaimSupplierPartId != null && part.IsDeleted == true)
                            {
                                var supplierPartToDelete = _dbContext.PbClaimSupplierParts.Where(x => x.ClaimSupplierPartId.ToString() == part.ClaimSupplierPartId && x.IsDeleted == false).FirstOrDefault();
                                if(supplierPartToDelete != null)
                                {
                                    supplierPartToDelete.IsDeleted = true;
                                    supplierPartToDelete.DeletedBy = updateClaimDraftDTO.ActionPerformedBy;
                                    supplierPartToDelete.DeletedDate = DateTime.Now;

                                    _dbContext.PbClaimSupplierParts.Update(supplierPartToDelete);

                                }
                            }
                            
                        }
                    }      
                }
                else
                {
                    var claimPartSupplierId = Guid.NewGuid();

                    var partSupplierToAdd = new PbClaimPartSupplier()
                    {
                        ClaimPartSupplierId = claimPartSupplierId,
                        ClaimId = claimDraftToUpdate.ClaimId,
                        SupplierId = supplierId,
                        SupplierTotal = partSupplier.SupplierTotal,
                        CreatedBy = updateClaimDraftDTO.ActionPerformedBy,
                        CreatedDate = DateTime.Now
                    };

                    await _dbContext.PbClaimPartSuppliers.AddAsync(partSupplierToAdd);

                    foreach (var part in partSupplier.PartDetails)
                    {
                        var partInDb = _dbContext.PbSupplierParts.Where(x => x.SupplierId == supplierId && x.PartName == part.PartName && x.IsDeleted == false).FirstOrDefault();

                        if (partInDb == null)
                        {
                            var partToAdd = new PbSupplierPart()
                            {
                                SupplierPartId = Guid.NewGuid(),
                                SupplierId = supplierId,
                                PartName = part.PartName,
                                Price = part.Price,
                                PartId = Guid.NewGuid(),
                                CreatedBy = updateClaimDraftDTO.ActionPerformedBy,
                                CreatedDate = DateTime.Now
                            };

                            await _dbContext.PbSupplierParts.AddAsync(partToAdd);
                        }

                        var supplierPartToAdd = new PbClaimSupplierPart()
                        {
                            ClaimSupplierPartId = Guid.NewGuid(),
                            ClaimPartSupplierId = claimPartSupplierId,
                            PartName = part.PartName,
                            Price = part.Price,
                            CreatedBy = updateClaimDraftDTO.ActionPerformedBy,
                            CreatedDate = DateTime.Now

                        };

                        await _dbContext.PbClaimSupplierParts.AddAsync(supplierPartToAdd);
                    }
                

               

                }
            }

            var claimLog = new PbClaimLog
            {
                ClaimLogId = Guid.NewGuid(),
                ClaimId = claimDraftToUpdate.ClaimId,
                Category = "Claims",
                Description = "Panel beater Claim Draft Modified by " + updateClaimDraftDTO.ActionPerformedBy,
                CreatedBy = updateClaimDraftDTO.ActionPerformedBy,
                CreatedDate = DateTime.Now
            };

            await _dbContext.PbClaimLogs.AddAsync(claimLog);

            if (_dbContext.PbClaims.Where(x => x.InsurerId.ToString() == updateClaimDraftDTO.InsurerId && x.InsurerClaimNumber == updateClaimDraftDTO.InsurerClaimNumber).Any())
            {
                throw new Exception(ResponseMessages.InsurerClaimNumberAlreadyInUse);
            }

            //if (updateClaimDraftDTO.ClaimDraftSuppliers.Count > 0)
            //{
            //    var alreadyExistingSupplierIds = _dbContext.PbClaimDraftSuppliers.Where(x => x.ClaimDraftId.ToString() == updateClaimDraftDTO.ClaimDraftId).Select(x => new { SupplierId = x.SupplierId }).ToList();

            //    foreach (var supplier in alreadyExistingSupplierIds)
            //    {
            //        if(!updateClaimDraftDTO.ClaimDraftSuppliers.Where(x => x.SupplierId == supplier.SupplierId.ToString()).Any())
            //        {
            //            var claimSupplierToRemove = _dbContext.PbClaimDraftSuppliers.Where(x => x.ClaimDraftId.ToString() == updateClaimDraftDTO.ClaimDraftId && x.SupplierId == supplier.SupplierId).FirstOrDefault();

            //            if (claimSupplierToRemove != null)
            //            {
            //                _dbContext.PbClaimDraftSuppliers.Remove(claimSupplierToRemove);
            //            }
            //        }
            //    }
                
            //    foreach (var supplier in updateClaimDraftDTO.ClaimDraftSuppliers)
            //    {
            //        if(!alreadyExistingSupplierIds.Where(x => x.SupplierId.ToString() == supplier.SupplierId).Any())
            //        {
            //            var supplierToAdd = new PbClaimDraftSupplier
            //            {
            //                ClaimDraftSupplierId = Guid.NewGuid(),
            //                ClaimDraftId = claimDraftToUpdate.ClaimDraftId,
            //                SupplierId = Guid.Parse(supplier.SupplierId),
            //                CreatedBy = updateClaimDraftDTO.ActionPerformedBy,
            //                CreatedDate = DateTime.Now
            //            };

            //            await _dbContext.PbClaimDraftSuppliers.AddAsync(supplierToAdd);
            //        }
            //    }
            //}


            await _dbContext.SaveChangesAsync();

            return new ResponseDTO()
            {
                KeyId = 1,
                ResponseCode = ResponseCode.Success,
                ResponseMessage = ResponseMessages.ClaimDraftUpdated
            };
        }

        public async void SaveAssessorDetails(string assessorCompany, string assessor, string assessorContactDetails,string actionPerformedBy)
        {
            var dataCompany = (from s in _dbContext.PbAssessorCompanies
                               where s.CompanyName == assessorCompany
                               select s).FirstOrDefault();

            if (dataCompany != null)
            {
                if (assessor != "")
                {
                    var dataAssessor = (from s in _dbContext.PbAssessorDetails
                                        where s.AssessorCompanyId == dataCompany.AssessorCompanyId
                                        && s.AssessorName == assessor
                                        select s).FirstOrDefault();
                    //if the person exists then update the contact details
                    if (dataAssessor != null)
                    {
                        if (assessorContactDetails != null && assessorContactDetails != "")
                        {
                            dataAssessor.ContactDetails = assessorContactDetails;

                            _dbContext.PbAssessorDetails.Update(dataAssessor);
                            await _dbContext.SaveChangesAsync();
                        }
                    }
                    else //the person doesnt exist and therefore has to be created
                    {

                        var assesorDetailsToAdd = new PbAssessorDetail()
                        {
                            AssessorDetailId = Guid.NewGuid(),
                            AssessorCompanyId = dataCompany.AssessorCompanyId,
                            AssessorName = assessor,
                            CreatedBy = actionPerformedBy,
                            CreatedDate = DateTime.Now
                        };

                        if (assessorContactDetails != null && assessorContactDetails != "")
                        {
                            assesorDetailsToAdd.ContactDetails = assessorContactDetails;
                        }

                        await _dbContext.PbAssessorDetails.AddAsync(assesorDetailsToAdd);
                        await _dbContext.SaveChangesAsync();
                    }
                }
            }
            else //if the company doesnt exist it needs to be created
            {
                var assessorCompanyToAdd = new PbAssessorCompany()
                {
                    AssessorCompanyId = Guid.NewGuid(),
                    CompanyName = assessorCompany,
                    CreatedBy = actionPerformedBy,
                    CreatedDate = DateTime.Now
                };

                await _dbContext.PbAssessorCompanies.AddAsync(assessorCompanyToAdd);

                var assessorDetailsToAdd = new PbAssessorDetail()
                {
                    AssessorDetailId = Guid.NewGuid(),
                    AssessorCompanyId = assessorCompanyToAdd.AssessorCompanyId,
                    AssessorName = assessor,
                    CreatedBy = actionPerformedBy,
                    CreatedDate = DateTime.Now,
                };

                if (assessorContactDetails != null && assessorContactDetails != "")
                {
                    assessorDetailsToAdd.ContactDetails = assessorContactDetails;
                }

                await _dbContext.PbAssessorDetails.AddAsync(assessorDetailsToAdd);

                await _dbContext.SaveChangesAsync();
            }
        }

        public async Task<ResponseDTO> DeleteClaimDocumentAsync(DeleteClaimDocumentDTO deleteClaimDocumentDTO)
        {
            var claimDocumentToDelete = _dbContext.PbClaimDocuments.Where(x => x.ClaimDocumentId.ToString() == deleteClaimDocumentDTO.ClaimDocumentId).FirstOrDefault();
            if(claimDocumentToDelete != null)
            {
                _dbContext.PbClaimDocuments.Remove(claimDocumentToDelete);
                await _dbContext.SaveChangesAsync();

                return new ResponseDTO()
                {
                    KeyId = 1,
                    ResponseCode = ResponseCode.Success,
                    ResponseMessage = ResponseMessages.DocumentRemoved
                };
            }
            else
            {
                throw new Exception(ResponseMessages.NoDocumentExists);
            }
        }

        public IEnumerable<GetBrandSuppliersDTO> GetBrandSuppliers(SearchBrandSuppliersDTO searchBrandSuppliersDTO)
        {
            if (searchBrandSuppliersDTO.OrderBy != null)
            {
                searchBrandSuppliersDTO.OrderBy = char.ToUpper(searchBrandSuppliersDTO.OrderBy[0]) + searchBrandSuppliersDTO.OrderBy.Substring(1);
            }

            var brandSuppliers = (from sb in _dbContext.PbSupplierBrands
                                  join s in _dbContext.PbSuppliers on sb.SupplierId equals s.SupplierId
                                  join b in _dbContext.PbBrands on sb.BrandId equals b.BrandId
                                  where b.BrandId.ToString() == searchBrandSuppliersDTO.BrandId
                                  select new GetBrandSuppliersDTO()
                                  {
                                      PanelBeaterBrandId = sb.PanelBeaterBrandId,
                                      BrandId = sb.BrandId,
                                      SupplierId = s.SupplierId,
                                      SupplierName = s.SupplierName + " (" + s.ExternalId+ ")"
                                  }).ToList();

            brandSuppliers = brandSuppliers.GroupBy(x => x.SupplierId).Select(x =>x.First()).ToList();

            var reponse = brandSuppliers.AsEnumerable<GetBrandSuppliersDTO>();


            SearchByName(ref reponse, searchBrandSuppliersDTO.SearchValue);

            if (searchBrandSuppliersDTO.OrderByDescending == true)
            {
                if (searchBrandSuppliersDTO.OrderBy != null)
                {
                    reponse = reponse.OrderByDescending(x => x.GetType().GetProperty(searchBrandSuppliersDTO.OrderBy).GetValue(x)).ToList();
                }
            }
            else
            {
                if (searchBrandSuppliersDTO.OrderBy != null)
                {
                    reponse = reponse.OrderBy(x => x.GetType().GetProperty(searchBrandSuppliersDTO.OrderBy).GetValue(x)).ToList();
                }
            }

            if (searchBrandSuppliersDTO.AllRecords)
                reponse = reponse.ToList();
            else
                reponse = reponse.Skip((searchBrandSuppliersDTO.PageNo - 1) * searchBrandSuppliersDTO.PageSize).Take(searchBrandSuppliersDTO.PageSize).ToList();

            return reponse;
        }

        private static void SearchByName(ref IEnumerable<GetBrandSuppliersDTO> responseList, string SearchValue)
        {
            if (!responseList.Any() || string.IsNullOrWhiteSpace(SearchValue))
                return;
            responseList = responseList.Where(o => (o.SupplierName ?? "").ToString().ToLower().Contains(SearchValue.Trim().ToLower()));
        }
    }
}