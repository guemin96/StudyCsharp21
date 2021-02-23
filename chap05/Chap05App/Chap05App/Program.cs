using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chap05App
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("값을 입력하세요.");
                string line = Console.ReadLine();

                if (line == "quit") break;
                

                int number = 0;
                int.TryParse(line, out number);
                //Console.WriteLine(line);

                if (number>0)
                {
                    if (number%2==0)
                    {
                        Console.WriteLine("0보다 큰 짝수");

                    }
                    else
                    {
                        Console.WriteLine("0보다 큰 홀수");
                    }


                }
                else
                {
                    Console.WriteLine("0보다 작은 수");
                }
            }
            Console.WriteLine("계산 종료");
        }
    }
}
