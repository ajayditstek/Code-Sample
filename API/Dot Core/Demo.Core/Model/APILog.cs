using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Demo.Core.Model
{
    public class APILog
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int APILogId { get; set; }
        public int? ErrorLogId { get; set; }
        [Column(TypeName = "nvarchar(1000)")]
        public string APIUrl { get; set; }
        [Column(TypeName = "nvarchar(max)")]
        public string APIParams { get; set; }
        [Column(TypeName = "nvarchar(4000)")]
        public string Headers { get; set; }
        [Column(TypeName = "nvarchar(20)")]
        public string Method { get; set; }
        [DefaultValue(false)]
        public bool Success { get; set; }
        public DateTime? StartDateTime { get; set; }
        public DateTime? EndDateTime { get; set; }
    }
}