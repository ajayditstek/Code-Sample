using System;
using System.Collections.Generic;

#nullable disable

namespace Demo.Core.Model
{
    public partial class UserFunctionAllocation
    {
        public Guid UserFunctionAllocationId { get; set; }
        public string UserName { get; set; }
        public string FunctionType { get; set; }
        public Guid? AllocationId { get; set; }
    }
}
