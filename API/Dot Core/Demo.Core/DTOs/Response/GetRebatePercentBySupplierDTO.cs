using System;

namespace Demo.Core.DTOs.Response
{
    public class GetRebatePercentBySupplierDTO
    {
        public Guid RebateStructureId { get; set; }
        public string SupplierName { get; set; }
        public string SupplierTradingName { get; set; }
        public string InsurerName { get; set; }
        public string ClientName { get; set; }
        public decimal DemoPercent { get; set; }
        public decimal ClientPercent { get; set; }
        public decimal InsurerPercent { get; set; }
        public decimal TotalPercent { get; set; }
        public DateTime EffectiveDate { get; set; }
    }
    public class SearchRebatePercentBySupplierDTO
    {
        public Guid? SupplierId { get; set; }
        public Guid? InsurerId { get; set; }
        public Guid? ClientId { get; set; }
        public bool ShowDistinct { get; set; }
    }
}