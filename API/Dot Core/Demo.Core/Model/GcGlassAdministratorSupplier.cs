using System;
using System.Collections.Generic;

#nullable disable

namespace Demo.Core.Model
{
    public partial class GcGlassAdministratorSupplier
    {
        public Guid AdministratorSuppliersId { get; set; }
        public Guid AdministratorId { get; set; }
        public Guid SupplierId { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime ModifiedDate { get; set; }
    }
}
