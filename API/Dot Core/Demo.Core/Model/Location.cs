using System;
using System.Collections.Generic;

#nullable disable

namespace Demo.Core.Model
{
    public partial class Location
    {
        public Guid LocationId { get; set; }
        public string Type { get; set; }
        public string Description { get; set; }
        public Guid? ParentLocationId { get; set; }
    }
}
