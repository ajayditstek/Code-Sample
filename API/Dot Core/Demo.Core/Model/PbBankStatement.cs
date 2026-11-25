using System;
using System.Collections.Generic;

#nullable disable

namespace Demo.Core.Model
{
    public partial class PbBankStatement
    {
        public Guid BankStatementId { get; set; }
        public string BankHolderName { get; set; }
        public DateTime? StatementDate { get; set; }
        public decimal? OpeningBalance { get; set; }
        public decimal? ClosingBalance { get; set; }
        public decimal? TransactionTotalValue { get; set; }
        public int? TransactionCount { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public Guid? ClientId { get; set; }
    }
}
