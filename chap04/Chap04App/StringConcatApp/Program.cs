using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringConcatApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("숫자 더하기");
            var p2 = 456;
            Console.WriteLine(123 + p2); //579
            Console.WriteLine("123" + p2);
            Console.WriteLine($"123{p2}");
            Console.WriteLine("123" + "456");
            Console.WriteLine("123" + "456");

            //관계연산자
            int a = 30, b = 30;
            Console.WriteLine(a < b);//false
            Console.WriteLine(a > b);//false
            Console.WriteLine(a <= b);//true
            Console.WriteLine(a >= b);//true
            Console.WriteLine(a == b);//true
            Console.WriteLine(a != b);//false

            //논리연산자
            Console.WriteLine("논리연산자");
            Console.WriteLine(10 > 9 && a > 0);//true
            Console.WriteLine(a > b || a > 0);//true
            Console.WriteLine(!(a > b));

            //조건연산자 단항if문을 대체가능
            int c = 30;
            string result=c==30? "삼십" : "삼십아님";
            Console.WriteLine(result);

            Console.WriteLine("NULL 병합연산자");
            int? d = null;
            Console.WriteLine($"{d ?? 0}");


        }
    }
}
