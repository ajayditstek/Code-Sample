using System;
using System.Collections.Generic;

#nullable disable

namespace Demo.Core.Model
{
    public partial class PbProductDefinition
    {
        public Guid ProductDefinitionId { get; set; }
        public string Description { get; set; }
        public decimal? InvoiceDiscountPercentage { get; set; }
        public bool? Deleted { get; set; }
    }
}
