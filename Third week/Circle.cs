using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3rd_Assigment
{
    public class Circle : Shape
    {
        public double radius { get; set; }
        const double pi = 3.14;

        public double getPerimeter()
        {
            return 2*pi*radius;
        }

        public double getArea()
        {
            return pi*(radius*radius);
        }
    }
}
