using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exercise3;

namespace ovningArv
{
    class Point3D: Point
    {
        public int Z { get; set; }
        public Point3D()
        {

        }
        public Point3D(int x,int y,int z):base(x,y)
        {
            Z = z;
        }
        public override string ToString() => $"X:{X}Y:{Y}Z:{Z}";
           }
}
