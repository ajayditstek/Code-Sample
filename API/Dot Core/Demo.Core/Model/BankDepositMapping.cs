using System;
using System.Collections.Generic;

#nullable disable

namespace Demo.Core.Model
{
    public partial class BankDepositMapping
    {
        public Guid BankDepositMappingId { get; set; }
        public Guid PaymentDepositId { get; set; }
        public Guid ClaimId { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public decimal? AllocatedAmount { get; set; }
        public decimal? ShortFallAmount { get; set; }
        public decimal? CreditAmount { get; set; }
        public decimal? DueToDemoAmount { get; set; }
        public decimal? DueToPbamount { get; set; }
    }
}
