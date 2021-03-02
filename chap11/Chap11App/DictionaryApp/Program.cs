using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> pairs = new Dictionary<int, string>();//HashTable의 일반화 버전
            pairs[1] = "One";
            pairs[2] = "Two";
            pairs[3] = "Three";
            pairs[4] = "Four";
            pairs[5] = "Five";

            foreach (var item in pairs)
            {
                Console.WriteLine($"{item.Key} : {item.Value}");//순서가 순차적으로 나옴

            }

            Dictionary<string, string> pairs2 = new Dictionary<string, string>();
            pairs2["일"] = "One";
            pairs2["이"] = "Two";
            pairs2["삼"] = "Three";
            pairs2["사"] = "Four";
            pairs2["오"] = "Five";

            foreach (var item in pairs2)
            {
                Console.WriteLine(item);

            }

            Dictionary<int, string> pairs3 = new Dictionary<int, string>() 
            { { 1, "One" }, 
              { 2, "Two" },
              { 3, "Three" },
              { 4, "Four" },

            };
            

            foreach (var item in pairs3)
            {
                Console.WriteLine($"{item.Key} : {item.Value}");//순서가 순차적으로 나옴

            }
        }
    }
}
