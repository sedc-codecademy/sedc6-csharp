using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Book
            {
                Id = 1,
                Name = "c# in depth",
                Author = "john skeet"
            };
            Type type = book.GetType();
            
            Console.WriteLine($"name: {type.Name}");
            Console.WriteLine($"fullName: {type.FullName}");
            Console.WriteLine($"namespace: {type.Namespace}");
            PropertyInfo[] properties = type.GetProperties();
            Console.WriteLine("---------------------");
            //foreach (var property in properties)
            //{
            //    var value = property.GetValue(book);
            //    Console.WriteLine($"{property.Name}:{value}");
            //}
            Console.WriteLine("{");
            foreach (var property in properties)
            {
                var value = property.GetValue(book);
                Console.WriteLine($"\"{property.Name}\":\"{value}\"");
            }
            Console.WriteLine("}");


        }
    }
}
