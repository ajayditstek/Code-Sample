using System;
using System.Collections.Generic;
#nullable disable

namespace Demo.Core.Model
{
    public partial class PbClaimRequest
    {
        public Guid ClaimRequestId { get; set; }
        public Guid? ClaimId { get; set; }
        public Guid? ClientId { get; set; }
        public Guid? InsurerId { get; set; }
        public string InsurerClaimNumber { get; set; }
        public string VehicleRegistrationNumber { get; set; }
        public string VehicleMake { get; set; }
        public string VehicleModel { get; set; }
        public string InsuredName { get; set; }
        public string Year { get; set; }
        public string VINNumber { get; set; }
        public decimal? Labour { get; set; }
        public decimal? Paint { get; set; }
        public string InsuredPhoneNumber { get; set; }
        public string Ronumber { get; set; }
        public decimal? ClaimAmount { get; set; }
        public decimal? ClaimExcess { get; set; }
        public decimal? ClaimPartsValue { get; set; }
        public decimal? NetClaimAmount { get; set; }
        public string InvoiceType { get; set; }
        public decimal? TotalPartsValue { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string ApprovedBy { get; set; }
        public DateTime? ApprovedDate { get; set; }
        public int? EstimatedDaysToCompleted { get; set; }
        public DateTime? EstimatedBookInDate { get; set; }
        public Guid? InsurerIdsecondary { get; set; }
        public string InsurerLiaisonPerson { get; set; }
        public DateTime? DeclinedDate { get; set; }
        public string DeclinedBy { get; set; }
    }
}
