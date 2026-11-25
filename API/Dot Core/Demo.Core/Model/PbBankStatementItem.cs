using System;
using System.Collections.Generic;

#nullable disable

namespace Demo.Core.Model
{
    public partial class PbBankStatementItem
    {
        public Guid BankStatementItemsId { get; set; }
        public Guid BankStatementId { get; set; }
        public string ItemDescription { get; set; }
        public decimal? ItemAmount { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string RawData { get; set; }
        public string ReconComment { get; set; }
        public DateTime? ItemDate { get; set; }
        public DateTime? FinalisedDate { get; set; }
        public string FinalisedBy { get; set; }
        public Guid? RemittanceDocumentId { get; set; }
        public DateTime? RemittanceAddedDate { get; set; }
        public string RemittanceAddedBy { get; set; }
        public Guid? RefundDocumentId { get; set; }
        public DateTime? RefundAddedDate { get; set; }
        public string RefundAddedBy { get; set; }
        public string AuthorisedBy { get; set; }
        public DateTime? AuthorisedDate { get; set; }
    }
}
