using System.Collections.Generic;

namespace Demo.Core.DTOs.Request
{
    public class UpdateClaimDTO
    {
        public string ClaimId { get; set; }
        public string InsurerClaimNumber { get; set; }
        public string VehicleRegistrationNumber { get; set; }
        public string VehicleMake { get; set; }
        public string VehicleModel { get; set; }
        public string DemoNumber { get; set; }
        public string InsuredName { get; set; }
        public string InsuredPhoneNumber { get; set; }
        public decimal ClaimAmount { get; set; }
        public string JobCardNo { get; set; }
        public decimal? ClaimExcess { get; set; }
        public decimal? ClaimPartsValue { get; set; }
        public string InsurerId { get; set; }
        public string InvoiceType { get; set; }
        public string ActionPerformedBy { get; set; }
        public int EstimatedDaysToComplete { get; set; }
        public List<ClaimSupplier> ClaimSuppliers { get; set; }

    }

}