using System;
using System.Collections.Generic;

#nullable disable

namespace Demo.Core.Model
{
    public partial class BankDeposit
    {
        public Guid PaymentDepositId { get; set; }
        public decimal? DepositAmount { get; set; }
        public string DepositReference { get; set; }
        public DateTime DepositDate { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public Guid? CsvFileId { get; set; }
        public Guid? ClientId { get; set; }
    }
}
