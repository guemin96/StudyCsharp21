using System;
using System.Collections.Generic;
using System.Text;

namespace 문제_풀기
{
    interface Interface1
    {
        public void input()
        {
            Console.Write("이름 : ");
            string name = Console.ReadLine();
            Console.Write("전화 : ");
            string number = Console.ReadLine();
            Console.Write("주소 : ");
            string add = Console.ReadLine();
        }
    }
}
