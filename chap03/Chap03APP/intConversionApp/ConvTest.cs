using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace intConversionApp
{
    class ConvTest
    {
        static void Main(string[] args)
        {
            short shMaxVal = short.MaxValue;
            int inCastVal = 0;

            inCastVal = shMaxVal;
            Console.WriteLine($"short값 변환한 int 값은 {inCastVal}");

            inCastVal += 5; //32767 + 5 32772
            short shCastVal = (short)inCastVal;
            Console.WriteLine($"short값 변환한 int 값은 {shCastVal}"); //overflow 값이 마이너스가 나옴


            float flVal = 3.141592F;//f or F를 맨 뒤에 써야됨
            inCastVal = (int)flVal;
            Console.WriteLine($"float값 변환한 int 값은 {inCastVal}");

            double dlVal = inCastVal;

            Console.WriteLine($"int값 변환한 double 값은 {dlVal}");


            object obj = 20; //boxing
            int inUnboxingVal = (int) obj; //unboxing

            string strVal = "200";
            int result = int.Parse( strVal) * 3;
            Console.WriteLine(result.ToString());
            Console.WriteLine($"200*3={result}");

            
        }
    }
}
