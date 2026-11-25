using System;
using System.Collections.Generic;

#nullable disable

namespace Demo.Core.Model
{
    public partial class PbClaimEmail
    {
        public Guid ClaimEmailId { get; set; }
        public string EmailType { get; set; }
        public string EmailSubject { get; set; }
        public string EmailSender { get; set; }
        public string EmailBodyText { get; set; }
        public string EmailBodyHtml { get; set; }
        public Guid? ClaimId { get; set; }
        public string PanelBeaterId { get; set; }
        public string Insurer { get; set; }
        public string InsurerScheme { get; set; }
        public string InsurerClaimNumber { get; set; }
        public string InsuredsName { get; set; }
        public string InsuredsContactNumber { get; set; }
        public string VehicleMake { get; set; }
        public string VehicleModel { get; set; }
        public string VehicleRegistration { get; set; }
        public string VehicleVin { get; set; }
        public string Ronumber { get; set; }
        public decimal? ClaimAmount { get; set; }
        public decimal? FinalInvoiceAmount { get; set; }
        public decimal? DiscountCostPercent { get; set; }
        public decimal? DiscountCostValue { get; set; }
        public decimal? CashSecurityPercent { get; set; }
        public decimal? CashSecurityValue { get; set; }
        public decimal? BalanceDue { get; set; }
        public string EmailMessageId { get; set; }
        public DateTime? DateReceived { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public Guid? ClientId { get; set; }
        public Guid? InsurerId { get; set; }
        public string InvoiceType { get; set; }
        public string FileData { get; set; }
        public decimal? FundingPercent { get; set; }
        public decimal? ContingencyPercent { get; set; }
        public decimal? PartsAmount { get; set; }
        public DateTime? BookInDate { get; set; }
        public int? EstimatedDaysToComplete { get; set; }
        public bool? FinaliseClaimProcessed { get; set; }
        public bool? PartsRequired { get; set; }
        public bool? CessionAccepted { get; set; }
    }
}
