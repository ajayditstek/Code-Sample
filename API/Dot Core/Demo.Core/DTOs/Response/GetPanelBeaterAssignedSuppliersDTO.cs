using System;
namespace Demo.Core.DTOs.Response
{
    public class GetPanelBeaterAssignedSuppliersDTO
    {
        public Guid SupplierId { get; set; }
        public string SupplierName { get; set; }
        public decimal? ClientRebate { get; set; }
        public decimal? TotalRebate { get; set; }
        public string PaymentTerms { get; set; }
        public bool? NoCODFee { get; set; }
    }
    public class SearchPanelBeaterAssignedSuppliersDTO : SearchDTO
    {
        public string ClientId { get; set; }
    }
}