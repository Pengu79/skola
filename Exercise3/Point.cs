using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3
{
    public class Point
    {
        private int y, x;
        
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
        public Point()
        {

        }
        public Point(int x,int y)
        {
            this.X = x;
            this.Y = y;
        }

        /*Old School
        public void SetX(int x) { this.x = x; }
        public int GetX() { return x; }
        public void SetY(int y) { this.y = y; }
        public int GetY() { return y; }
        */
    }
}
