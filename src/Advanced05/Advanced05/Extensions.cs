using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced05
{
    static class  Extensions
    {
        public static void PrintCollection<T>(this IEnumerable<T> collection)
        {
            foreach (var item in collection)
            {
                Console.WriteLine(item);
            }
        }
        public static void PrintItem<T>(this T item)
        {
            Console.WriteLine(item);
        }
    }
}
