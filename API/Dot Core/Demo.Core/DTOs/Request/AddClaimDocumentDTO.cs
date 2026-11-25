using Microsoft.AspNetCore.Http;

namespace Demo.Core.DTOs.Request
{
    public class AddClaimDocumentDTO
    {
        public string ClaimId { get; set; }
        public IFormFile Document { get; set; }
        public string DocumentName { get; set; }
        public string Description { get; set; }
        public string DocumentType { get; set; }
        public string ActionPerformedBy { get; set; }
    }
}