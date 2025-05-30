using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp26
{
    class Point <T>
    {
        private T x { get; set; }
        private T y { get; set; }
        
        public Point (T x, T y)
        {
            this.x = x;
            this.y = y;
        }
        public void Output()
        {
        Console.WriteLine($"X = {x}\nY = {y}");
        }
    }
}
