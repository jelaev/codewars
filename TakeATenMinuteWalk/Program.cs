using System;

namespace TakeATenMinuteWalk
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public static bool IsValidWalk(string[] walk)
        {
            if (walk.Length != 10)
            {
                return false;
            }

            for (var i = 0; i < walk.Length - 1; i++)
            {
                if (walk[i] == walk[i+1])
                {
                    return false;
                }
            }

            return true;
        }
    }
}
