using System;
using System.Collections.Generic;

#nullable disable

namespace Demo.Core.Model
{
    public partial class PbRebateStructure
    {
        public Guid RebateStructureId { get; set; }
        public Guid ClientId { get; set; }
        public Guid SupplierId { get; set; }
        public Guid InsurerId { get; set; }
        public decimal DemoPercent { get; set; }
        public decimal ClientPercent { get; set; }
        public decimal InsurerPercent { get; set; }
        public decimal TotalPercent { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public DateTime? EffectiveDate { get; set; }
    }
}
