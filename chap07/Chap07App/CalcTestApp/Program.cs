using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcTestApp
{
    class Program
    {
        static void Main(string[] args)
        {

            /*//...
            calc cal1 = new calc();*/

            calc cal2 = new calc();
            cal2.plus(1, 2);
            

            int x;
            x = 6;
            
            calc.printEven(x);

            x = 10;
            calc.printEven(x);



            //...
           /* x = 5;
            if (x%2==0)
            {
                Console.WriteLine($"x의 값은 {x}");
           
            }
            //...

            x = 10;
            if (x%2==0)
            {
                Console.WriteLine($"x의 값은 {x}");

            }*/

            /*
            cal1.printEven(10);*/
            
        }
        public class calc
        {
            public int plus(int a, int b)
            {
                int result = a + b;
                Console.WriteLine(result);
                return result;
            }
            public static void printEven(int val)// static을 사용하게 되면 메모리를 많이 잡아먹기 때문에 무조건 static을 사용할 수는 없다.
            {
                if (val %2 ==0)
                {
                    Console.WriteLine($"x값은 {val}");
                }
                
            }

        }
    }
}
