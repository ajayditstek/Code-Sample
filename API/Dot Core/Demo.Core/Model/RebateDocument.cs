using System;
using System.Collections.Generic;

#nullable disable

namespace Demo.Core.Model
{
    public partial class RebateDocument
    {
        public Guid? SupplierDocumentId { get; set; }
        public string DocumentNumber { get; set; }
        public Guid? SupplierId { get; set; }
        public Guid? ClientId { get; set; }
        public Guid? InsurerId { get; set; }
        public string Ronumber { get; set; }
        public Guid? ClaimId { get; set; }
        public DateTime? DocumentDate { get; set; }
        public decimal? DocumentTotal { get; set; }
        public string DemoNumber { get; set; }
        public string DocumentType { get; set; }
        public decimal? DemoPercent { get; set; }
        public decimal? DemoAmount { get; set; }
        public decimal? ClientPercent { get; set; }
        public decimal? ClientAmount { get; set; }
        public decimal? InsurerPercent { get; set; }
        public decimal? InsurerAmount { get; set; }
        public decimal? TotalPercent { get; set; }
        public decimal? TotalAmount { get; set; }
        public int? Year { get; set; }
        public int? Month { get; set; }
        public DateTime? InsertedDate { get; set; }
        public string InsertedBy { get; set; }
        public DateTime? ToPastelDate { get; set; }
        public string ToPastelBy { get; set; }
        public DateTime? RebateDueDate { get; set; }
    }
}
