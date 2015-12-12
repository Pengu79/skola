using System.Security.AccessControl;

namespace Exercise6
{
    public class Point3D
    {
        private int x;
        private int y;
        private int z;

        public int Z
        {
            get { return z; }
            set { z = value; }
        }

        public int Y
        {
            get { return y; }
            set { y = value; }
        }

        public int X
        {
            get { return x; }
            set { x = value; }
        }

        public Point3D(int x, int y, int z = 0)
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }
    public  s
        public override string ToString()
        {
            return $"X:{X}\n\rZ:{Z}\n\rY:{Y}";
        }
    }
}