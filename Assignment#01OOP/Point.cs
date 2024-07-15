using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_01OOP
{
    public struct Point
    {
        public double X;
        public double Y;

        public Point(double _x,double _y)
        {
            X = _x;
            Y = _y;
        }

        public double CalcDistance(Point P1, Point P2)
        {
            double dx = P1.X = P2.X;
            double dy = P1.Y = P2.Y;
            return Math.Sqrt(dx * dx + dy * dy);
        }
        public override string ToString()
        {
            return $"{this.X} , {this.Y}";
        }
    }
}
