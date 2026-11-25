using System;

namespace Demo.Core.DTOs.Response
{
    public class GetDefaultFundingDTO
    {
        public Guid ProductDefinitionId { get; set; }
        public string Description { get; set; }
        public decimal? InvoiceDiscountPercentage { get; set; }
    }
}