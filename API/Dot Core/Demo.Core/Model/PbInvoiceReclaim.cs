using System;
using System.Collections.Generic;

#nullable disable

namespace Demo.Core.Model
{
    public partial class PbInvoiceReclaim
    {
        public Guid InvoiceReclaimId { get; set; }
        public Guid SupplierDocumentId { get; set; }
        public decimal? ItemValue { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string ModifiedBy { get; set; }
        public Guid? ClientId { get; set; }
        public Guid? LinkId { get; set; }
    }
}
