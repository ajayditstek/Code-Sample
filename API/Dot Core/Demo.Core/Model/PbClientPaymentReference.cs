using System;
using System.Collections.Generic;

#nullable disable

namespace Demo.Core.Model
{
    public partial class PbClientPaymentReference
    {
        public Guid ClientPaymentReferenceId { get; set; }
        public Guid PaymentBatchId { get; set; }
        public Guid ClientId { get; set; }
        public string DemoReference { get; set; }
        public string ClientReference { get; set; }
        public decimal? PaymentValue { get; set; }
        public DateTime? PaymentDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public Guid? ClaimId { get; set; }
        public Guid? SupplierDocumentId { get; set; }
    }
}
