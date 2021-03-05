﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SideTaskApp
{
    class SideTask
    {
        int Count { get; set; }

        public SideTask(int count)
        {
            this.Count = count;
        }

        public void CountDouwn()
        {
            try
            {
                while (Count > 0)
                {
                    Console.WriteLine($"{Thread.CurrentThread.ManagedThreadId} : {Count} 남음");//현재 사용중인 스레드의 번호 
                    Count--;
                    Thread.Sleep(1000);
                }
                Console.WriteLine($"Count : {Count}"); //0
            }
            catch (ThreadAbortException ex)
            {
                Console.WriteLine($"스레드 임의종료 예외발생 : {ex.Message}");
                Thread.ResetAbort();
            }
            catch (Exception ex)
            {

                Console.WriteLine($"스레드 예외발생 : {ex.Message}");
            }
            
        }
    }
    class Program
    {

        static void Main(string[] args)
        {
            SideTask task = new SideTask(100);
            Thread th = new Thread(task.CountDouwn);
            th.IsBackground = false; // 이 스레드가 종료되기 전까지는 프로세스가 끝나지 않음
            //true인 경우, 백그라운드 스레드가 돌고 있는 상태에도 메인스레드가 끝나면 백그라운드 스레드도 같이 종료
            SideTask task2 = new SideTask(200);
            Thread th2 = new Thread(task2.CountDouwn);



            Console.WriteLine("스레드 시작!");
            
            th.Start();
            
            th2.Start();



            /*Console.WriteLine("인터럽트!");
            th2.Interrupt();*/
            Console.WriteLine("임의 종료");
            th.Abort();


            Thread.Sleep(5000); //1초

            Console.WriteLine("종료 대기");
            th.Join();

            Console.WriteLine("스레드/프로세스 종료");

        }
    }
}
