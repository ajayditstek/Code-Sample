using System;
using System.Collections.Generic;

#nullable disable

namespace Demo.Core.Model
{
    public partial class Notification
    {
        public Guid NotificationId { get; set; }
        public Guid UserId { get; set; }
        public string Title { get; set; }
        public string Message { get; set; }
        public string Category { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? AcknowledgedDate { get; set; }
        public string AcknowledgedBy { get; set; }
        public Guid? RelevantClaimId { get; set; }
        public Guid? RelevantClientId { get; set; }
        public Guid? RelevantSupplierId { get; set; }
        public Guid? RelevantInsurerId { get; set; }
        public Guid? BatchId { get; set; }
    }
}
