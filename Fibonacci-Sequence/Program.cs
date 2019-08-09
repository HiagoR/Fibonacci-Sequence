using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci_Sequence
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(FibonacciIteratively(10));
            Console.WriteLine(FibonacciRecursively(10));
            Console.ReadKey();
        }

        public static ulong FibonacciIteratively(ulong n)
        {
            ulong x = 0;
            ulong j = 1;

            if (n <= 1)
            {
                return n;
            }
            else
            {
                for (ulong i = 0; i < n; i++)
                {
                    //if you want to test, and enter with 10, undo the comment on the line bellow and it'll print this: 0 1 1 2 3 5 8 21 34 55
                    //Console.WriteLine(x);
                    ulong save = x + j;
                    x = j;
                    j = save;
                }
            }


            return x;
        }

        public static ulong FibonacciRecursively(ulong n)
        {
            if (n <= 1)
            {
                return n;
            }

            return FibonacciRecursively(n - 1) + FibonacciRecursively(n - 2);
        }
    }
}
