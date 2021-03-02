using System;

namespace TryCatchApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3 };
            try
            {
                
                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine($"{i}번째 값 : {arr[i]}");
                }
            }
            catch (IndexOutOfRangeException ex)//exception은 최상위에 있는 예외, 예외가 발생하는 순간 다음 식을 고려하지 않고 바로 예외 구문으로 넘어감
            {
                Console.WriteLine($"예외발생 : {ex.Message}");
               
            }
            catch(DivideByZeroException ex)
            {
                Console.WriteLine($"예외발생 : {ex.Message}");
            }
            Console.WriteLine("나머지 일처리 계속");

            int x = 108, y = 0;
            int result = 0;

            try
            {
                result = x / y;
                Console.WriteLine($"결과는 {result}");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine($"예외발생 : {ex.Message}");
                
            }
            Console.WriteLine("나머지 일처리 계속");

            string strVal = null;
            /*string splitVal = strVal.Substring(6, 5);
            Console.WriteLine($"자른 문자는 : {splitVal}");
            int idx = strVal.IndexOf("W");
            Console.WriteLine($"W의 위치 : {idx}");*/

           
            try
            {
                string splitVal = strVal.Substring(6, 5);
                Console.WriteLine($"자른 문자는 : {splitVal}");
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine($"원본 문자열이 비어있습니다. 값을 입력하세요. {ex.Message}");
                throw;
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine($"원본문자열을 초기화하세요. {ex.Message}");
                
            }
            catch(Exception ex)
            {
                Console.WriteLine($"기타 예외발생.{ex.Message}");
            }
            Console.WriteLine("일처리 또 있음");
        }
    }
}
