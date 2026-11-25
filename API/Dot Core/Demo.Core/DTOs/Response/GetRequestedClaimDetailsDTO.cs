using System;
using System.Collections.Generic;

namespace Demo.Core.DTOs.Response
{
    public class GetRequestedClaimDetailsDTO
    {
        public Guid ClaimRequestId { get; set; }
        public Guid? ClaimId { get; set; }
        public Guid? ClientId { get; set; }
        public Guid? InsurerId { get; set; }
        public string ClientName { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public string InsurerName { get; set; }
        public string InsurerClaimNumber { get; set; }
        public string VehicleRegistrationNumber { get; set; }
        public string VehicleMake { get; set; }
        public string VehicleModel { get; set; }
        public string InsuredName { get; set; }
        public string InsuredPhoneNumber { get; set; }
        public decimal? ClaimAmount { get; set; }
        public decimal? ClaimExcess { get; set; }
        public decimal? ClaimPartsValue { get; set; }
        public string InvoiceType { get; set; }
        public string Year { get; set; }
        public int? EstimatedDaysToComplete { get; set; }
        public string JobCardNo { get; set; }
        public decimal? Paint { get; set; }
        public decimal? Labour { get; set; }
        public string VINNumber { get; set; }
        public List<RequestedClaimSuppliers> RequestedClaimSuppliers { get; set; }
    }
    public class RequestedClaimSuppliers
    {
        public Guid? SupplierId { get; set; }
        public string SupplierName { get; set; }
    }
    public class SearchRequestedClaimDetailsDTO
    {
        public string ClaimRequestId { get; set; }
    }
}