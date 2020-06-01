using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;

namespace DescendingOrder
{
    class Program
    {
        public static int DescendingOrder(int num)
        {
            // Bust a move right here
            var getStr = num.ToString();
            List<string> massive = new List<string>();
            foreach(var m in getStr)
            {
                massive.Add(m.ToString());
            }
            var sort = massive.OrderByDescending(m => m);
            return Convert.ToInt32(string.Join("", sort));
        }

        public static void Main()
        {
            Console.WriteLine(DescendingOrder(17362));
        }
    }
}
