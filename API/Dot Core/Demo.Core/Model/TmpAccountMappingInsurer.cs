using System;
using System.Collections.Generic;

#nullable disable

namespace Demo.Core.Model
{
    public partial class TmpAccountMappingInsurer
    {
        public int Id { get; set; }
        public string ClientTradingAs { get; set; }
        public string ExtId { get; set; }
        public string Demonumber { get; set; }
        public string Insurer { get; set; }
        public double? InvoiceAmount { get; set; }
        public string ClaimNo { get; set; }
        public Guid? InsurerId { get; set; }
    }
}
