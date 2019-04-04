using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace PaintCalculator.DTO
{
    public class Paint
    {
        [Required(ErrorMessage = "Required Field.")]
        [Range(0, int.MaxValue, ErrorMessage = "Value must be greater than 0")]
        public int MLNumber { get; set; }

        [Required(ErrorMessage = "Required Field.")]
        [Range(0.01, double.MaxValue, ErrorMessage = "Value must be greater than 0")]
        public double Capacity { get; set; }
        
    }
}
