using System;
using System.Collections.Generic;

namespace Demo.Core.DTOs.Response
{
    public class GetFilteredSuppliersDTO
    {
        public string SupplierName { get; set; }
        public Guid SupplierId { get; set; }
        public decimal Rebate { get; set; }
        public string PaymentTerms { get; set; }
        public Guid RegionId { get; set; }
        public string SupplierType { get; set; }
        public Guid BrandId { get; set; }
        public string SupplierGroupName { get; set; }
        public bool? NoCODFee { get; set; }
        public Guid SupplierGroupId { get; set; }
    }

    public class SearchFilterSuppliersDTO
    {
        public string SupplierType { get; set; }
        public List<Brand> Brands { get; set; }
        public string RegionId { get; set; }
        public string SupplierGroupId { get; set; }
        public string SupplierName { get; set; }
        public bool HasSurcharge { get; set; }
        public bool NoCODFee { get; set; }
        public bool StartWith { get; set; }
        public bool AnyWhere { get; set; }
    }

    public class Brand
    {
        public string BrandId { get; set; }
    }

    public class FilteredDataDTO
    {
        public Guid SupplierId { get; set; }
        public string SupplierName { get; set; }
    }
}