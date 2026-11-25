using System;

namespace Demo.Core.DTOs.Response
{
    public class GetClaimsDTO
    {
        public Guid ClaimId { get; set; }
        public Guid ClientId { get; set; }
        public Guid InsurerId { get; set; }
        public string ClientName { get; set; }
        public string DemoNumber { get; set; }
        public string InsurerClaimNumber { get; set; }
        public string InvoiceType { get; set; }
        public string InsuredName { get; set; }
        public string Make { get; set; }
        public string VehicleRegistrationNumber { get; set; }
        public decimal? ClaimAmount { get; set; }
        public int? InvoiceToInsurer { get; set; }
        public int? ConfirmedWithInsurer { get; set; }
        public string ClaimStatus { get; set; }
        public string JobCardNo { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string PartsOrdered { get; set; }
    }

    public class SearchClaimsDTO : SearchDTO
    {
        public string ClaimId { get; set; }
        public string InsurerId { get; set; }
        public string InvoiceType { get; set; }
    }
}