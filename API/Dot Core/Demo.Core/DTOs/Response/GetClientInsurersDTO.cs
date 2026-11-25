using System;

namespace Demo.Core.DTOs.Response
{
    public class GetClientInsurersDTO
    {
        public Guid InsurerId { get; set; }
        public string InsurerType { get; set; }
        public string InsurerName { get; set; }
    }

    public class SearchClientInsurersDTO
    {
        public string ClientId { get; set; }
    }
}