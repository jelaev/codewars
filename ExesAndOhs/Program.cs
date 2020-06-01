using System;
using System.Linq;

namespace ExesAndOhs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(XO("ooxx"));
            Console.WriteLine(XO("xooxx"));
            Console.WriteLine(XO("ooxXm"));
            Console.WriteLine(XO("zpzpzpp"));
            Console.WriteLine(XO("zzoo"));
        }

        public static bool XO(string input)
        {
            var xv = input.Where(x => x.ToString().ToLower() == "x").Count();
            var ov = input.Where(x => x.ToString().ToLower() == "o").Count();
            if ((xv == ov) && (xv != 0 && ov != 0))
                return true;
            if (xv == 0 && ov == 0)
                return true;
            return false;
        }
    }
}
