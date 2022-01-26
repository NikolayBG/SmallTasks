using System;

namespace Chapter1EvenOdd
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 24;
            bool even = num % 2 == 0 ? true : false;
            Console.WriteLine("{0} is even ? {1}", num, even);
        }
    }
}
