using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Core.DTOs.Request
{
    public class UpdateClaimDraftDTO : AddClaimDraftDTO
    {
        public string ClaimDraftId { get; set; }
       
    }
}
