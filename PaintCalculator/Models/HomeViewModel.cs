using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace PaintCalculator.UI.Models
{
    public class HomeViewModel
    {
        public DTO.Room Room { get; set; }
        public DTO.Paint Paint { get; set; }

        [Required(ErrorMessage = "Required Field.")]
        [Range(1.0, double.MaxValue, ErrorMessage = "Value must be greater than 0")]
        public int Coats { get; set; }


        public double PaintRequired
        {
            get
            {
                return Room.WallArea / Paint.MLNumber;
            }
        }
        public double TinsRequired
        {
            get
            {
                return Math.Ceiling(PaintRequired / Paint.Capacity);
            }
        }

    }
}