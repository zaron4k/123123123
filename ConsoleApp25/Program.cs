using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp25
{
    class Program
    {
        static void Main(string[] args)
        {
            Person <int> tom = new Person <int> (546, "Tom");
            //    Person <string> bob = new Person <string> ("a1","Bob");
            //int tomId = (int)
            //    tom.Id;
            //string bobId = (string)bob.Id;
            ////Console.WriteLine($"{tomId}");
            ////Console.WriteLine($"{bobId}");
            ////Console.Read();
            //Console.WriteLine(tomId);
            //Console.WriteLine(bobId);
            Company<Person<int>>
                microsoft = new Company<Person<int>>(tom);
            Console.WriteLine(microsoft.CEO.Id);
            Console.WriteLine(microsoft.CEO.Name);
        }
    }
}
