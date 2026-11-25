using System;
using System.Collections.Generic;

#nullable disable

namespace Demo.Core.Model
{
    public partial class PbSupplierCodpaymentBatch
    {
        public Guid CodbatchId { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public string PaidBy { get; set; }
        public string PaidDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ClosedOffDate { get; set; }
        public string ClosedOffBy { get; set; }
        public string BatchName { get; set; }
    }
}
