using System;
using System.Collections.Generic;

#nullable disable

namespace Demo.Core.Model
{
    public partial class PbBankUploadDataItem
    {
        public Guid BankUploadDataItemsId { get; set; }
        public Guid BankUploadDataId { get; set; }
        public Guid? PaymentBatchId { get; set; }
        public string BatchName { get; set; }
        public string BankAccountNumber { get; set; }
        public string BankName { get; set; }
        public string BankBranchCode { get; set; }
        public string BankAccountHolderName { get; set; }
        public Guid? ClaimId { get; set; }
        public string DemoNumber { get; set; }
        public DateTime? FinalInvoiceAuthorisedDate { get; set; }
        public string LineFileData { get; set; }
    }
}
