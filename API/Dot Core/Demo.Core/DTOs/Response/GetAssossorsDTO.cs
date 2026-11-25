using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Core.DTOs.Response
{
    public class GetAssessorsDTO
    {
        public Guid AssessorComapnyId { get; set; }
        public string CompanyName { get; set; }
        public List<AssessorDetails> AssessorDetails { get; set; }

    }
    public class AssessorDetails
    {
        public Guid AssessorDetailId { get; set; }
        public Guid AssessorComapnyId { get; set; }
        public string AssessorName { get; set; }
        public string ContactDetails { get; set; }
    }
}
