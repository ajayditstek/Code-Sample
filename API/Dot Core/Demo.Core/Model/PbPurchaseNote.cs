using System;
using System.Collections.Generic;

#nullable disable

namespace Demo.Core.Model
{
    public partial class PbPurchaseNote
    {
        public Guid PurchaseNoteId { get; set; }
        public Guid? ClaimId { get; set; }
        public decimal? TotalInvoiceAmount { get; set; }
        public decimal? Discount { get; set; }
        public decimal? FundingAmount { get; set; }
        public decimal? PartsPurchasedByDemo { get; set; }
        public decimal? DemoToPay { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string ModifiedBy { get; set; }
        public decimal? SecurityAmount { get; set; }
    }
}
