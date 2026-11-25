using System;
using System.Collections.Generic;
using Demo.Core.DTOs.Response;

namespace Demo.Core.DTOs.Request
{
    public class AddSupplierDTO
    {
        public string SupplierName { get; set; }
        public string SupplierTradingName { get; set; }
        public string CompanyRegNumber { get; set; }
        public string VATRegNumber { get; set; }
        public string ContactPerson { get; set; }
        public string Email { get; set; }
        public string NotificationEmailAddress { get; set; }
        public string TelNumber { get; set; }
        public string FaxNumber { get; set; }
        public string CellNumber { get; set; }
        public bool NoCODFee { get; set; }
        public string PhysicalAddr1 { get; set; }
        public string PhysicalAddr2 { get; set; }
        public string PhysicalAddr3 { get; set; }
        public string PhysicalAddrCode { get; set; }
        public string PostalAddr1 { get; set; }
        public string PostalAddr2 { get; set; }
        public string PostalAddr3 { get; set; }
        public string PostalAddrCode { get; set; }
        public bool PaymentsLessRebateStructure { get; set; }
        public bool SuppliesGlass { get; set; }
        public string ExternalId { get; set; }
        public string SupplierGroupId { get; set; }
        public string RegionId { get; set; }
        public string SupplierType { get; set; }
        public string CityId { get; set; }
        public string SuburbId { get; set; }
        public decimal SupplierPercent { get; set; }
        public decimal ClientPercent { get; set; }
        public decimal InsurerPercent { get; set; }
        public decimal DemoPercent { get; set; }
        public string ActionPerformedBy { get; set; }
        public List<SupplierBrands> Brands { get; set; }
    }

    public class AddRebateStructureDTO
    {
        public DateTime EffectiveDate { get; set; }
        public Guid SupplierId { get; set; }
        public Guid? ClientId { get; set; }
        public Guid? InsurerId { get; set; }
        public decimal DemoPercent { get; set; }
        public decimal ClientPercent { get; set; }
        public decimal InsurerPercent { get; set; }
        public decimal TotalPercent { get; set; }
        public string UserName { get; set; }
    }
}
