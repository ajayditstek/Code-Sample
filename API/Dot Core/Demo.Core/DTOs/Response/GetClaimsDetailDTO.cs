using Demo.Core.DTOs.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Core.DTOs.Response
{
    public class GetClaimsDetailDTO
    {
        public Guid Id { get; set; }
        public Guid? ClaimId { get; set; }
        public Guid ClientId { get; set; }
        public Guid? InsurerId { get; set; }
        public string InsurerName { get; set; }
        public string ClientName { get; set; }
        public string ClientTradingName { get; set; }
        public string PrimaryInsurer { get; set; }
        public string InsurerClaimNumber { get; set; }
        public string ClaimNumber { get; set; }
        public string InsurerLiaisonPerson { get; set; }
        public string VehicleRegistrationNumber { get; set; }
        public string VehicleMake { get; set; }
        public string VehicleModel { get; set; }
        public string VINNumber { get; set; }
        public string DemoNumber { get; set; }
        public string InsuredName { get; set; }
        public string InsuredPhoneNumber { get; set; }
        public decimal? ClaimAmount { get; set; }
        public decimal? TotalPartsValue { get; set; }
        public string JobCardNo { get; set; }
        public decimal? ClaimExcess { get; set; }
        public decimal? ClaimPartsValue { get; set; }
        public decimal? Labour { get; set; }
        public decimal? Paint { get; set; }
        public decimal? NetClaimAmount { get; set; }
        public string InvoiceType { get; set; }
        public string Year { get; set; }
        public List<ClaimSuppliers> Suppliers { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? EstimatedDaysToComplete { get; set; }
        public DateTime? EstimatedBookInDate { get; set; }
        public List<SupplierPart> SupplierPartDetails { get; set; }
    }

    public class ClaimSuppliers
    {
        public Guid? SupplierId { get; set; }
        public string SupplierName { get; set; }
    }
    public class SearchClaimsDetailDTO
    {
        public string ClaimId { get; set; }
    }

    public class SupplierPart
    {
        public Guid ClaimPartSupplierId { get; set; }
        public Guid? SupplierId { get; set; }
        public string SupplierName { get; set; }
        public decimal? SupplierTotal { get; set; }
        public List<Part> PartDetails { get; set; }
        public bool IsPartSupplierDeleted { get; set; }

    }
    public class Part
    {
        public Guid ClaimSupplierPartId { get; set; }
        public string PartName { get; set; }
        public decimal? Price { get; set; }
        public bool IsDeleted { get; set; }
    }
}
