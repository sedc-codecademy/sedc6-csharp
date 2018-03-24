using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced04.LinqDemos
{
    public static class Extensions
    {
        public static void PrintItem<T>(this T item)
        {
            Console.WriteLine(item);
        }

        //public static void PrintItems<T>(this List<T> collection)
        //{
        //    foreach (var item in collection)
        //    {
        //        //Console.WriteLine(item);
        //        item.PrintItem();
        //    }
        //}

        public static void PrintItems<T>(this IEnumerable<T> collection)
        {
            foreach (var item in collection)
            {
                //Console.WriteLine(item);
                item.PrintItem();
            }
        }
    }
}
