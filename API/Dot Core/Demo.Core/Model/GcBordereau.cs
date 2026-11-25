using System;
using System.Collections.Generic;

#nullable disable

namespace Demo.Core.Model
{
    public partial class GcBordereau
    {
        public Guid BordereauId { get; set; }
        public Guid InsurerId { get; set; }
        public string BordereauNumber { get; set; }
        public DateTime BordereauStartDate { get; set; }
        public DateTime BordereauEndDate { get; set; }
    }
}
