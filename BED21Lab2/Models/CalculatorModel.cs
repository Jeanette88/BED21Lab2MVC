
using System.ComponentModel.DataAnnotations;

namespace BED21Lab2.Models
{
    public class CalculatorModel
    {
        [Required]
        public decimal ValueA { get; set; }

        [Required]
        public decimal ValueB { get; set; }
    }
}
