using System;

namespace IncDecTestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("증감연산자 테스트");


            int result = 26;
            Console.WriteLine($"현재 숫자는 {result}입니다.");
            
            result += 3;
            Console.WriteLine($"현재 숫자는 {result}입니다.");

            result -= 10;
            Console.WriteLine($"현재 숫자는 {result}입니다.");


            Console.WriteLine($"후치 증감 값은 {result++}입니다.");


            Console.WriteLine($"전치 증감 값은 {++result}입니다.");

        }
    }
}
