using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Demo.Core.Model
{
    public class ErrorLog
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ErrorLogId { get; set; }
        [Column(TypeName = "nvarchar(1000)")]
        public string ExceptionType { get; set; }
        [Column(TypeName = "nvarchar(max)")]
        public string ExceptionMessage { get; set; }
        [Column(TypeName = "nvarchar(max)")]
        public string ExceptionSource { get; set; }
        public DateTime? LogDateTime { get; set; }

    }
}