using System.ComponentModel.DataAnnotations;

namespace BED21Lab2.Models
{
    public class PersonFormModel
    {
        [Required]
        public string? Fname { get; set; }
        [Required]
        public int Age { get; set; }
        public bool IsSeahawkFan { get; set; }
    }
}
