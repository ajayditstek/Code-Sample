using System;
using System.Collections.Generic;

#nullable disable

namespace Demo.Core.Model
{
    public partial class PastelContingencyLedger
    {
        public Guid Id { get; set; }
        public string AccountNo { get; set; }
        public string AccountName { get; set; }
        public string Gdc { get; set; }
        public int? Period { get; set; }
        public DateTime? Date { get; set; }
        public string Refrence { get; set; }
        public string TransactionDescription { get; set; }
        public string JobCode { get; set; }
        public decimal? Amount { get; set; }
        public decimal? TaxAmount { get; set; }
        public decimal? Total { get; set; }
        public decimal? OpenBal { get; set; }
        public string Type { get; set; }
        public string UserId { get; set; }
        public string BatchId { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string DemoNumber { get; set; }
        public string ExternalId { get; set; }
    }
}
