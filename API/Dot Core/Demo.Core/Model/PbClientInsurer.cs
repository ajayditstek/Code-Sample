using System;
using System.Collections.Generic;

#nullable disable

namespace Demo.Core.Model
{
    public partial class PbClientInsurer
    {
        public Guid ClientInsurerId { get; set; }
        public Guid ClientId { get; set; }
        public Guid InsurerId { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime ModifiedDate { get; set; }
        public int? PeriodToPay { get; set; }
        public decimal? InsurerDiscountPercentage { get; set; }
    }
}
