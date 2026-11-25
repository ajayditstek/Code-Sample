using System;

namespace Demo.Core.DTOs.Response
{
    public class GetSuppliersDTO
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
    }

    public class SearchSuppliersDTO : SearchDTO
    {
        public string SupplierId { get; set; }
    }

    public class GetSuppliersNameDTO
    {
         public Guid SupplierId { get; set; }
        public string SupplierName { get; set; }
    }

    public class SearchSuppliersNameDTO : SearchDTO
    {
    }

}