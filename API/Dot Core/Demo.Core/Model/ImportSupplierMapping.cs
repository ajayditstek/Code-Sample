using System;
using System.Collections.Generic;

#nullable disable

namespace Demo.Core.Model
{
    public partial class ImportSupplierMapping
    {
        public Guid SupplierMappingId { get; set; }
        public Guid DemoSupplierId { get; set; }
        public string SupplierNameExternal { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime ModifiedDate { get; set; }
    }
}
