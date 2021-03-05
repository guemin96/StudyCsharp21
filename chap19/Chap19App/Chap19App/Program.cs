using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Chap19App
{
    class Program
    {
        static void DoSomething()
        {
            for (int i = 0; i < 50; i++)
            {
                Console.WriteLine($"DoSomething  :  {i}");
                //Thread.Sleep(10);// 1/100초 동안 멈춤
            }
            
        }
        static void SomethingHappen()
        {
            for (int i = 0; i < 50; i++)
            {
                Console.WriteLine($"SomethingHappen  :  {i}");
                Thread.Sleep(10);// 1/100초 동안 멈춤
            }

        }

        static void Main(string[] args)
        {
            
            Thread thread = new Thread(new ThreadStart(DoSomething));//대리자
            Thread thread1 = new Thread(SomethingHappen);

            
           
            try
            {
                Console.WriteLine("스레드 시작");
                thread.Start();
                thread1.Start();

                for (int i = 0; i < 50; i++)
                {
                    Console.WriteLine($"Main thread : {i}");
                    Thread.Sleep(10);

                    if (i == 10)
                    {
                        thread.Abort();
                    }
                }


                Console.WriteLine("스레드 종료 대기");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"예외발생 : {ex.Message}");

            }
            finally
            {
                thread.Join();
                thread1.Join();

                Console.WriteLine("프로세스 종료");
            }
        }
    }
}
