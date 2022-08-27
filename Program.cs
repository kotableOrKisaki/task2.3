using System;

namespace task3
{
    class Program
    {
        static void Main(string[] args)
        {
            int beginValue = 5;
            int endValue = 96;

            for (int value = beginValue; value <= endValue; value += 7)
            {
                Console.WriteLine(value);
            }
        }
    }
}
