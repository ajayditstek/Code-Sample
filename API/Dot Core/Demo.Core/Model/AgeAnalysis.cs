using System;
using System.Collections.Generic;

#nullable disable

namespace Demo.Core.Model
{
    public partial class AgeAnalysis
    {
        public Guid? Newid { get; set; }
        public string Cscode { get; set; }
        public string Client { get; set; }
        public DateTime? Ddate { get; set; }
        public string Ref { get; set; }
        public string Matchref { get; set; }
        public decimal? _120days { get; set; }
        public decimal? _90days { get; set; }
        public decimal? _60days { get; set; }
        public decimal? _30days { get; set; }
        public decimal? Current { get; set; }
        public decimal? TotalDue { get; set; }
        public int? Age { get; set; }
        public string Demonumber { get; set; }
        public string Insurers { get; set; }
        public string ClaimNumber { get; set; }
        public string InvoiceNo { get; set; }
        public string Notes { get; set; }
        public string Ronumber { get; set; }
        public Guid? ClaimId { get; set; }
        public DateTime? ExpectedPaymentDate { get; set; }
        public string DefaultReason { get; set; }
    }
}
