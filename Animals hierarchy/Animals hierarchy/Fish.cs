using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Animals_hierarchy
{
    class Fish : Animal
    {
        public string DepthHigh { get; set; }
        public Fish(string name, int age, string depthHigh) : base(name, age)
        {
            DepthHigh = depthHigh;
        }

        public override void Move()
        {
            Console.WriteLine("Fish is swiming.");
        }

        public override void Speak()
        {
            Console.WriteLine("Fish is gurgling.");
        }
        public sealed override void Sleep()
        {
            Console.WriteLine($"{Name} sleep.");
        }
    }
}
