using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Core.DTOs.Request
{
    public class DeleteClaimDTO
    {
        public string ClaimId { get; set; }
        public string ActionPerformedBy { get; set; }
    }
}
