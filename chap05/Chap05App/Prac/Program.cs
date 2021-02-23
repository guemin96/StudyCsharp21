﻿using System;
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
            while (true)
            {
                Console.WriteLine("값을 입력하세요.");
                string line = Console.ReadLine();

                if (line == "quit") break;

                string day = line;

                switch (day)
                {
                    case "월요일":
                        Console.WriteLine("월요일입니다.");
                    break;
                    case "화요일":
                        Console.WriteLine("화요일입니다.");
                        break;
                    case "수요일":
                        Console.WriteLine("수요일입니다.");
                        break;
                    case "목요일":
                        Console.WriteLine("목요일입니다.");
                        break;
                    case "금요일":
                        Console.WriteLine("금요일입니다.");
                        break;
                    case "토요일":
                        Console.WriteLine("토요일입니다.");
                        break;
                    case "일요일":
                        Console.WriteLine("일요일입니다.");
                        break;
                    default:
                        Console.WriteLine("요일이 아닙니다.");
                        break;
                }
                //Console.WriteLine(line);


            }
            Console.WriteLine("계산 종료");
        }
    }
}
