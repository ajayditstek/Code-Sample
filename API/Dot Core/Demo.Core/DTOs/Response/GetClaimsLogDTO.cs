using System;

namespace Demo.Core.DTOs.Response
{
    public class GetClaimsLogDTO
    {
        public Guid ClaimLogId { get; set; }
        public Guid? ClaimId { get; set; }
        public string Category { get; set; }
        public string Description { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
    }

    public class SearchClaimsLogDTO : SearchDTO
    {
        public string ClaimId { get; set; }
    }
}