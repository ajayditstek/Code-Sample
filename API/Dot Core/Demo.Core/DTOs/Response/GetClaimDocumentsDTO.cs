using System;
using System.Collections.Generic;

namespace Demo.Core.DTOs.Response
{
    public class GetClaimDocumentsDTO : ClaimDocument
    {
    }
    public class SearchClaimdocumentsDTO
    {
        public string ClaimId { get; set; }
    }
}