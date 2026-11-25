using System;
using System.Collections.Generic;

#nullable disable

namespace Demo.Core.Model
{
    public partial class GcClaimDocument
    {
        public Guid ClaimDocumentId { get; set; }
        public Guid? ClaimId { get; set; }
        public string DocumentType { get; set; }
        public string DocumentName { get; set; }
        public string Description { get; set; }
        public string Keywords { get; set; }
        public byte[] DocumentData { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
    }
}
