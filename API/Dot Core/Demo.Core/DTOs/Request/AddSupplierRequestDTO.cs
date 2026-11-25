using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Core.DTOs.Request
{
    public class AddSupplierRequestDTO
    {
        public string SupplierName { get; set; }
        public string Email { get; set; }
        public string TelNumber { get; set; }
        public string FaxNumber { get; set; }
        public string CellNumber { get; set; }
        public string PhysicalAddress1 { get; set; }
        public string PhysicalAddress2 { get; set; }
        public string PhysicalAddress3 { get; set; }
        public string PhysicalAddressCode { get; set; }
        public string CompanyRegNumber { get; set; }
        public decimal EstimatedMonthlyPurchases { get; set; }
        public string PostalAddress1 { get; set; }
        public string PostalAddress2 { get; set; }
        public string PostalAddress3 { get; set; }
        public string PostalAddressCode { get; set; }
        public string ActionPerformedBy { get; set; }
    }
}
