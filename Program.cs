using System;

namespace task3
{
    class Program
    {
        static void Main(string[] args)
        {
            int beginValue = 5;
            int endValue = 96;
            int step = 7;

            for (int value = beginValue; value <= endValue; value += step)
            {
                Console.WriteLine(value);
            }
        }
    }
}
