using System;

namespace Demo.Core.DTOs.Response
{
    public class GetPanelBeaterInsurersDTO
    {
        public Guid InsurerId { get; set; }
        public string InsurerName { get; set; }
    }
}