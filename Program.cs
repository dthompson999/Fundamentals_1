using System;

namespace Fundamentals_I
{
    class Program
    {
        
        
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            // for(int i=0; i <= 255; i++)
            // {
            //     Console.WriteLine(i);
            // }

            // for(int i=0; i <= 100; i++)
            // {
            //     if (i % 3 == 0 || i % 5 == 0)
            //     {
            //         Console.WriteLine(i);
            //     }
            // }

            // for(int i=0; i <= 100; i++)
            // {
            //     if (i % 3 == 0 && i % 5 == 0)
            //     {
            //         Console.WriteLine($"{i} - FizzBuzz");
            //     }
            //     else if (i % 3 == 0)
            //     {
            //         Console.WriteLine($"{i} - Fizz");
            //     }
            //     else if (i % 5 == 0)
            //     {
            //         Console.WriteLine($"{i} - Buzz");
            //     }
            // }

            int i = 1;
            while (i <= 255)
            {
                Console.WriteLine(i);
                i ++;
            }
        }
    }
}
