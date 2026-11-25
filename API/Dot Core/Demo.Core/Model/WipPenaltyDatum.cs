using System;
using System.Collections.Generic;

#nullable disable

namespace Demo.Core.Model
{
    public partial class WipPenaltyDatum
    {
        public Guid WippenaltyId { get; set; }
        public Guid BatchId { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public Guid? ClaimId { get; set; }
        public string DemoNo { get; set; }
        public Guid? ClientId { get; set; }
        public Guid? SupplierId { get; set; }
        public DateTime? InvoiceDate { get; set; }
        public int? Wipdays { get; set; }
        public string PenaltyDue { get; set; }
        public decimal? InvoiceValue { get; set; }
        public decimal? RebateEarned { get; set; }
        public decimal? CurrentMonthsRebatePenalty { get; set; }
        public decimal? PriorMonthsRebatePenalty { get; set; }
        public decimal? NetRebateEarned { get; set; }
    }
}
