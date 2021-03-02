﻿using System;

namespace CallbackTestApp
{
    delegate int Compare(int a, int b); //a, b 비교 대리자.

    class Program
    {
        //오름차순 a>b 1리턴,같으면 0리턴, a<b 작으면 -1리턴(a기준!!)
        static int AscendCompare(int a, int b)
        {
            if (a > b) return 1;
            else if (a == b) return 0;
            else return -1;


        }
        //내림차순 비교, a<b이면 1리턴, 같으면 0,a>b이면 -1리턴

        static int DescendCompare(int a, int b)
        {
            if (a < b) return 1;// b와 a의 순서를 바꿈
            else if (a == b) return 0;
            else return -1;
        }
        static void BubbleSort(int[] DataSet, Compare comparer)
        {
            int temp = 0;
            for (int i = 0; i < DataSet.Length; i++)
            {
                for (int j = 0; j < DataSet.Length-(i+1); j++)
                {
                    //비교하여 값 위치 변경 Swap
                    if (comparer(DataSet[j],DataSet[j+1])>0)
                    {
                        temp = DataSet[j + 1];
                        DataSet[j + 1] = DataSet[j];
                        DataSet[j] = temp;
                    }
                }

            }

        }


        static void Main(string[] args)
        {
            int[] array = { 3, 8, 4, 2, 1, 10 };

            Console.WriteLine("Sorting...");

            BubbleSort(array, new Compare(DescendCompare));// 오름(내림)차순 정렬, delegate를 사용하는 이유는 winform에서 사용자가 이벤트를 실행할 수 도 있고 안할 수도 있기 때문에
            //무조건적으로 실행되는 코딩을 막기 위함이다.
            foreach (var item in array)
            {
                Console.WriteLine($"{item}");
            }
        }
    }
}
