using System;

namespace Advanced04.LinqDemos
{
    public class Person //: IComparable<Person>
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        //public int CompareTo(Person other)
        //{
        //    if (this.Age > other.Age)
        //    {
        //        return 1;
        //    }
        //    else if (this.Age == other.Age)
        //    {
        //        return 0;
        //    }
        //    else
        //    {
        //        return -1;
        //    }
        //}

        public override string ToString()
        {
            return $"Id {Id}, Age {Age}, {FirstName} {LastName}";
        }
    }
}
