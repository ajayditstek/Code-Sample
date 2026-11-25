using System;
using System.Collections.Generic;

#nullable disable

namespace Demo.Core.Model
{
    public partial class PbInsurerUnderwriterAdministratorMapping
    {
        public Guid MappingId { get; set; }
        public Guid? UnderwriterId { get; set; }
        public Guid AdministratorId { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string ModifiedBy { get; set; }
        public Guid? InsurerId { get; set; }
    }
}
