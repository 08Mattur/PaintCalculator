using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace PaintCalculator.DTO
{
    public class Room
    {
        [Required(ErrorMessage = "Required Field.")]
        [Range(0.01, double.MaxValue, ErrorMessage = "Value must be greater than 0")]
        public double Width { get; set; }

        [Required(ErrorMessage = "Required Field.")]
        [Range(0.01, double.MaxValue, ErrorMessage = "Value must be greater than 0")]
        public double Length { get; set; }

        [Required(ErrorMessage = "Required Field.")]
        [Range(0.01, double.MaxValue, ErrorMessage = "Value must be greater than 0")]
        public double Height { get; set; }

        public double FloorArea
        {
            get
            {
                return Width * Length;
            }
        }

        public double Volume
        {
            get
            {
                return (Width * Length) * Height;
            }
        }

        public double WallArea
        {
            get
            {
                // 2 walls per side (length and width)
                double l = Length * 2;
                double w = Width * 2;

                // All walls added together for total length multiplied by height
                double ttlLength = l + w;
                ttlLength *= Height;


                // minus windows and doors
                foreach(Window win in Windows)
                {
                    ttlLength -= win.Area;
                }
                foreach (Door d in Doors)
                {
                    ttlLength -= d.Area;
                }

                return ttlLength;
            }
        }

        public List<Door> Doors { get; set; }
        public List<Window> Windows { get; set; }

        public Room()
        {
            Doors = new List<Door>();
            Windows = new List<Window>();
        }

    }


    public class Door
    {
        [Required(ErrorMessage = "Required Field.")]
        [Range(0.01, double.MaxValue, ErrorMessage = "Value must be greater than 0")]
        public double Height { get; set; }

        [Required(ErrorMessage = "Required Field.")]
        [Range(0.01, double.MaxValue, ErrorMessage = "Value must be greater than 0")]
        public double Width { get; set; }

        public double Area
        {
            get
            {
                return Height * Width;
            }
        }
    }

    public class Window
    {
        [Required(ErrorMessage = "Required Field.")]
        [Range(0.01, double.MaxValue, ErrorMessage = "Value must be greater than 0")]
        public double Height { get; set; }

        [Required(ErrorMessage = "Required Field.")]
        [Range(0.01, double.MaxValue, ErrorMessage = "Value must be greater than 0")]
        public double Width { get; set; }

        public double Area
        {
            get
            {
                return Height * Width;
            }
        }
    }

}
