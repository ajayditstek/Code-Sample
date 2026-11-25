using System;
using System.Collections.Generic;

namespace Demo.Core.DTOs.Response
{
    public class GetSupplierDetailsDTO
    {
        
        public Guid SupplierId { get; set; }
        public string SupplierName { get; set; }
        public string SupplierTradingName { get; set; }
        public string CompanyRegNumber { get; set; }
        public string VatregNumber { get; set; }
        public string ExternalId { get; set; }
        public string Email { get; set; }
        public string NotificationEmailAddress { get; set; }
        public string TelNumber { get; set; }
        public string FaxNumber { get; set; }
        public string CellNumber { get; set; }
        public string BankName { get; set; }
        public string BankBranchName { get; set; }
        public string BankAccountHolder { get; set; }
        public string BankAccountNumber { get; set; }
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
         public int? SyncFlag { get; set; }
        public string Region { get; set; }
        public string IntegrationName { get; set; }
        public string AccountCode { get; set; }
        public string Brand { get; set; }
        public string SupplierGroupName { get; set; }
        public string PaymentTerms { get; set; }
        public string City { get; set; }
        public bool? PaymentsLessRebateStructure { get; set; }
        public bool? OnHold { get; set; }
        public string OnHoldReason { get; set; }
        public bool? NoCodfee { get; set; }
        public string SupplierType { get; set; }
        public string BranchCode { get; set; }
        public Guid? RegionId { get; set; }
        public Guid? CityId { get; set; }
        public Guid? SuburbId { get; set; }
        public bool? SuppliesGlass { get; set; }
        public string PastelCategory { get; set; }
        public string NotificationEmailAddressBcc { get; set; }
        public Guid? SupplierGroupId { get; set; }
        public bool? Obselete { get; set; }
        public string RemittanceContactPerson { get; set; }
        public string RemittanceContactEmail { get; set; }
        public DateTime? PastelConfirmDate { get; set; }
        public string PastelConfirmData { get; set; }
        public string ContactPerson { get; set; }
        public string CreditorDepartmentEmailAddress { get; set; }
        public string BankingDetailsModifiedBy { get; set; }
        public DateTime? BankingDetailsModifiedDate { get; set; }
        public List<SupplierExternalName> SupplierExternalNames { get; set; }
        public List<SupplierClient> SupplierClients { get; set; }
        public List<SupplierBrand> Brands { get; set; }
        public decimal TotalPercent { get; set; }
        public List<AssignedLocation> AssignedCities { get; set; }
        public List<AssignedLocation> AssignedRegions { get; set; }
    }

    public class SearchSupplierDetailsDTO
    {
        public string SupplierId { get; set; }
    }
    public class SupplierExternalName
    {
        public Guid SupplierMappingId { get; set; }
        public Guid SupplierId { get; set; }
        public string ExternalName { get; set; }
    }
    public class SupplierClient
    {
        public Guid ClientSupplierId { get; set; }
        public Guid SupplierId { get; set; }
        public string ClientName { get; set; }
        public string AccountCode { get; set; }
    }
    public class SupplierBrand
    {
        public Guid? SupplierId { get; set; }
        public Guid BrandId { get; set; }
        public string Brand { get; set; }
    }

    public class AssignedLocation
    {
        public Guid LocationId { get; set; }
        public string Type { get; set; }
        public string Description { get; set; }
        public Guid? ParentLocationId { get; set; }
        public bool IsAssigned { get; set; }
        public bool IsRemoved { get; set; }
    }
    public class AssignedLocations
    {
        public List<AssignedLocation> AssignedCities { get; set; }
        public List<AssignedLocation> AssignedRegions { get; set; }
    }
}