using System;
using System.Collections.Generic;

namespace Demo.Core.DTOs.Response
{
    public class GetClaimDetailsDTO
    {
        public Guid ClaimId { get; set; }
        public Guid ClientId { get; set; }
        public Guid InsurerId { get; set; }
        public string ClientName { get; set; }
        public string ClientTradingName { get; set; }
        public string PrimaryInsurer { get; set; }
        public string InsurerClaimNumber { get; set; }
        public string vehicleRegistrationNumber { get; set; }
        public string VehicleMake { get; set; }
        public string VehicleModel { get; set; }
        public string DemoNumber { get; set; }
        public string InsuredName { get; set; }
        public string InsuredPhoneNumber { get; set; }
        public decimal? ClaimAmount { get; set; }
        public string JobCardNo { get; set; }
        public decimal? ClaimExcess { get; set; }
        public decimal? ClaimPartsValue { get; set; }
        public decimal? NetClaimAmount { get; set; }
        public string InvoiceType { get; set; }
        public List<SuppliersInClaim> ClientSuppliers { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? EstimatedDaysToComplete { get; set; }
    }
    
    public class SuppliersInClaim
    {
        public Guid SupplierId { get; set; }
    }

    public class SearchClaimDetailsDTO
    {
        public string ClaimId { get; set; }
    }
}