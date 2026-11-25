using System;
using System.Collections.Generic;

#nullable disable

namespace Demo.Core.Model
{
    public partial class PbInsurerCheckList
    {
        public Guid InsurerChecklistId { get; set; }
        public Guid InsurerId { get; set; }
        public Guid InsurerChecklistItemId { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime ModifiedDate { get; set; }
    }
}
