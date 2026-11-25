using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Core.DTOs.Response
{
    public class GetAllClaimsDTO
    {
        public Guid? ClaimId { get; set; }
        public string ClientName { get; set; }
        public string JobCardNo { get; set; }
        public string PBFinalInvoiceNo { get; set; }
        public string DemoNo { get; set; }
        public string InsurerClaimNumber { get; set; }
        public string InsuredName { get; set; }
        public string VehicleMake { get; set; }
        public string VehicleRegistrationNumber { get; set; }
        public decimal? NetClaimAmount { get; set; }
        public decimal? TotalPartsValue { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string Status { get; set; }

    }
    public class SearchAllClaimsDTO : SearchDTO
    {
        public string ClientId { get; set; }
    }
}
