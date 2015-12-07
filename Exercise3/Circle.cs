using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3
{
    public class Circle
    {
        private double diameter;
        private Point center;

        public void SetDiameter(string diameter)
        {
            if (!double.TryParse(diameter, out this.diameter))
            {
                Console.WriteLine("Something went wrong");
            }
        }
        public double GetDiameter() { return diameter; }
        public double GetCircumference() { return this.diameter * Math.PI; }

        public void SetCenter(Point p) { this.center = p; }
        public Point GetCenter() { return center; }
    }
}
