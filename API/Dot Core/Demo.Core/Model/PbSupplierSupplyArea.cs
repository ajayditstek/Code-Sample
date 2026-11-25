using System;
using System.Collections.Generic;

#nullable disable

namespace Demo.Core.Model
{
    public partial class PbSupplierSupplyArea
    {
        public Guid SupplyAreaId { get; set; }
        public Guid SupplierId { get; set; }
        public Guid CityId { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? ModeifiedDate { get; set; }
        public string ModifiedBy { get; set; }
    }
}
