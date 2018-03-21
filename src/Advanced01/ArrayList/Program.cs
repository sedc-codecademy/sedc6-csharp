using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Data.SqlClient;

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
            int[] array = new int[] { 1,2,3};
            foreach (var item in array)
            {
                Console.WriteLine(item);
            }
            Array.Reverse(array);
            foreach (var item in array)
            {
                Console.WriteLine(item);
            }
            int myNumber = 100;
            Console.WriteLine($"myNumber: {myNumber}");
            myNumber = Doubleify(myNumber);
            Console.WriteLine($"myNumber: {myNumber}");

        }
        static int Doubleify(int number)
        {
            return number * 2;
        }

        static void Print(object item)
        {
            Console.WriteLine(item);
        }




        static void Example2()
        {
            try
            {
                //UNSAFE CODE
                throw new Exception("invalid data");
            }
            catch (SqlException e)
            {
                //log
                throw;
            }
            catch (Exception e)
            {
                //z
                throw;
            }
            finally
            {

            }


            //var listString = new MyList<string>();
            //var listInt = new MyList<int>();
            //var myList = new List<string>();
            //myList.Sort();
            //myList.Reverse();

            //listString.Add("red");
            //listString.Add("red");
            //listString.Add("red");
            //listString.Add("red");
            //listString.Remove("red");
            //var count = listString.Count;


        }

        static void Example1()
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

            //Queue<int> numbersQueue = new Queue<int>();

            //numbersQueue.Enqueue(1);
            //PrintQueueInfo(numbersQueue);

            //numbersQueue.Enqueue(2);
            //PrintQueueInfo(numbersQueue);

            //numbersQueue.Dequeue();
            //PrintQueueInfo(numbersQueue);

            //numbersQueue.Enqueue(3);
            //PrintQueueInfo(numbersQueue);

            //numbersQueue.Enqueue(4);
            //PrintQueueInfo(numbersQueue);

            //int countBeforeFor = numbersQueue.Count;
            //for (int i = 0; i < countBeforeFor; i++)
            //{
            //    Console.WriteLine(numbersQueue.Dequeue());
            //}



            Console.ReadLine();
        }

        static void PrintQueueInfo<T>(Queue<T> queue)
        {
            Console.WriteLine("------------");
            Console.WriteLine($"Count: {queue.Count}");
        }
    }
}
