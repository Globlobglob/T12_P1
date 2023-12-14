using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T12_P11
{
    internal class Point
    {

        public int x;
        public int y;


        public Point()
        {
            x= 0;
            y= 0;
        }

        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public double  Func()
        {
            return Math.Sqrt( x * y + y * y);


        }
        public override string ToString() 
        {
            return $"X={x}\nY={y}";
        
        }
    }
}
