using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialClassApp
{
    partial class MyClass//partial을 사용함으로써 MyClass라는 클래스를 나눠서 저장할 수 있다.
    {
        public void Method3() { Console.WriteLine("Method3"); }
        public void Method4() { Console.WriteLine("Method4"); }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyClass _myclass = new MyClass();
            _myclass.Method1();
            _myclass.Method2();
            _myclass.Method3();
            _myclass.Method4();
        }
    }
}
