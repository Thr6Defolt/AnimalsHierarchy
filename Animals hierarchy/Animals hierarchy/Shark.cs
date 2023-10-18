using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals_hierarchy
{
    class Shark : Fish
    {
        public Shark(string name, int age, string depthHigh) : base(name, age, depthHigh)
        {

        }
        public override void Move()
        {
            Console.WriteLine("Shark is swiming.");
        }

        public override void Speak()
        {
            Console.WriteLine("Shark is gurgling.");
        }
    }
}
