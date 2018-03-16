using System;
using System.Collections.Generic;
using System.Collections;

namespace ArrayListDemo
{
    public class Person
    {
        public string Name { get; set; }
    }
    public struct Customer
    {
        public int Age { get; set; }
    }
    class Box
    {
        public int Value { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //List<List<List<string>>> li = new List<List<List<string>>>();
            //var li2 = new List<List<List<string>>>();

            //object obj123 = 8;
            //int n = (int)obj123;
            //var customer = new Customer();
            //var person = new Person();

            //ArrayList listOfNumbers = new ArrayList(8);

            //listOfNumbers.Add(9);
            //var numberAsObject = listOfNumbers[0];
            //int number = Convert.ToInt32(numberAsObject);

            //Stack<int> numbersStack = new Stack<int>();
            //numbersStack.Push(1);
            //numbersStack.Push(3);
            //numbersStack.Push(5);
            //numbersStack.Push(7);
            //foreach (var item in numbersStack)
            //{
            //    Console.WriteLine(item);
            //}

            Queue<int> numbersQueue = new Queue<int>();
            numbersQueue.Enqueue(1);
            numbersQueue.Enqueue(2);
            numbersQueue.Enqueue(3);
            numbersQueue.Enqueue(4);

            int countBeforeFor = numbersQueue.Count;
            for (int i = 0; i < countBeforeFor; i++)
            {
                Console.WriteLine(numbersQueue.Dequeue());
            }

            Console.ReadLine();
        }
    }
}
