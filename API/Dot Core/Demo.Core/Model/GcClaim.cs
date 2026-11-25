using System;
using System.Collections.Generic;

#nullable disable

namespace Demo.Core.Model
{
    public partial class GcClaim
    {
        public Guid ClaimId { get; set; }
        public Guid InsurerId { get; set; }
        public Guid? SchemeId { get; set; }
        public string DemoNumber { get; set; }
        public string InsurerClaimNumber { get; set; }
        public string InsuredLastName { get; set; }
        public string InsuredFirstName { get; set; }
        public string InsuredIdnumber { get; set; }
        public string InsuredPhoneNumber { get; set; }
        public string InsuredCellNumber { get; set; }
        public string InsuredAltPhoneNumber { get; set; }
        public string VehicleMake { get; set; }
        public string VehicleModel { get; set; }
        public int? VehicleYear { get; set; }
        public string VehicleRegistrationNumber { get; set; }
        public string VehicleVin { get; set; }
        public string VehicleMmcode { get; set; }
        public int? UseOeglass { get; set; }
        public string GlassType { get; set; }
        public DateTime? DateOfLoss { get; set; }
        public string CauseOfDamage { get; set; }
        public string CauseDescription { get; set; }
        public string Province { get; set; }
        public string Area { get; set; }
        public string InsuredAddress1 { get; set; }
        public string InsuredAddress2 { get; set; }
        public string InsuredAddressPostalCode { get; set; }
        public decimal? ClaimAmountEstimate { get; set; }
        public decimal? ClaimAmountExcess { get; set; }
        public string ClaimStatus { get; set; }
        public decimal? ClaimAmountFinal { get; set; }
        public DateTime? QuoteRequestedDate { get; set; }
        public string QuoteRequestedBy { get; set; }
        public DateTime? QuoteSubmittedDate { get; set; }
        public string QuoteSubmittedBy { get; set; }
        public DateTime? QuoteAuthorisedDate { get; set; }
        public string QuoteAuthorisedBy { get; set; }
        public DateTime? ClaimDeclinedDate { get; set; }
        public string ClaimDeclinedBy { get; set; }
        public string DeclinedReason { get; set; }
        public DateTime? ClaimedClosedDate { get; set; }
        public Guid? GlassAdministratorId { get; set; }
        public string GlassAdministratorBy { get; set; }
        public DateTime? GlassAdministratorDate { get; set; }
        public Guid? FitterId { get; set; }
        public string FittterBy { get; set; }
        public DateTime? FitterAssignDate { get; set; }
        public Guid? SupplierId { get; set; }
        public string SupplierBy { get; set; }
        public DateTime? SupplierAssignDate { get; set; }
        public DateTime? ClosedDate { get; set; }
        public string ClosedBy { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string SupplierOrderNumber { get; set; }
        public string BordereauNumber { get; set; }
        public string CapturedByUserRole { get; set; }
        public string PolicyNumber { get; set; }
        public string GlassCode { get; set; }
        public DateTime? ScheduledFittingDate { get; set; }
        public string OrderNote { get; set; }
        public string ScheduledFittingTimeSlot { get; set; }
        public string ScheduledFittingAddress1 { get; set; }
        public string ScheduledFittingAddress2 { get; set; }
        public string ScheduledFittingAddress3 { get; set; }
        public Guid? GlassFitmentCenterId { get; set; }
        public string GlassFitmentCenterBy { get; set; }
        public DateTime? GlassFitmentCenterDate { get; set; }
        public Guid? SupplierInvoiceId { get; set; }
        public string CancelledBy { get; set; }
        public DateTime? CancelledDate { get; set; }
        public string CancelledReason { get; set; }
        public Guid? FitmentInvoiceId { get; set; }
        public Guid? BrokerId { get; set; }
        public string BrokerBy { get; set; }
        public DateTime? BrokerDate { get; set; }
        public string ClaimSubmitTo { get; set; }
        public Guid? CapturedByUserId { get; set; }
        public bool? RequiresAuthorisation { get; set; }
        public DateTime? AuthoriseDate { get; set; }
        public string AuthoriseBy { get; set; }
        public int? DemoSeqNo { get; set; }
    }
}
