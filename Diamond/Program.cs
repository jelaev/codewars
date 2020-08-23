using System;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Diamond
{
    class Program
    {
        public static string print(int n)
        {
            if (n == 1)
                return "*\n";

            if (n < 3)
                return null;

            if (n % 2 == 0)
                return null;

            StringBuilder begin = new StringBuilder();

            var length = n % 2 != 0 ? n : n - 1;
            string[] array = new string[length];

            for (int i = 1; i <= n; i++)
            {
                var size = (length - i) / 2;
                if (i % 2 != 0)
                {
                    begin.Append(new String(' ', size));
                    begin.Append(new String('*', i));
                    begin.Append('\n');
                    array[i - 1] = begin.ToString();
                    begin.Clear();
                }
            }

            foreach (var x in array)
                begin.Append(x);

            array = array.Reverse().ToArray();
            array[0] = "";

            foreach (var x in array)
                begin.Append(x);

            return begin.ToString();
        }

        public static void Main()
        {
            Console.WriteLine(print(1));

            Console.WriteLine(print(-2));
            Console.WriteLine(print(0));
            Console.WriteLine(print(2));



            Console.WriteLine(print(11));



            Console.ReadKey();
        }

    }
}
