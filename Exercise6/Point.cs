namespace Exercise6
{
    public class Point
    {
        private int x;
        private int y;

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

        public Point(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        public override string ToString()
        {
            return $"X:{X}\n\rY:{Y}";
        }

        public static implicit operator Point3D(Point point)
        {
            return new Point(point.X,point.Y);
        }
    }
}