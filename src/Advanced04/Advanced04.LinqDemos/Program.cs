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
                new Person{Id=1,Age=12,FirstName="dzevo",LastName="lastname5" },

                new Person{Id=2,Age=18,FirstName="filip",LastName="lastname4" },
                new Person{Id=25,Age=58,FirstName="filip",LastName="lastname6" },

                new Person{Id=3,Age=13,FirstName="dejan",LastName="lastname3" },

                new Person{Id=4,Age=28,FirstName="ivo",LastName="lastName2" },

                new Person{Id=5,Age=25,FirstName="marija",LastName="lastname1" }
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

            //.Single() .SingleOrDefault()
            //var singlePerson = people.Single(p => p.Id == 1);
            //var singleZeroElement = new List<int>().Single(n => n == 0);
            //var singlePerson = people.Single(p => p.Id ==3);

            //var singlePerson = people.SingleOrDefault(p => p.Id == 1);
            //var singleZeroElement = new List<int>().SingleOrDefault(n => n == 1);
            //var singlePerson = people.Single(p => p.Id == 3);
            //singleZeroElement.PrintItem();

            //.Average()
            //people.Average(p => p.Age).PrintItem();

            //.Min() .Max()
            //people.Min(p => p.Age).PrintItem();
            //people.Max(p => p.Age).PrintItem();

            //.Skip() .Take()
            //people
            //    .OrderBy(x => x.FirstName)
            //    .ThenBy(x => x.LastName)
            //    .PrintItems();
            //    //.Skip(2)
            //    //.Take(2)
            //    //.OrderBy(x => x.LastName);

            //.TakeWhile()
            //people.TakeWhile(p => p.FirstName.Contains("o"))
            //    .PrintItems();

            //.SkipWhile()
            //people.SkipWhile(p => p.FirstName.Contains("o"))
            //.PrintItems();

            //.GroupBy()
            //var firstNameGroups = people.GroupBy(x => x.FirstName);
            //var filipGroup = firstNameGroups.FirstOrDefault(x => x.Key == "filip");
            //var firstFilipOlderThan20 = filipGroup.FirstOrDefault(x => x.Age > 20);
        }
    }
}
