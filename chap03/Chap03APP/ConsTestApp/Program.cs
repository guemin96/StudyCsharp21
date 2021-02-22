using System;

namespace ConsTestApp
{
    class Program
    {
        enum Season
        {
            봄,
            여름,
            가을,
            겨울
        }
        
        static void Main(string[] args)
        {
            Console.WriteLine("상수테스트");
            const double Pi = 3.141592;
            Console.WriteLine($"원주율의 값은 {Pi}");
            //Pi = 6.345; const로 인한 상수값이기 때문에 변경이 불가능함.

            Season mySeason = (Season)3; //Season.여름;

            Console.WriteLine($"지금 계절은 {mySeason}입니다.");

            int a = 0;
            Console.WriteLine($"a는 {a}");
            int? b= null;//?를 붙이면 null을 표현할 수 있다.nullable
            Console.WriteLine($"b는 {b}");
        }
    }
}
