using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharTestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            char ch1 = 't', ch2 = '\t', ch3 = '\n', ch4 = '0';
            Console.WriteLine($"{ch1},{ch2},{ch3},{ch4}");
            char ch5 = '\\'; //홑따옴표는 1개의 문자를 넣을때만 가능, 나머지는 쌍따옴표
            Console.WriteLine($"{ch5}");

            //문자열
            string str1 = "\tHello, \aWorld!";
            Console.WriteLine(str1);
            Console.WriteLine($"{str1}");

            bool isTrue = true;
            Console.WriteLine(isTrue);
            if (isTrue)
            {
                Console.WriteLine("참입니다.");

            }
            else
            {
                Console.WriteLine("거짓입니다.");
            }
            Console.WriteLine(
                );



        }
    }
}
