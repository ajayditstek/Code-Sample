using System;
using System.Collections.Generic;

#nullable disable

namespace Demo.Core.Model
{
    public partial class TmpRebateDatum
    {
        public string DocumentNumber { get; set; }
        public string SupplierName { get; set; }
        public string ClientName { get; set; }
        public string InsurerName { get; set; }
        public string InsurerClaimNumber { get; set; }
        public string Ronumber { get; set; }
        public string DocumentDate { get; set; }
        public decimal? DocumentTotal { get; set; }
        public string DemoNumber { get; set; }
        public string DocumentType { get; set; }
        public string DemoPercent { get; set; }
        public decimal? DemoAmount { get; set; }
        public string ClientPercent { get; set; }
        public decimal? ClientAmount { get; set; }
        public string InsurerPercent { get; set; }
        public decimal? InsurerAmount { get; set; }
        public string TotalPercent { get; set; }
        public decimal? TotalAmount { get; set; }
    }
}
