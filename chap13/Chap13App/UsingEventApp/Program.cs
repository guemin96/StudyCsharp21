using System;

namespace UsingEventApp
{
    delegate void EventHandler(string message); // 메세지 받아서 처리하는 대리자 선언., winform에서 마우스나 키보드로 행해지는 이벤트를 위해 만들어진 기능

    class CustomNotifier
    {//이벤트 선언, 사용하는 객체
        public event EventHandler SomethingHappened;// 대리자의 인스턴스 이벤트

        public void DoSomething(int number)
        {
            int temp = number % 10;

            if (temp != 0 && temp % 3 == 0) //3, 6, 9로 떨어지는 값
            {
                SomethingHappened($"{number} : 짝");
            }
            else
            {
                SomethingHappened($"{number}");
            }
        }

    }
    class Program
    {
        /// <summary>
        /// 이벤트가 발생했을때 실행되는 메서드(이벤트 핸들러)
        /// </summary>
        /// <param name="args"></param>
        
        public static void MyHandler(string message)// MyHandler는 함수 
        {
            Console.WriteLine(message);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("이벤트 사용!");
            CustomNotifier notifier = new CustomNotifier();
            notifier.SomethingHappened += new EventHandler(MyHandler);// 이벤트를 내가 만든 로직이 있는 메서드랑 연결

            for (int i = 1; i < 100; i++)
            {
                notifier.DoSomething(i);
            }
        }
    }
}
