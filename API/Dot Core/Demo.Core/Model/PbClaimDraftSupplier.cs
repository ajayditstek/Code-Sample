using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
#nullable disable

namespace Demo.Core.Model
{
    public partial class PbClaimDraftSupplier
    {
        [Key]
        public Guid ClaimDraftSupplierId { get; set; }
        public Guid? ClaimDraftId { get; set; }
        public Guid? SupplierId { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
    }
}