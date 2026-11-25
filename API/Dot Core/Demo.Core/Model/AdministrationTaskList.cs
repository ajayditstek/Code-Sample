using System;
using System.Collections.Generic;

#nullable disable

namespace Demo.Core.Model
{
    public partial class AdministrationTaskList
    {
        public Guid Id { get; set; }
        public string TaskType { get; set; }
        public string TaskName { get; set; }
        public string Recipients { get; set; }
        public string Sqlquery { get; set; }
        public DateTime? NextRunTime { get; set; }
        public string NextRunInterval { get; set; }
        public int? NextRunIntervalQuantity { get; set; }
        public int? Active { get; set; }
    }
}
