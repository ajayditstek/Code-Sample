using System;
using System.Collections.Generic;

#nullable disable

namespace Demo.Core.Model
{
    public partial class MenuUserMapping
    {
        public Guid MenuUserMappingId { get; set; }
        public Guid? MenuItemId { get; set; }
        public Guid? UserId { get; set; }
        public bool? ItemEnabled { get; set; }
    }
}
