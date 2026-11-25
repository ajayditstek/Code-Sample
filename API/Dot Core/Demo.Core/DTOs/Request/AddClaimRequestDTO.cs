using System;
using System.Collections.Generic;
using Demo.Core.DTOs.Response;

namespace Demo.Core.DTOs.Request
{
    public class AddClaimRequestDTO
    {
        public string ClaimDraftId { get; set; }
        public string ClaimId { get; set; }
        public string ClientId { get; set; }
        public string InsurerId { get; set; }
        public string InsurerClaimNumber { get; set; }
        public string VehicleRegistrationNumber { get; set; }
        public string VehicleMake { get; set; }
        public string VehicleModel { get; set; }
        public string Year { get; set; }
        public string InsuredName { get; set; }
        public string InsuredPhoneNumber { get; set; }
        //public string? AssessorCompany { get; set; }
        //public string? Assessor { get; set; }
        //public string? AssessorContactDetails { get; set; }
        public string VINNumber { get; set; }
        public decimal? Labour { get; set; }
        public decimal? Paint { get; set; }
        public decimal? TotalPartsValue { get; set; }
        public decimal ClaimPartsValue { get; set; }
        public decimal ClaimAmount { get; set; }
        public decimal ClaimExcess { get; set; }
        public decimal NetClaimAmount { get; set; }
        public string JobCardNo { get; set; }
        public int EstimatedDaysToComplete { get; set; }
        //public List<ClaimRequestSuppliers> ClaimRequestSuppliers { get; set; }
        public string ActionPerformedBy { get; set; }
        public List<SupplierPartDetail> SupplierPartDetails { get; set; }
        //public DateTime EstimatedBookInDate { get; set; }
        //public string InsurerLiaisonPerson { get; set; }
        //public bool NoParts { get; set; }
        //public bool ClaimIsNotADuplicate { get; set; }
    }
    public class ClaimRequestSuppliers
    {
        public string SupplierId { get; set; }
    }
    public class AddClaimRequestResponseDTO : ResponseDTO
    {
        public string ClaimId { get; set; }
    }
    public class GetVehicleRegistrationCheckResponseDTO
    {
        public int IsDuplicateVehicleRegistrationNumber { get; set; }
        public int IsDublicateInsurerClaimNumber { get; set; }
        public string VehicleRegistrationNumber { get; set; }
        public string InsurerClaimNumber { get; set; }
        public Guid ClaimId { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string InsurerName { get; set; }
        public decimal? ClaimAmount { get; set; }
        public string DemoNumber { get; set; }
        public string ClientName { get; set; }
    }
    public class SearchVehicleRegistrationCheckDTO
    {
        public string InsurerClaimNumber { get; set; }
        public string VehicleRegistrationNumber { get; set; }
    }
}