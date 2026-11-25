using System.Collections.Generic;

namespace Demo.Core.DTOs.Request
{
    public class AddSupplierBrandsDTO
    {
        public string SupplierId { get; set; }
        public List<SupplierBrands> Brands { get; set; }
    }
    public class SupplierBrands
    {
        public string BrandId { get; set; }
    }
}