using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace profileTestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            
            printProfile("박규민","01046329171");

            if (printProfile(null, "01033333333") == -1)
            {
                Console.WriteLine("프로필 출력시 오류가 발생했습니다.");
            }


        }
        public static int printProfile(string name, string phone)
        {
            if (string.IsNullOrEmpty(name))
            {
                Console.WriteLine("이름을 넣어주세요.");
                return -1;
            }
            
            //프로필 출력
            Console.WriteLine($"name:{name},phone:{phone}");
            return 0;
        }
    }
}
