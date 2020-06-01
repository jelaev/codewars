using System;
using System.Linq;
using System.Collections.Generic;
namespace ListFiltering
{
    class Program
    {
        static void Main(string[] args)
        {
            var lst = GetIntegersFromList(new List<object>() { 1, 2, "a", "b", 0, 15 });
            foreach(var l in lst)
            {
                Console.WriteLine(l);
            }

        }

        public static IEnumerable<int> GetIntegersFromList(List<object> listOfItems)
        {
            return (List<int>)listOfItems.Where(x => x.GetType() == typeof(int)).Select(x => (int)x).ToList<int>();

        }
    }
}
