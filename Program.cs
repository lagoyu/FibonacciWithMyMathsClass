using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciWithMyMathsClass
{
    class Program
    {

        static void Main(string[] args)
        {
            for (int i = 0; i < 15; i++)
            {
                Console.WriteLine("{0} {1}", i, MyMaths.Fibonacci(i));
            }
            Console.ReadLine();
        }

    }
}
