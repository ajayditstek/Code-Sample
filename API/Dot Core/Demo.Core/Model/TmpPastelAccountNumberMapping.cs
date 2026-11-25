using System;
using System.Collections.Generic;

#nullable disable

namespace Demo.Core.Model
{
    public partial class TmpPastelAccountNumberMapping
    {
        public string ClientNo { get; set; }
        public Guid? ClientId { get; set; }
        public string AccNo { get; set; }
        public string QuoteNo { get; set; }
        public string InsurerCode { get; set; }
        public Guid? InsurerId { get; set; }
    }
}
