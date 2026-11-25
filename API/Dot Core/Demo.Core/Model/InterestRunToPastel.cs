using System;
using System.Collections.Generic;

#nullable disable

namespace Demo.Core.Model
{
    public partial class InterestRunToPastel
    {
        public Guid InterestRunId { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public Guid BatchId { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public Guid? ClientId { get; set; }
        public string ClientName { get; set; }
        public DateTime? FinalAuthorisedDate { get; set; }
        public decimal? ReceiptInCurrentPeriod { get; set; }
        public decimal? DaysOs { get; set; }
        public decimal? InterestDays { get; set; }
        public decimal? InterestAmount { get; set; }
        public decimal? CulmInterest { get; set; }
        public decimal? OpenBalLedger { get; set; }
        public int? TotalDebtorDays { get; set; }
        public decimal? CalendarDays { get; set; }
        public decimal? InterestRate { get; set; }
        public DateTime? SettlementDate { get; set; }
        public decimal? CloseBal { get; set; }
        public decimal? DiscountFee { get; set; }
    }
}
