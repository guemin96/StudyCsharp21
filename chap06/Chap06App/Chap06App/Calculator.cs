using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chap06App
{
    class Calculator
    {
        static void Main(string[] args)
        {
            int x = Calculator.Plus(3, 4);
            int y = Calculator.Plus(5, 6);
            int z = Calculator.Plus(7, 8);

            int result = x + y + z;
            Console.WriteLine($"결과는 {result}");
        }

        private static int Plus(int p1, int p2)
        {
            Console.WriteLine($"인수값 {p1},{p2}");
            int result = p1 + p2;
            return result;
        }
    }
}
