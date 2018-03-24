using System.Collections.Generic;
using System.Linq;
using System;

namespace Advanced04.LinqDemos
{
    class Program
    {
        static void Main(string[] args)
        {
            IEnumerable<Person> people = new List<Person>
            {
                new Person{Id=1,Age=12,FirstName="person1",LastName="mcPerson1" },
                new Person{Id=2,Age=18,FirstName="person2",LastName="mcPerson2" },
                new Person{Id=3,Age=13,FirstName="person3",LastName="mcPerson3" },
                new Person{Id=4,Age=28,FirstName="person4",LastName="mcPerson4" },
                new Person{Id=5,Age=25,FirstName="person5",LastName="mcPerson5" }
            };

            //IEnumerable has no Count property
            //but extensionMethod .Count()
            //var sumOfAges = people.Sum(p => p.Age);
            //var count = people.Count();
            //sumOfAges.PrintItem();

            //people.Count(p => p.Age >= 18)
            //    .PrintItem();

            //foreach (var character in "asdqwerty")
            //{
            //    Console.WriteLine(character);
            //}

            //.Where()
            //var results1 = people.Where(p => p.Age >= 18);
            //var results2 = people.Where(p => p.FirstName.Contains("P"));

            //.Select()     .SelectMany()
            //var results3 = people.Select(p => p.FirstName);
            //var results4 = people.SelectMany(p => p.FirstName);

            //.OrderBy()    .OrderByDescending()
            //var orderedByAge = people.OrderBy(x => x.Age);
            //var youngest = orderedByAge.Last();

            //.First()   .Last()
            //var list = new List<string>();
            //var last = list.First();
            //var last = list.FirstOrDefault();
            //var last = list.Last();
            //var last = list.LastOrDefault();

            //if (last != null)
            //{
            //    last.Reverse();
            //}


        }
    }
}
