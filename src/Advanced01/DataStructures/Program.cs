using System.Collections.Generic;
using System;

namespace DataStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();
            numbers.Add(1);
            numbers.AddRange(new int[] { 1, 2, 3, 4 });
            //Console.WriteLine(numbers.Capacity);
            List<string> colors = new List<string>
{"red","blue","black", "white" };
            //Stack<> = new Stack<int>

            PrintList<int>(numbers);
            PrintList(colors);
            Console.ReadKey();
        }
        private static void PrintList<T>(List<T> numbers)
        {
            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }
        }
        //private static void PrintList(List<char> numbers)
        //{
        //    foreach (var number in numbers)
        //    {
        //        Console.WriteLine(number);
        //    }
        //}

        //private static void PrintList(List<double> numbers)
        //{
        //    foreach (var number in numbers)
        //    {
        //        Console.WriteLine(number);
        //    }
        //}
        //private static void PrintList(List<int> numbers)
        //{
        //    foreach (var number in numbers)
        //    {
        //        Console.WriteLine(number);
        //    }
        //}
        //private static void PrintList(List<string> items)
        //{
        //    foreach (var item in items)
        //    {
        //        Console.WriteLine(item);
        //    }
        //}
    }
}
