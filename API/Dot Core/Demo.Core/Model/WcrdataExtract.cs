using System;
using System.Collections.Generic;

#nullable disable

namespace Demo.Core.Model
{
    public partial class WcrdataExtract
    {
        public string JobComponent { get; set; }
        public string PanelBeater { get; set; }
        public string Insurer { get; set; }
        public string JobNumber { get; set; }
        public DateTime? BookInDate { get; set; }
        public string Supplier { get; set; }
        public string InvoiceNumber { get; set; }
        public string SupplierTerms { get; set; }
        public int SupplierTermsDays { get; set; }
        public DateTime? AccountingStartDate { get; set; }
        public DateTime? FinalInvoiceAuthorisedDate { get; set; }
        public DateTime? CashOutDate { get; set; }
        public DateTime? CashReceivedDate { get; set; }
        public decimal? InvoiceTotal { get; set; }
        public decimal? CashOut { get; set; }
        public decimal? RebateSupplier { get; set; }
        public decimal? RebateDemo { get; set; }
        public decimal? RebatePb { get; set; }
        public decimal RebateInsurer { get; set; }
        public decimal DemoRevenueFactoringCharge { get; set; }
        public decimal? DemoRevenueCodFee { get; set; }
        public int DemoRevenueWipPenalty { get; set; }
        public int DemoRevenueDebtorInterestPenalty { get; set; }
        public decimal DemoCostsCapital { get; set; }
        public decimal? DemoRevenueParts { get; set; }
        public decimal? DemoRevenueLabour { get; set; }
        public decimal? DemoRevenuePenalties { get; set; }
        public decimal? DemoRevenueTotal { get; set; }
        public string ClaimStatus { get; set; }
        public Guid ClaimId { get; set; }
        public string Wipflag { get; set; }
        public decimal? DemoCostsFunding { get; set; }
        public decimal? DemoCostsRebateRefunds { get; set; }
        public decimal? DemoCostsTotal { get; set; }
        public decimal? Profit { get; set; }
        public decimal? ProfitPercent { get; set; }
        public decimal? CapitalDeployed { get; set; }
        public decimal? CapitalDeployedPlusProfit { get; set; }
        public int? Wipdays { get; set; }
        public int? WipdebtorDays { get; set; }
        public int? WorkingCapitalCycle { get; set; }
        public int? CashWorkingCapitalCycle { get; set; }
        public decimal? CaptitalDeployedDevideErrorFix { get; set; }
        public decimal? WeightedAverageCashWccycleDevideCalc { get; set; }
        public decimal WeightedDaysWip { get; set; }
        public decimal WeightedDebtorsDays { get; set; }
        public decimal? AggregateWcdays { get; set; }
        public decimal? WeightedAverageCashWccycle { get; set; }
        public decimal? WeightedReturnOnCapitalDeployed { get; set; }
        public int? UniqueClaimsPerPb { get; set; }
        public int? UniqueClaimsPerInsurer { get; set; }
        public int? UniqueClaimsTotal { get; set; }
        public int? Pbefficiency { get; set; }
        public decimal? ProductDefinition { get; set; }
        public string InvoiceType { get; set; }
        public Guid InsurerId { get; set; }
        public Guid Id { get; set; }
        public DateTime DateUpdated { get; set; }
    }
}
