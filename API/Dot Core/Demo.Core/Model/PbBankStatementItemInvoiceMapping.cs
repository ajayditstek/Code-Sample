using System;
using System.Collections.Generic;

#nullable disable

namespace Demo.Core.Model
{
    public partial class PbBankStatementItemInvoiceMapping
    {
        public Guid InvoiceMappingId { get; set; }
        public Guid? BankStatementItemId { get; set; }
        public string InvoiceNumber { get; set; }
        public string DemoNumber { get; set; }
        public decimal? InvoiceAmount { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? PrintedDate { get; set; }
        public string PrintedBy { get; set; }
        public decimal? Contingency { get; set; }
        public decimal? PaidDirectToPb { get; set; }
        public decimal? ShortFall { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public Guid? ClaimId { get; set; }
    }
}
