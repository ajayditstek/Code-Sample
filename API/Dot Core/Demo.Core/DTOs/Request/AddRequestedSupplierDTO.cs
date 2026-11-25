using System.Collections.Generic;

namespace Demo.Core.DTOs.Request
{
    public class AddRequestedSupplierDTO
    {
        public string SupplierRegisterId { get; set; }
        public string SupplierName { get; set; }
        public string SupplierTradingName { get; set; }
        public string CompanyRegNumber { get; set; }
        public string VATRegNumber { get; set; }
        // public string ContactPerson { get; set; }
        public string Email { get; set; }
        public string NotificationEmailAddress { get; set; }
        public string TelNumber { get; set; }
        public string FaxNumber { get; set; }
        public string CellNumber { get; set; }
        // public bool NoCODFee { get; set; }
        public string PhysicalAddr1 { get; set; }
        public string PhysicalAddr2 { get; set; }
        public string PhysicalAddr3 { get; set; }
        public string PhysicalAddrCode { get; set; }
        public string PostalAddr1 { get; set; }
        public string PostalAddr2 { get; set; }
        public string PostalAddr3 { get; set; }
        public string PostalAddrCode { get; set; }
        public bool PaymentsLessRebateStructure { get; set; }
        public string ExternalId { get; set; }
        // public bool Obselete { get; set; }
        public string SupplierGroupId { get; set; }
        public string Region { get; set; }
        // public string SupplierType { get; set; }
        // public decimal SupplierPercent { get; set; }
        // public decimal ClientPercent { get; set; }
        // public decimal InsurerPercent { get; set; }
        // public decimal DemoPercent { get; set; }
        public string ActionPerformedBy { get; set; }
        public List<SupplierBrands> Brands { get; set; }
      
    }
}