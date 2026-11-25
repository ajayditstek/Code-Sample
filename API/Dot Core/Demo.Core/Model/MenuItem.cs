using System;
using System.Collections.Generic;

#nullable disable

namespace Demo.Core.Model
{
    public partial class MenuItem
    {
        public Guid MenuItemId { get; set; }
        public string ItemText { get; set; }
        public string ItemUrl { get; set; }
        public Guid? ItemParent { get; set; }
        public int? DisplayOrder { get; set; }
    }
}
