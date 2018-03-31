using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal dog = new Dog();
            dog.MakeNoise();
            Animal muteDog = new MuteDog();
            muteDog.MakeNoise();
            Animal cat = new Cat();
            cat.MakeNoise();

        }
    }
}
