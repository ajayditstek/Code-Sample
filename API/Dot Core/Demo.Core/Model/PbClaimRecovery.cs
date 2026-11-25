using System;
using System.Collections.Generic;

#nullable disable

namespace Demo.Core.Model
{
    public partial class PbClaimRecovery
    {
        public Guid ClaimRecoveriesId { get; set; }
        public string PaymentType { get; set; }
        public decimal? PaymentValue { get; set; }
        public Guid ClaimDeductionId { get; set; }
        public Guid CnclaimDeductionId { get; set; }
        public Guid ClaimId { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
    }
}
