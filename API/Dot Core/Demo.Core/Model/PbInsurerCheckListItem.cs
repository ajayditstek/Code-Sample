using System;
using System.Collections.Generic;

#nullable disable

namespace Demo.Core.Model
{
    public partial class PbInsurerCheckListItem
    {
        public Guid InsurerChecklistItemId { get; set; }
        public string CheckListItem { get; set; }
        public bool Default { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime ModifiedDate { get; set; }
        public string Category { get; set; }
    }
}
