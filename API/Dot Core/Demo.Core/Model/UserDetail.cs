using System;
using System.Collections.Generic;

#nullable disable

namespace Demo.Core.Model
{
    public partial class UserDetail
    {
        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string DisplayName { get; set; }
        public string EmailAddress { get; set; }
        public string ReportsTo { get; set; }
        public string LuDepartment { get; set; }
        public bool? Active { get; set; }
        public string AssignedSystem { get; set; }
    }
}
