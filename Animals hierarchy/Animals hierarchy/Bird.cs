using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals_hierarchy
{
    class Bird : Animal
    {
        public string FlyHigh { get; set; }
        public Bird(string name, int age, string flyHigh) : base (name , age)
        {
            FlyHigh = flyHigh; 
        }

        public override void Move()
        {
            Console.WriteLine("Bird is flying.");
        }

        public override void Speak()
        {
            Console.WriteLine("Bird is chirping.");
        }
        public sealed override void Sleep()
        {
            Console.WriteLine($"{Name} sleep.");
        }
    }
}
