using System;
using System.Collections.Generic;

#nullable disable

namespace Demo.Core.Model
{
    public partial class PbAgeAnalysisExtract
    {
        public string PanelBeater { get; set; }
        public string DemoRef { get; set; }
        public string InvoiceNo { get; set; }
        public DateTime? InvoiceDate { get; set; }
        public string InsuranceCompany { get; set; }
        public string ClaimNumber { get; set; }
        public decimal? _120days { get; set; }
        public decimal? _90days { get; set; }
        public decimal? _60days { get; set; }
        public decimal? _30days { get; set; }
        public decimal? Current { get; set; }
        public decimal? TotalDue { get; set; }
        public decimal? PbtotalDue { get; set; }
        public decimal? InvoiceTotal { get; set; }
        public decimal? ClaimAmount { get; set; }
        public string AgeAnalysisNotesDefaultReason { get; set; }
        public DateTime? ExpectedPaymentDate { get; set; }
        public string Notes { get; set; }
        public decimal? GroupTotalDue { get; set; }
        public decimal? DateDifferance { get; set; }
        public decimal? Dd { get; set; }
        public decimal? AvgAging { get; set; }
    }
}
