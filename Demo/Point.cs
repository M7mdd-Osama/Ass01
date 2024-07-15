using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    internal struct Point
    {
        public int X;
        public int Y;
        public Point(int _x, int _y)
        {
            X = _x;
            Y = _y;
        }
        public Point(int Number)
        {
            X = Y = Number;
        }
        public override string ToString()
        {
            return $"{this.X} , {this.Y}";
        }
    }
}
