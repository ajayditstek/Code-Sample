using System;
using System.Collections.Generic;

#nullable disable

namespace Demo.Core.Model
{
    public partial class PbSupplierBrand
    {
        public Guid PanelBeaterBrandId { get; set; }
        public Guid? BrandId { get; set; }
        public Guid? SupplierId { get; set; }
    }
}
