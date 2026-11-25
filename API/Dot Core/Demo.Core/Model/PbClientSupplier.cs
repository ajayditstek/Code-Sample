using System;
using System.Collections.Generic;

#nullable disable

namespace Demo.Core.Model
{
    public partial class PbClientSupplier
    {
        public Guid ClientSupplierId { get; set; }
        public Guid ClientId { get; set; }
        public Guid SupplierId { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime ModifiedDate { get; set; }
        public string NotificationEmailAddress { get; set; }
        public string AccountCode { get; set; }
    }
}
