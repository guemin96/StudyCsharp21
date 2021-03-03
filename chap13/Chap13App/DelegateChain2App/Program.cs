using System;

namespace DelegateChain2App
{
    class Program
    {
        delegate void ThereIsAFire(string location); //대리자 선언, ex) 로봇의 실행 순서를 조종할 때 ,WinForm 형식에서!

        static void Call119(string location)
        {
            Console.WriteLine($"소방서죠? 불났어요! 주소는 {location}에요.");
        }

        static void Shotout(string location)
        {
            Console.WriteLine($"불이야! {location}에 불났어요!!");
        }
        static void Escape(string location)
        {
            Console.WriteLine($"{location}에서 나갑니다.");
        }


        static void Main(string[] args)
        {
            ThereIsAFire fire = new ThereIsAFire(Shotout);
            fire += Call119;
            fire += Escape;

            fire("문현동");
        }
    }
}
