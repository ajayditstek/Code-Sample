using System;
using System.Collections.Generic;

#nullable disable

namespace Demo.Core.Model
{
    public partial class PbClaimDeduction
    {
        public Guid ClaimDeductionId { get; set; }
        public string DeductionType { get; set; }
        public decimal? DeductionValue { get; set; }
        public int? InvoicesToRecoverFrom { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public bool FullyCaptured { get; set; }
        public Guid? ClientId { get; set; }
        public Guid? ClaimId { get; set; }
        public DateTime? DeductionPastelJournalDate { get; set; }
        public decimal? MaxReclaimPercent { get; set; }
        public DateTime? EffectiveDate { get; set; }
        public Guid? SupplierDocumentId { get; set; }
        public DateTime? PastelConfirmDate { get; set; }
        public string PastelConfirmComments { get; set; }
    }
}
