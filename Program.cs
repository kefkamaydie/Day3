using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace adventd3p1
{
    class Program
    {
        static void Main(string[] args)
        {
            string inp1, inp2;

            using (StreamReader input = new StreamReader(@"C:\Users\Chris\Desktop\AdventOfCode2019\adventinput3l1.txt"))
            {
                inp1 = input.ReadToEnd();
            }   // This separates the data set into the first line

            using (StreamReader input = new StreamReader(@"C:\Users\Chris\Desktop\AdventOfCode2019\adventinput3l2.txt"))
            {
                inp2 = input.ReadToEnd();
            }

            Line lOne = new Line(inp1);     // Create all the points for line 1
            Line lTwo = new Line(inp2);     // Create all the points for line 2

            int s = FindShortestIntersection(lOne, lTwo);
            //Console.WriteLine(s);

            Console.ReadLine();
        }

        public static int FindShortestIntersection(Line one, Line two)
        {
            List<Point> samePoints = new List<Point>();
            int shortest;

            for (int i = 0; i < one.points.Count(); i++)        // Check if points in each line intersect
            {
                for (int x = 0; x < two.points.Count(); x++)
                {
                    if ((one.points[i].xCo == two.points[x].xCo) && (one.points[i].yCo == two.points[x].yCo))
                    {
                        samePoints.Add(new Point(one.points[i].xCo, one.points[i].yCo));
                    }
                }
            }

            foreach(Point p in samePoints) { Console.WriteLine(p); }
            shortest = samePoints[0].xCo + samePoints[0].yCo;           // Set a default shortest distance

            Console.ReadLine(); // Debugging, remove when done.

            foreach (Point p in samePoints)     // Determine if point is closer to origin than previous shortest
            {
                if (((Math.Abs(p.xCo) + Math.Abs(p.yCo)) < shortest) && (p.xCo + p.yCo != 0))
                {
                    shortest = p.xCo + p.yCo;
                }
            }

            return shortest;
        }
    }
}
