using Microsoft.AspNetCore.Hosting.Server;
using Demo.Core.DTOs.Request;
using Demo.Core.DTOs.Response;
using Demo.Core.Interfaces;
using Demo.Core.Model;
using Demo.Repository.Common.Helper;
using Demo.Repository.Common.StoreProcedures;
using Demo.Repository.Enums;
using Demo.Repository.GenricRepo;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Repository.Repository
{
    public class InsurerRepository : GenericRepository<PbInsurer>, IInsurerRepository
    {
        private readonly UATDemoPortalContext _dbContext;
        public InsurerRepository(UATDemoPortalContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<ResponseDTO> AddInsurerRequestAsync(AddInsurerRequestDTO addInsurerRequestDTO)
        {
            var userName = addInsurerRequestDTO.ActionPerformedBy;
            var panelBeaterName = string.Empty;

            panelBeaterName = (from s in _dbContext.PbClients
                                join x in _dbContext.UserFunctionAllocations on s.ClientId equals x.AllocationId
                                where x.UserName == userName
                               select s.ClientName).FirstOrDefault() ?? "";
            if (panelBeaterName == "")
            {
                throw new Exception(ResponseMessages.EnsureYouAreAssignedToPanelBeater);
            }

            var claimLog = new PbClaimLog()
            {
                ClaimLogId = Guid.NewGuid(),
                CreatedBy = addInsurerRequestDTO.ActionPerformedBy,
                CreatedDate = DateTime.Now,
                Description = "INSURER REQUEST: " + addInsurerRequestDTO.InsurerName + " - " + addInsurerRequestDTO.Description,
                Category = "Insurer Request"
            };

            await _dbContext.PbClaimLogs.AddAsync(claimLog);

            string notificaitonMessage = panelBeaterName + " has requested for a new insurer ";

            var sendEmail = new PbCorrespondance()
            {
                CorrespondanceId = Guid.NewGuid(),  
                LogDate = DateTime.Now,
                Recipients = "markus@Democap.co.za",
                MessageSubject = "New Insurer Request",
                MessageType = "EMAIL",
                MessageCategory = "Insurer Request",
                MessageContent = "<h1>New Insurer Request</h1> </br>"
                                     + "<p>A new insurer request was sent from <strong>" + panelBeaterName + "</strong>. We are in need of a new insurer, see information below:</p>"
                                     + "<table>"
                                     + "<tr>"
                                     + "<td>"
                                     + "<strong>Insurer Name:</strong>"
                                     + "</td>"
                                     + "<td>"
                                     + addInsurerRequestDTO.InsurerName.Trim().ToUpper()
                                     + "</td>"
                                     + "</tr>"
                                     + "<tr>"
                                     + "<td>"
                                     + "<strong>Request:</strong>"
                                     + "<td>"
                                     + "<td>"
                                     + addInsurerRequestDTO.Description.Trim()
                                     + "<td>"
                                     + "</tr>"
                                     + "</table>"
                                     + "<p>This is an automated message please do not respond.</p>"
            };

            if (addInsurerRequestDTO.ProofDocument != null)
            {
                var uploadDocumentImage = new UploadImages();
                byte[] documentBytes = null;
                var fileName = addInsurerRequestDTO.ProofDocument.FileName;
                var imagePath = uploadDocumentImage.UploadImage("wwwroot", "ProofDocument", addInsurerRequestDTO.ProofDocument);

                if (imagePath != null)
                {
                    using (var ms = new MemoryStream())
                    {
                        addInsurerRequestDTO.ProofDocument.CopyTo(ms);
                        documentBytes = ms.ToArray();
                    }
                }

                sendEmail.AttachmentFilenames = imagePath;

                notificaitonMessage += "with the following proof document: <a href='" + imagePath + "' target='_blank'>" + addInsurerRequestDTO.ProofDocument.FileName + "</a>";

            }

            var markusUserId = _dbContext.AspnetMemberships.Where(x => x.LoweredEmail == "markus@Democap.co.za").FirstOrDefault().UserId;
            //All Insurer Requests go to markus

            var notificationParams = new AddNotifictionDTO()
            {
                Title = "New Insurer Request",
                Message = notificaitonMessage,
                Category = "Insurer Request",
                User_Roles = markusUserId.ToString(),
                User_Exceptions = null,
                CreatedBy = addInsurerRequestDTO.ActionPerformedBy,
                Relevant_ClaimID = null,
                Relevant_ClientID = null,
                Relevant_SupplierID = null,
                Relevant_InsurerID = null ,
                BatchID = Guid.NewGuid()               
            };

            //var response = await CommandAsync<SpResponseDTO>(StoreProcedures.CreateNotification, notificationParams);

            await _dbContext.PbCorrespondances.AddAsync(sendEmail);

            await _dbContext.SaveChangesAsync();

            return new ResponseDTO()
            {
                KeyId = 1,
                ResponseCode = ResponseCode.Success,
                ResponseMessage = ResponseMessages.InsurerRequestSent
            };

        }
    }
}
