using System;

namespace Demo.Core.DTOs.Response
{
    public class GetSupplierBrandsDTO
    {
        public string Brand { get; set; }
    }
    
    public class SearchSupplierBrandsDTO
    {
        public Guid SupplierId { get; set; }
    }
}
