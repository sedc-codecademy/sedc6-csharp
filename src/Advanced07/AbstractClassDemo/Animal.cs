using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassDemo
{
    public abstract class Animal
    {
        public abstract string Name { get; set; }
        public abstract void MakeNoise();
        public virtual void GetName()
        {
            Console.WriteLine("N/A");
        }
    }
}
