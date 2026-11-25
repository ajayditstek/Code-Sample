using System;
using System.Collections.Generic;

#nullable disable

namespace Demo.Core.Model
{
    public partial class GcFitmentInvoiceItem
    {
        public Guid FitmentInvoiceItemId { get; set; }
        public Guid FitmentInvoiceId { get; set; }
        public string ItemCode { get; set; }
        public string ItemDescription { get; set; }
        public decimal ItemQuantity { get; set; }
        public decimal ItemValue { get; set; }
        public decimal ItemVat { get; set; }
        public decimal LineItemValue { get; set; }
        public decimal LineItemVat { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime ModifiedDate { get; set; }
    }
}
