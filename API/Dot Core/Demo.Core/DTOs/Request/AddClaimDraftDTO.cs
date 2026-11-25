using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Core.DTOs.Request
{
    public class AddClaimDraftDTO
    {
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
        //public List<ClaimDraftSuppliers> ClaimDraftSuppliers { get; set; }
        public string ActionPerformedBy { get; set; }
        public List<SupplierPartDetail> SupplierPartDetails { get; set; }
        //public DateTime EstimatedBookInDate { get; set; }
        //public string InsurerLiaisonPerson { get; set; }
        //public bool NoParts { get; set; }
        //public bool ClaimIsNotADuplicate { get; set; }
    }
    public class AddClaimDraftResponseDTO : AddClaimRequestResponseDTO
    {

    }
    public class ClaimDraftSuppliers
    {
        public string SupplierId { get; set; }
    }
    public class SupplierPartDetail
    {
        public string ClaimPartSupplierId { get; set; }
        public string SupplierId { get; set; }
        public decimal SupplierTotal { get; set; }
        public List<PartDetail> PartDetails { get; set; }
        public bool IsPartSupplierDeleted { get; set; }

    }
    public class PartDetail
    {
        public string ClaimSupplierPartId { get; set; }
        public string PartName { get; set; }
        public decimal? Price { get; set; }
        public bool IsDeleted { get; set; }
    }
}
