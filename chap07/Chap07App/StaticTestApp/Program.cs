using System;

namespace StaticTestApp
{
    class TestClass
    {
        public static int number;
        public float fnum;

        public float ProSomething()
        {
            Console.WriteLine($"{number}, 먼가를 한다.");
            return 1.0f;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            TestClass.number = 10;
            TestClass aCls = new TestClass();
            
            aCls.fnum = 3.25f;

            TestClass bCls = new TestClass();
           
            bCls.fnum = 4.87f;

            aCls.ProSomething();
            bCls.ProSomething();
            
        }
    }
}
