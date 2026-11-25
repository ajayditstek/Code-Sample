using Microsoft.EntityFrameworkCore.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Core.DTOs.Response
{
    public class GetUnassignedSuppliersDataDTO
    {
        public List<GetUnassignedSuppliersDTO> SupplierAdditionalCharges { get; set; }
        public List<GetUnassignedSuppliersDTO> SupplierNoAdditionalCharges { get; set; }
    }
    public class GetUnassignedSuppliersDTO
    {
        public string SupplierName { get; set; }
        public Guid? SupplierId { get; set; }
        public decimal? ClientRebate { get; set; }
        public decimal? TotalRebate { get; set; }
        public string PaymentTerms { get; set; }
        public Guid? RegionId { get; set; }
        public Guid? SuppliesTo { get; set; }
        public string SupplierType { get; set; }
        public Guid? BrandId { get; set; }
        public Guid? SupplierGroupId { get; set; }
        public bool? NoCODFee { get; set; }
        public string Brands { get; set; }
    }

    public class SearchUnassignedSuppliersDTO 
    {
        public string ClientId { get; set; }
        public string SupplierType { get; set; }
        public string RegionId { get; set; }
        public string SuppliesToCityId { get; set; }
        public string SupplierGroupId { get; set; }
        public List<SearchBrand> Brands { get; set; }
        public string SupplierName { get; set; }
        public bool StartsWith { get; set; }
        public bool AnyWhere { get; set; }
        public string OrderBy { get; set; }
        public bool OrderByDescending { get; set; } = true;
        public bool AllRecords { get; set; } = false;

    }
    public class SearchBrand
    {
        public string BrandId { get; set; }
    }

}
