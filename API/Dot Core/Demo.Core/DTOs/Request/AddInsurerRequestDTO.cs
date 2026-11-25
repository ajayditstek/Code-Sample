using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Core.DTOs.Request
{
    public class AddInsurerRequestDTO
    {
        public string InsurerName { get; set; }
        public string Description { get; set; }
        public IFormFile ProofDocument { get; set; }
        public string ActionPerformedBy { get; set; }
    }

    public class AddNotifictionDTO
    {
        public string Title { get; set; }
        public string Message { get; set; }
        public string Category { get; set; }
        public string User_Exceptions { get; set; }
        public string CreatedBy { get; set; }
        public string Relevant_ClaimID { get; set; }
        public string Relevant_ClientID { get; set; }
        public string Relevant_SupplierID { get; set; }
        public string Relevant_InsurerID { get; set; }
        public Guid BatchID { get; set; }
        public string User_Roles { get; set; }

    }
    public class SpResponseDTO
    {

    }
}
