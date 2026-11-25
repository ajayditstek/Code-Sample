using System;
using System.Collections.Generic;

#nullable disable

namespace Demo.Core.Model
{
    public partial class MasterCorrespondance
    {
        public Guid MasterId { get; set; }
        public string MessageName { get; set; }
        public string MessageType { get; set; }
        public string Template { get; set; }
        public string TemplateSubject { get; set; }
        public string AttachmentFilenames { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
    }
}
