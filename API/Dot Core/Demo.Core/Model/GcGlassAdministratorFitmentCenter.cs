using System;
using System.Collections.Generic;

#nullable disable

namespace Demo.Core.Model
{
    public partial class GcGlassAdministratorFitmentCenter
    {
        public Guid AdministratorFittersId { get; set; }
        public Guid AdministratorId { get; set; }
        public Guid FitmentCenterId { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime ModifiedDate { get; set; }
    }
}
