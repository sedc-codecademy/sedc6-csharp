using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionDemo
{
    public class Book
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Author { get; set; }

        public string ToJson()
        {
            var result = "";
            //{ 
            //"string":"str",
            //"number":asd
            //}

            result += "{";
            result += $"\"id\":{Id},";
            result += $"\"name\":\"{Name}\",";
            result += $"\"author\":\"{Author}\"";
            result += "}";
            return result;
        }

        public string GetName()
        {
            return Name;
        }
        public string GetAuthor()
        {
            return Author;
        }
        public int GetId()
        {
            return Id;
        }
    }
}
