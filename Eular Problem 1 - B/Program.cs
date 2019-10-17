using System;

namespace Eular_Problem_1___B
{
    class Program
    {

        static void Main(string[] args)
        {

            Predicate<int> multipleOfThree = i => i % 3 == 0;
            Predicate<int> multipleOfFive = i => i % 5 == 0;

            for ( int x = 1; x < 1000; x++)
            {
                if ( multipleOfThree(x) )
                    Console.WriteLine(x.ToString());
                else if (multipleOfFive(x))
                    Console.WriteLine(x.ToString());
            }
            Console.WriteLine("Hello World!");
        }
    }
}
