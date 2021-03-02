using System;

namespace DelegateChainApp
{
    delegate void AllCalc(int x, int y); // 대리자 선언
    //이벤트를 처리하기 위해 delegate가 나왔다!!!!!!!!!
    class Program
    {
        static void Plus(int a, int b) { Console.WriteLine($"a+b={a + b}"); }
        static void Minus(int a, int b) { Console.WriteLine($"a-b={a - b}"); }
        static void Multiple(int a, int b) { Console.WriteLine($"a*b={a * b}"); }
        static void Divide(int a, int b) { Console.WriteLine($"a/b={a / b}"); }

        static void Main(string[] args)
        {
            Console.WriteLine("Calculating!!");
            AllCalc allCalc = Plus;
            allCalc += Minus;
            allCalc += Multiple;
            allCalc += Divide;

            allCalc(10, 5); // 하나의 호출로 여러가지 일을 처리할 수 있음 allCalc를 호출함으로써 더하기,빼기,곱하기,나누기를 다 호출할 수 있다.

            Console.WriteLine("곱셈 메서드 제거");
            allCalc -= Multiple;

            allCalc(6, 5);
        }
    }
}
