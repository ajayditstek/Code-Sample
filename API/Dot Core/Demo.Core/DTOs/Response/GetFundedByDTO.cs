using System;

namespace Demo.Core.DTOs.Response
{
    public class GetFundedByDTO
    {
        public Guid FactorerId { get; set; }
        public string FactorerName { get; set; }
    }
}
