using System;

namespace SplitString
{
    class Program
    {
        public static string[] Solution(string str)
        {
            var pairs = str.Length % 2 == 0 ? str.Length / 2 : (str.Length + 1) / 2; 
            var result = new string[pairs];
            for (int i = 0; i < str.Length; i+=2)
            {
                if (i + 1 < str.Length)
                    result[i / 2] = str.Substring(i, 2);
                else
                    result[i / 2] = str[i] + "_";
            }

            return result;
        }

        static void Main(string[] args)
        {
            foreach(var item in Solution("abc"))
                Console.WriteLine(item);
            foreach (var item in Solution("abcdef"))
                Console.WriteLine(item);
        }
    }
}
