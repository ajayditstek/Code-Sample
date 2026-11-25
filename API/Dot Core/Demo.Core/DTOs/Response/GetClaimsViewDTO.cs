using System;
using System.Collections.Generic;

namespace Demo.Core.DTOs.Response
{
    public class GetClaimsViewDTO
    {
        public Guid ClientId { get; set; }
        public Guid? ClaimId { get; set; }
        public Guid InsurerId { get; set; }
        public string InsuredName { get; set; }
        public string InsuredPhoneNumber { get; set; }
        public string InsurerName { get; set; }
        public string InsurerClaimNumber { get; set; }
        public string ClientName { get; set; }
        public string DemoNumber { get; set; }
        public decimal? ClaimAmount { get; set; }
        public string VehicleMake { get; set; }
        public string VehicleRegistrationNumber { get; set; }
        public List<Supplier> Suppliers { get; set; }
        public List<ClaimDocument> ClaimDocuments { get; set; }

    }
    public class Supplier
    {
        public Guid SupplierId { get; set; }
        public string SupplierName { get; set; }
    }

    public class ClaimDocument
    {
        public Guid ClaimDocumentId { get; set; }
        public string DocumentName { get; set; }
        public string DocumentType { get; set; }
        public string Document { get; set; }
        public string Description { get; set; }
        public string DocumentSize { get; set; }
        public string DocumentUrl { get; set; }
    }
    public class SearchClaimsViewDTO
    {
        public string ClaimId { get; set; }
        public string ClaimStatus { get; set; }
    }
}