using System;
using System.Collections.Generic;

#nullable disable

namespace Demo.Core.Model
{
    public partial class SystemLog
    {
        public Guid Id { get; set; }
        public string InsertedBy { get; set; }
        public DateTime? InsertedOn { get; set; }
        public string Source { get; set; }
        public DateTime? EventDate { get; set; }
        public string EventData { get; set; }
        public string EventMessage { get; set; }
    }
}
