using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NugetDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var books = new List<Book>();
            books.Add(new Book { Id = 1, Name = "Pat olkolu svetot", Author = "jul verne" });
            books.Add(new Book { Id = 2, Name = "AspNet 5", Author = "Scot Allen" });
            books.Add(new Book { Id = 3, Name = "c# in depth", Author = "jon skeet" });
            var booksAsJson = JsonConvert.SerializeObject(books);
            var booksDeserialized = 
                JsonConvert.DeserializeObject<List<Book>>(booksAsJson);
            
            Console.WriteLine();

        }
    }
}
