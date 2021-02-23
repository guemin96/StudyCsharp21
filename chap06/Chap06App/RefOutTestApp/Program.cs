using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefOutTestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 22, b = 3;
            int val = 0;
            int rem = 0;

            Divide(a, b,ref val,ref rem);
            Console.WriteLine($"{a}/{b}={val},{a}%{b}={rem}");

            bool isSucceed = int.TryParse("1000", out int result);// 1000이라는 값이 정수이기 때문에 tryparse구문에서 변환될 수 있기 때문에 변환결과가 true, result가 그대로 1000이 나오지만
            //정수가 아닌 실수값(소수점 자리)이 나오게 되면 변환에 실패하여 false와 false를 뜻하는 0을 배출하게 된다.
            Console.WriteLine($"변환결과{isSucceed} result 값 {result}");
        }
        static void Divide(int a, int b, ref int quotient, ref int reminder)//ref 자리에 out을 사용해도 상관없음.
        {
            quotient = a / b;
            reminder = a % b;
        }
    }
}
