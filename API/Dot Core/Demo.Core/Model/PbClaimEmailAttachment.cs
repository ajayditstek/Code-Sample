using System;
using System.Collections.Generic;

#nullable disable

namespace Demo.Core.Model
{
    public partial class PbClaimEmailAttachment
    {
        public Guid ClaimEmailAttachementId { get; set; }
        public Guid ClaimEmailId { get; set; }
        public string AttachementName { get; set; }
        public byte[] AttachmentData { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
    }
}
