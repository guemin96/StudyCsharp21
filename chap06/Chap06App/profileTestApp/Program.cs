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

            printProfile(phone:"010-9999-9999",name:"홍길동");
            printProfile(name: "홍길순", phone: "010-9939-0987");
            printProfile("박규민");

        }
        public static int printProfile(string name, string phone = "010-7979-7979")// default 파라미터는 뒤에서부터 들어갈 수 있음 지금 경우에 name에는 디폴트값을 넣고 phone에는 넣지 않으면 오류가 남
            //그렇기 때문에 name에만 디폴트 값을 넣고 싶으면 순서를 바꿔주는게 좋음
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
