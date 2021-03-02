using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chap11App
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] source = { 11, 21, 33, 45, 56 }; // 5개 짜리 int 배열
            int[] target = new int[source.Length];

            CopyArray(source, target); // int 배열 복사
            Console.WriteLine("배열 복사");
            foreach (var item in target)
            {
                Console.WriteLine(item);

            }
            string[] source2 = { "하나", "둘", "셋", "넷" };
            string[] target2 = new string[source2.Length];

            CopyArray2(source2, target2);
            foreach (var item in target2)
            {
                Console.WriteLine(item);

            }
            float[] source3 = { 1.1f, 2.2f, 3.3f, 4.4f };
            float[] target3 = new float[source3.Length];

            CopyArray3(source3, target3);
            foreach (var item in target3)
            {
                Console.WriteLine(item);

            }
        }

        private static void CopyArray3(float[] source3, float[] target3)
        {
            for (int i = 0; i < source3.Length; i++)
            {
                target3[i] = source3[i];

            }
        }

        private static void CopyArray2(string[] source2, string[] target2)
        {
            for (int i = 0; i < source2.Length; i++)
            {
                target2[i] = source2[i];

            }
        }

        private static void CopyArray(int[] source, int[] target)
        {
            for (int i = 0; i < source.Length; i++)
            {
                target[i] = source[i];

            }
        }
    }
}
