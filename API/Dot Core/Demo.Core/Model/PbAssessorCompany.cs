using System;
using System.Collections.Generic;

#nullable disable

namespace Demo.Core.Model
{
    public partial class PbAssessorCompany
    {
        public Guid AssessorCompanyId { get; set; }
        public string CompanyName { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
    }
}
