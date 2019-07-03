using System;

namespace lab_33_struct
{
    class Program
    {
        static void Main(string[] args)
        {
            var p01 = new Point(2, 3);
            var p02 = new Point(4, 7);
            var p03 = new Point(6, 12);
        }
    }

    class x { }

    enum fruits { }

    struct y { }

    public struct Point
    {
        // STORE POINTS ON A GRAPH
        public int X;  // class because public
        public int Y;

        public Point(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }
    }
}
