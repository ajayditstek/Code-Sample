using System;
using System.Collections.Generic;

#nullable disable

namespace Demo.Core.Model
{
    public partial class TmpWipdata2
    {
        public DateTime? ReportStartDate { get; set; }
        public DateTime? ReportEndDate { get; set; }
        public string PanelBeater { get; set; }
        public string ExternalId { get; set; }
        public string Ssno { get; set; }
        public string DemoNo { get; set; }
        public string VehicleRegNo { get; set; }
        public string SupplierName { get; set; }
        public string InvoiceNumber { get; set; }
        public decimal? SupplierInvoiceValue { get; set; }
        public DateTime InvoiceDate { get; set; }
        public DateTime? PartsPaymentDate { get; set; }
        public DateTime? ClaimSettlementDate { get; set; }
        public DateTime? FinalInvoiceAuthorisedDate { get; set; }
        public DateTime? PastelOiReceiptDate { get; set; }
        public DateTime? ClosedDate { get; set; }
        public string ProductDefinition { get; set; }
        public decimal? PbrebatePercent { get; set; }
        public decimal? TotalRebatePercent { get; set; }
        public decimal? DemoRebatePercent { get; set; }
        public decimal? PbrebateValue { get; set; }
        public decimal? DemoRebateValue { get; set; }
        public decimal? FullRebateValue { get; set; }
        public decimal? PbmonthlyPenaltyFee { get; set; }
        public int? PenaltyCycles { get; set; }
        public decimal? BalanceDueOrOwing { get; set; }
        public int? AgeingDays { get; set; }
        public int ReportSortOrder { get; set; }
        public decimal? RebateUsed { get; set; }
        public decimal? PenaltyUsed { get; set; }
        public string RealisedThisMonth { get; set; }
        public decimal? CumulatedPenalties { get; set; }
        public decimal? Pbsettlement { get; set; }
        public decimal? ContingentRebate { get; set; }
        public int? Year { get; set; }
        public int? Month { get; set; }
    }
}
