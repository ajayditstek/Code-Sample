using System;
using System.Collections.Generic;

#nullable disable

namespace Demo.Core.Model
{
    public partial class PbBankUploadDataReversal
    {
        public Guid BankUploadDataReversalId { get; set; }
        public string FileData { get; set; }
        public DateTime FileProcessedDate { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
    }
}
