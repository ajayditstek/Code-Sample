using System;
using System.Collections.Generic;

#nullable disable

namespace Demo.Core.Model
{
    public partial class PbAssessorDetail
    {
        public Guid AssessorDetailId { get; set; }
        public Guid AssessorCompanyId { get; set; }
        public string AssessorName { get; set; }
        public string ContactDetails { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
    }
}
