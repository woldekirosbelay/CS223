using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3rd_Assigment
{
    public class Rectangle : Shape
    {
        public double width { get; set; }
        public double height { get; set; }
        public double getArea()
        {
            return width * height;
        }

        public double getPerimeter()
        {
            return (2*width) + (2*height);
        }
    }
}
