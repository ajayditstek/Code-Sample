using System;
using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace Demo.Core.DTOs.Response
{
    public class GetRequestedClaimsDTO
    {
        public Guid ClaimRequestId { get; set; }
        public Guid ClaimId { get; set; }
        public string ClientName { get; set; }
        public string InsurerName { get; set; }
        public string InsurerClaimNumber { get; set; }
        public string VehicleRegistrationNumber { get; set; }
        public int EstimatedDaysToCompleted { get; set; }
        public string VehicleMake { get; set; }
        public string VehicleModel { get; set; }
        public string InsuredName { get; set; }
        [JsonPropertyName("JobCardNo")]
        public string Ronumber {get; set;}

        public decimal? ClaimAmount { get; set; }
        public decimal? ClaimExcess { get; set; }
        public decimal? ClaimPartsValue { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        
        public string InvoiceType { get; set; }
    }

    public class SearchRequestedClaimsDTO : SearchDTO
    {
        public string ClientId { get; set; }
        public string InvoiceType { get; set; }
    }

}