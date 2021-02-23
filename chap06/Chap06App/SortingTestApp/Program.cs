using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingTestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 47, y = 5;

            Console.WriteLine($"Before Swap {x},{y}");
            
            Program.Swap(ref x, ref y);

            Console.WriteLine($"After Swap {x},{y}");


        }

        private static void Swap(ref int p1,ref int p2)
        {

            int temp = p1; // temp=47
            p1 = p2;//p1=5
            p2 = temp;//p2=47
            //여기까지 했을 때 값이 안바뀌는 이유는 p1,p2가 x,y의 복사값이기 때문에
            //ref 라는 함수를 사용하여 주소를 직접 찾아가 바꿔준다(call by address)->정렬을 해줄 때 많이 사용(오름차순,내림차순 등) 
        }
    }
}
