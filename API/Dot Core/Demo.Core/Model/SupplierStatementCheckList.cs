using System;
using System.Collections.Generic;

#nullable disable

namespace Demo.Core.Model
{
    public partial class SupplierStatementCheckList
    {
        public Guid SupplierStatementId { get; set; }
        public Guid? SupplierId { get; set; }
        public int? StatementMonth { get; set; }
        public int? StatementYear { get; set; }
        public string ReceivedBy { get; set; }
        public DateTime? ReceivedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string ReconciledBy { get; set; }
        public DateTime? ReconciledDate { get; set; }
        public string PaidBy { get; set; }
        public DateTime? PaidDate { get; set; }
    }
}
