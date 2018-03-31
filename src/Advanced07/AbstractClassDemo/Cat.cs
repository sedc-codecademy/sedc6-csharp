using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassDemo
{
    public class Cat : Animal
    {
        public override string Name { get; set; }
        public override void MakeNoise()
        {
            Console.WriteLine("mjau");
        }
    }
}
