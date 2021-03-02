using System;
using System.Collections;

namespace HashTableApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Hashtable ht = new Hashtable();
            ht["일"] = "One";
            ht["이"] = "Two";
            ht["삼"] = "Three";
            ht["사"] = "Four";
            ht["오"] = "Five";
            //컬럼명 : 값 ,DB랑 연동할 때 많이 사용
            Console.WriteLine(ht["일"]); // One
            Console.WriteLine(ht["이"]); // Two
            Console.WriteLine(ht["사"]); // Four
            Console.WriteLine(ht["오"]); // Five

            foreach (DictionaryEntry item in ht)
            {
                Console.WriteLine($"{item.Key} : {item.Value}");// 정렬X 키 값

            }
            
            int[] arr = { 123, 456, 789 };
            ArrayList list = new ArrayList(arr);
            ArrayList list2 = new ArrayList(new int[] { 123, 456, 789 });
            ArrayList list3 = new ArrayList() { 123, 456, 789 };

            foreach (var item in list)
            {
                Console.WriteLine(item);

            }

            Console.WriteLine($"{list}");
            Console.WriteLine(list2[2]);
            Console.WriteLine(list3);
        }
    }
}
