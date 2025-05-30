using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp25
{
    class Person <T>
    {
        public /*object*/ T Id { get; }
        public string Name { get; }
        public Person() { }
        public Person(T id, string name)
        {
            this.Id = id;
            this.Name = name;
        }
    }
}
