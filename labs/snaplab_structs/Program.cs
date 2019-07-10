using System;
using System.Collections.Generic;
using System.Linq;

namespace snaplab_structs
{

    /* Snap lab: 10 minutes

            Create struct point with x,y

            List<point> points...

            create 3 points and add to list

            loop over collection

                Find highest x value and independently highest y value

                Bonus : lowest also

                Also find range (max X- min X) and (max Y-min Y) */

    class Program
    {
        static List<Point> Points = new List<Point>();
        static void Main(string[] args)
        {
            var p01 = new Point(2, 3);
            var p02 = new Point(3, 4);
            var p03 = new Point(4, 5);

            Points.Add(p01);
            Points.Add(p02);
            Points.Add(p03);

            List<int> xvalues = new List<int>();
            List<int> yvalues = new List<int>();
            
            foreach(var p in Points)
            {
                xvalues.Add(p.X);
                yvalues.Add(p.Y);
            }

            int[] xS = xvalues.ToArray();
            int[] yS = yvalues.ToArray();
            int maxX = xS.Max();
            int maxY = yS.Max();
            int minX = xS.Min();
            int minY = yS.Min();

            int rangeX = maxX - minX;
            int rangeY = maxY - minY;

            Console.WriteLine($"Max X: {maxX}, Min X: {minX}, Max Y: {maxY}, Min Y: {minY}, X-Range: {rangeX}, Y-Range: {rangeY} ");

        }
    }


    struct Point
    {
        public int X;  
        public int Y;

        public Point(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }
    }
}
