using System;

namespace Demo.Core.DTOs.Response
{
    public class GetRequestedSuppliersDTO
    {
        public Guid SupplierRegisterId { get; set; }
        public string SupplierName { get; set; }
        public string CompanyRegNumber { get; set; }
        public string VATRegNumber { get; set; }
        public string Email { get; set; }
        public string TelNumber { get; set; }
        public string FaxNumber { get; set; }
        public string CellNumber { get; set; }
        public string PhysicalAddr1 { get; set; }
        public string PhysicalAddr2 { get; set; }
        public string PhysicalAddr3 { get; set; }
        public string PhysicalAddrCode { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
       
    }

    public class SearchRequestedSuppliersDTO : SearchDTO
    {
        
    }
}