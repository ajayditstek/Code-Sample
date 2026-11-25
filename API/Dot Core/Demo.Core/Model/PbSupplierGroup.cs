using System;
using System.Collections.Generic;

#nullable disable

namespace Demo.Core.Model
{
    public partial class PbSupplierGroup
    {
        public Guid SupplierGroupId { get; set; }
        public string SupplierGroup { get; set; }
        public string DefaultPastelAccountCode { get; set; }
    }
}
