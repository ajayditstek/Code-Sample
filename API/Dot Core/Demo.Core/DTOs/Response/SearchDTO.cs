using System.ComponentModel.DataAnnotations;

namespace Demo.Core.DTOs.Response
{

    public class SearchDTO
    {
        [Required]
        public int PageNo { get; set; } = 1;
        [Required]
        public int PageSize { get; set; } = 10;
        public string SearchValue { get; set; }
        public string OrderBy { get; set; }
        public bool OrderByDescending { get; set; } = true;
        public bool AllRecords { get; set; } = false;
    }

}