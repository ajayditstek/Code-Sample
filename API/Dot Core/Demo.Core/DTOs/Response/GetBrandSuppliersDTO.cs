using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Core.DTOs.Response
{
    public class GetBrandSuppliersDTO
    {
        public Guid PanelBeaterBrandId { get; set; }
        public Guid? BrandId { get; set; }
        public string SupplierName { get; set; }
        public Guid? SupplierId { get; set; }
    }
    public class SearchBrandSuppliersDTO : SearchDTO
    {
        public string BrandId { get; set; }
    }
}
