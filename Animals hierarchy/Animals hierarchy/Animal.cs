using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals_hierarchy
{
    class Animal
    {
        public string Name {  get; set; }
        public int Age { get; set; }

        public Animal(string name, int age)
        {
            Name = name;
            Age = age;
        }


        public virtual void Move()
        {
            Console.WriteLine("It is moving.");
        }
        public virtual void Speak()
        {
            Console.WriteLine("It is make some noise.");
        }

        public virtual void Sleep()
        {
            Console.WriteLine("Animal sleeps.");
        }
    }
}
