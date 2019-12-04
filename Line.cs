using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adventd3p1
{
    class Line
    {
        string dataSet;                             // Raw data from the input file
        public List<Point> points = new List<Point>();     // List of all points in this line
        public Point prevPoint = new Point(0,0);           // Where the line currently is

        public Line(string input)
        {
            dataSet = input;                   // Set this lines data

            string[] rawC = dataSet.Split(',');

            SplitInitial(rawC);
        }
        public Line() { }                           // Blank constructor

        private void SplitInitial(string[] rawC)
        {
            foreach (var co in rawC)
            {
                char dir = co[0];               // Gets the direction
                string newS = co.Remove(0, 1);  // Discards direction from the distance

                new Point(dir, ref prevPoint, Int32.Parse(newS), ref points);   // Create new set of points for the line
                
                if (rawC.Count() > 1)
                {
                    rawC = rawC.Skip(1).ToArray(); ;
                }
            }
        }
    }
}
