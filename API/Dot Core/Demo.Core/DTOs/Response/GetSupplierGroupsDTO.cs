using System;

namespace Demo.Core.DTOs.Response
{
    public class GetSupplierGroupsDTO
    {
        public Guid SupplierGroupId { get; set; }
        public string SupplierGroup { get; set; }
    }

    public class SearchSupplierGroupsDTO : SearchDTO
    {
        public string SupplierGroupId { get; set; }
    }
}