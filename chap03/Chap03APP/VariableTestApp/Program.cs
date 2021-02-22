using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariableTestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            /*int v1 = 30 , v2 = 40;
            int result = v1 + v2;
            Console.WriteLine("결과는"+result);*/
            sbyte sbval = sbyte.MaxValue;
            sbyte sbminval = sbyte.MinValue;
            Console.WriteLine(sbval);
            Console.WriteLine(sbminval);
            Console.WriteLine(sbval+sbminval);
            Console.WriteLine($"sbyte 최소, 최대값은 {sbminval},{sbval} 입니다.");
            byte bminval = byte.MinValue, bmaxval = byte.MaxValue;
            Console.WriteLine($"byte 최소, 최대값은 {bminval},{bmaxval} 입니다.");
            short shMinval = short.MinValue, shmaxval = short.MaxValue;
            Console.WriteLine($"short 최소, 최대값은 {shMinval},{shmaxval} 입니다.");
            ushort usminval = ushort.MinValue, usmaxval = ushort.MaxValue;
            Console.WriteLine($"ushort 최소, 최대값은 {usminval},{usmaxval} 입니다.");

            int inminval = int.MinValue, inmaxval = int.MaxValue;
            Console.WriteLine($"int 최소, 최대값은 {inminval},{inmaxval} 입니다.");

            uint uiminval = uint.MinValue, uimaxval = uint.MaxValue;
            Console.WriteLine($"uint 최소, 최대값은 {uiminval},{uimaxval} 입니다.");

            long lominval = long.MinValue, lomaxval = long.MaxValue;
            Console.WriteLine($"long 최소, 최대값은 {lominval},{lomaxval} 입니다.");

            ulong ulminval = ulong.MinValue, ulmaxval = ulong.MaxValue;
            Console.WriteLine($"ulong 최소, 최대값은 {ulminval},{ulmaxval} 입니다.");



            // float형
            float fminval = float.MinValue, fmaxval = float.MaxValue;
            Console.WriteLine($"float 최소, 최대값은 {fminval},{fmaxval} 입니다.");
            //double
            double dminval = double.MinValue, dmaxval = double.MaxValue;
            Console.WriteLine($"double 최소, 최대값은 {dminval},{dmaxval} 입니다.");
            //Decimal
            Decimal deminval = Decimal.MinValue, demaxval = Decimal.MaxValue;
            Console.WriteLine($"decimal 최소, 최대값은 {deminval},{demaxval} 입니다.");



        }
    }
}
