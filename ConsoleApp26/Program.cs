using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp26
{
    class Program
    {
        static void Main(string[] args)
        {
            Point<int> pointInt = new Point<int>(10, 20);
            pointInt.Output();

            Point<double> pointDouble = new Point<double>(3.14, 2.71);
            pointDouble.Output();

            Point<uint> pointString = new Point<uint>(12, 23);
            pointString.Output();
            Console.Read();
        }
    }
}