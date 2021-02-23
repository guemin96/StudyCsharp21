using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prac
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j <= 4-i ; j++)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j < i+1; j++)
                {
                    Console.Write("*");//줄바꿈하지않고 계속해서 입력
                }
                Console.WriteLine(" ");//줄바꿈해줌!!!!!!!! 개 중요

            }
        }
    }
}
