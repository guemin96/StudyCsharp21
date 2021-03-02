using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chap13App
{
    delegate int MyDelegate(int a, int b);// 대리자, 대신 호출한다. 대리자와 대리하는 함수의 파라미터의 수는 동일해야한다.

    class Calculator
    {
        public int Plus(int a, int b)
        {
            return a + b;

        }

        public int Minus(int a, int b)
        {
            return a - b;
        }
        class Program
        {
            static void Main(string[] args)
            {
                Calculator calc = new Calculator();
                MyDelegate Callback;

                Callback = new MyDelegate(calc.Plus);
                Console.WriteLine($"result ={Callback(3,4)}");

                Callback = new MyDelegate(calc.Minus);
                Console.WriteLine($"result ={Callback(5, 2)}");

                //var result = calc.Plus(3, 4);
                //Console.WriteLine($"result ={result}");
            }
        }
    }
}
