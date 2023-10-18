using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals_hierarchy
{
    class Eagle : Bird
    {
        public Eagle(string name, int age, string flyHigh) : base(name, age, flyHigh)
        {

        }
        public override void Move()
        {
            Console.WriteLine("Eagle is flying.");
        }

        public override void Speak()
        {
            Console.WriteLine("Eagle is chirping.");
        }
    }
}
