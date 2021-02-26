using System;

namespace 문제_풀기
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--------------");
            
            _0add a = new _0add();
            a._0(Console.ReadLine());
            Console.WriteLine("1. 주소 검색");

            Console.WriteLine("2. 주소 수정");

            Console.WriteLine("3. 주소 삭제");

            Console.WriteLine("4. 주소 전체 출력");

            Console.WriteLine("5. 프로그램 종료");
            Console.WriteLine("--------------");
            Console.WriteLine("메뉴를 선택하세요>>>");
        }
    }
}
