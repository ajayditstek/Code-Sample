using System;
using System.Collections.Generic;

#nullable disable

namespace Demo.Core.Model
{
    public partial class FinancialPeriod
    {
        public Guid FinancialPeriodId { get; set; }
        public int? FinancialYear { get; set; }
        public int? FinancialPeriod1 { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public DateTime? ClosedDate { get; set; }
        public string Notes { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string ModifiedBy { get; set; }
    }
}
