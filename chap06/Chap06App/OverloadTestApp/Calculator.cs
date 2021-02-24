using System;

namespace OverloadTestApp
{
    class Calculator
    {
        static void Main(string[] args)
        {
            Console.WriteLine("계산기!");

            int x = Calculator.Plus(3, 4);

            Console.WriteLine($" 3 + 4 = {x}");


            float y = Calculator.Plus(3.14f, 5.6f);
            Console.WriteLine($" 3.14 + 5.6 = {y}");

            Console.WriteLine($"3.14 + 5.6 ={Calculator.Plus(3.14 , 5.6)}"); //실수형 

            Console.WriteLine($"3.14 + 5 ={Calculator.Plus(3.14, "5")}"); //실수형 

            int z = Calculator.Sum(7, 8, 9);

            Console.WriteLine(z);

            int total = 0;
            total = Sum(1, 2, 3);

            Console.WriteLine($"합계는 {total}");

            Console.WriteLine($"1~10까지의 합은 {Sum(1,2,3,4,5,6,7,8,9)}");

            int[] arry = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            Console.WriteLine($"1~10까지의 합은 {Sum(arry)}");
        }

        
        
        private static int Sum(params int[] args)//가변길이 매개 함수 
        {
            int result = 0;
            foreach (var arg in args)
            {
                result += arg;//result = result + arg;

            }
            return result;
        }

        private static double Plus(double v1, string v2)
        {
            double.TryParse(v2, out double p2);
            double result = v1+ p2;
           
            
            return result;
        }

        private static double Plus(double v1, double v2)
        {
            double result = v1 + v2;
            return result;
        }

        private static float Plus(float v1, float v2)
        {
            float result = v1 + v2;
            return result;
        }

        private static int Plus(int p1, int p2)
        {
            int result = p1 + p2;
            return result;
        }
    }
}
