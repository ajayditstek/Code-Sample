using System;
using System.Collections.Generic;

#nullable disable

namespace Demo.Core.Model
{
    public partial class PbSuppliersRequest
    {
        public Guid RequestId { get; set; }
        public string SupplierName { get; set; }
        public string Email { get; set; }
        public string TelNumber { get; set; }
        public string FaxNumber { get; set; }
        public string CellNumber { get; set; }
        public string PhysicalAddr1 { get; set; }
        public string PhysicalAddr2 { get; set; }
        public string PhysicalAddr3 { get; set; }
        public string PhysicalAddrCode { get; set; }
        public string PostalAddr1 { get; set; }
        public string PostalAddr2 { get; set; }
        public string PostalAddr3 { get; set; }
        public string PostalAddrCode { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public bool? Completed { get; set; }
        public string DeclinedReason { get; set; }
        public DateTime? ProcessedDate { get; set; }
        public string Responce { get; set; }
        public decimal? EstimatedMonthlyPurchases { get; set; }
        public string PaymentTerms { get; set; }
        public string CompanyRegNumber { get; set; }
    }
}
