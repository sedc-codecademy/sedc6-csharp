using System.Collections.Generic;
using System.Linq;
using System;

namespace Advanced04.LinqDemos
{
    class Program
    {
        static void Main(string[] args)
        {
            var people = new List<Person>
            {
                new Person{Id=1,Age=12,FirstName="person1",LastName="mcPerson1" },
                new Person{Id=2,Age=18,FirstName="person2",LastName="mcPerson2" },
                new Person{Id=3,Age=20,FirstName="person3",LastName="mcPerson3" },
                new Person{Id=4,Age=28,FirstName="person4",LastName="mcPerson4" },
                new Person{Id=5,Age=38,FirstName="person5",LastName="mcPerson5" }
            };
            
            people.PrintItems();
        }
    }
}
