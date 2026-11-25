using System;
using System.Collections.Generic;

#nullable disable

namespace Demo.Core.Model
{
    public partial class MenuRoleMapping
    {
        public Guid MenuRoleMappingId { get; set; }
        public Guid? MenuItemId { get; set; }
        public Guid? RoleId { get; set; }
    }
}
