using System;
using System.Collections.Generic;
using Demo.Core.DTOs.Response;

namespace Demo.Core.DTOs.Request
{
    public class AddRequestedClaimDTO
    {
        public string ClaimRequestId { get; set; }
        public string ClientId { get; set; }
        public string ClaimId { get; set; }
        public string InsurerId { get; set; }
        // public string PanelBeater { get; set; }
        public string InsurerClaimNumber { get; set; }
        public string VehicleRegistrationNumber { get; set; }
        public string VehicleMake { get; set; }
        public string VehicleModel { get; set; }
        public string InsuredName { get; set; }
        public string InsuredPhoneNumber { get; set; }
        public decimal ClaimAmount { get; set; }
        public string JobCardNo { get; set; }
        public decimal ClaimExcess { get; set; }
        public decimal ClaimPartsValue { get; set; }
        public string InvoiceType { get; set; }
        public List<ClaimSupplier> ClaimSuppliers { get; set; }
        public string ActionPerformedBy { get; set; }
        public int EstimatedDaysToComplete { get; set; }
    }
    public class AddRequestedClaimResponseDTO : ResponseDTO
    {
        public string DemoNumber { get; set; }
    }
}