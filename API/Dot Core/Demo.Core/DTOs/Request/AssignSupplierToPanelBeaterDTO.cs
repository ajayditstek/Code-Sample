using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Core.DTOs.Request
{
    public class AssignSupplierToPanelBeaterDTO
    {
        public string ClientId { get; set; }
        public string SupplierId { get; set; }
        public string ActionPerformedBy { get; set; }
    }
}
