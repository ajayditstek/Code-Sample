using System;
using System.Collections.Generic;

#nullable disable

namespace Demo.Core.Model
{
    public partial class GcCorrespondance
    {
        public Guid CorrespondanceId { get; set; }
        public DateTime LogDate { get; set; }
        public Guid? ClaimId { get; set; }
        public Guid? ClaimEmailId { get; set; }
        public Guid? SupplierId { get; set; }
        public Guid? FitterId { get; set; }
        public Guid? GlassAdministratorId { get; set; }
        public string MessageCategory { get; set; }
        public string MessageType { get; set; }
        public string MessageContent { get; set; }
        public string MessageSubject { get; set; }
        public string Recipients { get; set; }
        public string AttachmentFilenames { get; set; }
        public DateTime? SentDate { get; set; }
        public string ServerResponse { get; set; }
        public string RecipientsCc { get; set; }
        public string RecipientsBcc { get; set; }
        public string History { get; set; }
    }
}
