using System;
using System.Collections.Generic;

#nullable disable

namespace Demo.Core.Model
{
    public partial class PastelMatchedItem
    {
        public Guid Id { get; set; }
        public decimal? Original { get; set; }
        public string Dc { get; set; }
        public string Cscode { get; set; }
        public decimal? Pperiod { get; set; }
        public DateTime? DDate { get; set; }
        public string Ref { get; set; }
        public string MatchRef { get; set; }
        public string Description { get; set; }
        public decimal? Amount { get; set; }
        public decimal? TaxType { get; set; }
        public decimal? TaxAmt { get; set; }
        public decimal? EntryType { get; set; }
        public decimal? LineFlag { get; set; }
        public decimal? CurrAmt { get; set; }
        public decimal? CurrTaxAmt { get; set; }
        public string Discount { get; set; }
        public string ExportNum { get; set; }
        public string BatchId { get; set; }
        public string UserDef { get; set; }
        public string RawData { get; set; }
        public DateTime? CreatedDate { get; set; }
        public bool? Ignore { get; set; }
        public string DemoNumber { get; set; }
    }
}
