using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VarTestApp
{
    class Program
    {
        //Var I = 100; Var는 지역 변수로써 메소드 안에서만 사용 가능하다
        static void Main(string[] args)
        {
            var i = 100.5;
            Console.WriteLine($"정수값은 {i}입니다.");
        }
    }
}
