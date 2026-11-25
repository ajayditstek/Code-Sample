using System;
using System.ComponentModel.DataAnnotations;

namespace Demo.Core.DTOs.Response
{
    public class GetUnassignedSupplierBrandsDTO
    {
        public Guid BrandId { get; set; }
        public string Brand { get; set; }
    }

    public class SearchUnassignedSupplierBrandsDTO
    {
        [Required]
        public string SupplierId { get; set; }
    }
}