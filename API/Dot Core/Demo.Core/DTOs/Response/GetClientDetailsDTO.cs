using System;
using System.Collections.Generic;

namespace Demo.Core.DTOs.Response
{
    public class GetClientDetailsDTO
    {
        public Guid ClientId { get; set; }
        public List<ClientSupplier> ClientSuppliers { get; set; }
        public List<ClientInsurer> ClientInsurers { get; set; }
    }

    public class ClientSupplier
    {
        public Guid SupplierId { get; set; }
        public string SupplierName { get; set; }
    }
    public class ClientInsurer
    {
        public Guid InsurerId { get; set; }
        public string InsurerName { get; set; }
    }

    public class SearchClientDetailsDTO
    {
        public string ClientId { get; set; }
    }
}