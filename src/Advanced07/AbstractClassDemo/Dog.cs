using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassDemo
{
    public class Dog : Animal
    {
        public override string Name { get; set; }

        public override void MakeNoise()
        {
            Console.WriteLine("woff woff");
        }
    }
    public class MuteDog : Animal
    {
        public override string Name { get; set; }
        public override void MakeNoise()
        {
            Console.WriteLine("mmmmmmmmm");
        }

    }
}
