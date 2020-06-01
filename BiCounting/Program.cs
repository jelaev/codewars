using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace BitCounting
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CountBits(1234));
        }

        public static int CountBits(int n)
        {
            return Convert.ToString(n, 2).Count<char>(x => x == '1');
        }
    }
}
