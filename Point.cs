using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adventd3p1
{
    public class Point
    {
        public int xCo;                        // X Coordinate
        public int yCo;                        // Y Coordinate

        public Point(char dir, ref Point start, int length, ref List<Point> curLine)
        {
            if (dir == 'U')
            {
                Up(ref start, length, ref curLine);
            }
            if (dir == 'D')
            {
                Down(ref start, length, ref curLine);
            }
            if (dir == 'L')
            {
                Left(ref start, length, ref curLine);
            }
            if (dir == 'R')
            {
                Right(ref start, length, ref curLine);
            }
        }

        public Point(int x, int y)
        {
            this.xCo = x;
            this.yCo = y;
        }

        public void Up(ref Point start, int length, ref List<Point> curPoints)
        {
            int counter = start.yCo;
            int s = start.yCo;

            for (int y = s; y <= (counter + length) - 1; y++)
            {
                curPoints.Add(new Point((start.xCo), (start.yCo + 1)));

                start.xCo = curPoints.Last().xCo;
                start.yCo = curPoints.Last().yCo;
            }
        }
        public void Down(ref Point start, int length, ref List<Point> curPoints)
        {
            int counter = start.yCo;
            int s = start.yCo;

            for (int y = s; y >= (counter - length) + 1; y--)
            {
                curPoints.Add(new Point((start.xCo), (start.yCo - 1)));

                start.xCo = curPoints.Last().xCo;
                start.yCo = curPoints.Last().yCo;
            }
        }
        public void Left(ref Point start, int length, ref List<Point> curPoints)
        {
            int counter = start.xCo;
            int s = start.xCo;

            for (int x = s; x >= (counter - length) + 1; x--)
            {
                curPoints.Add(new Point((start.xCo - 1), (start.yCo)));

                start.xCo = curPoints.Last().xCo;
                start.yCo = curPoints.Last().yCo;
            }
        }
        public void Right(ref Point start, int length, ref List<Point> curPoints)
        {
            int counter = start.xCo;
            int s = start.xCo;

            for (int x = s; x <= (counter + length) - 1; x++)
            {
                curPoints.Add(new Point((start.xCo + 1), (start.yCo)));

                start.xCo = curPoints.Last().xCo;
                start.yCo = curPoints.Last().yCo;
            }
        }

        public override string ToString()
        {
            return ("(" + xCo + "," + yCo + ")");
        }
    }
}
