using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chap09App
{
    class MyClass
    {
        private int iValue; //0~120 값만 입력받는 멤버변수
        private double dZeta;
        private float fPng;
        private string strVal;
        private int incode;

        public int IValue
        {
            get 
            {
                return this.iValue;
            }
            set
            {
                if (value < 0)
                    this.iValue = 0;
                else if (value > 120)
                    this.iValue = 120;
                else
                    this.iValue = value;
                
            }
        }
        public MyClass(int iValue)
        {
            IValue = iValue;
        }
        public void PrintValue()
        {
            Console.WriteLine($"값은 {this.iValue}이다");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
           MyClass myClass = new MyClass(1200);
           myClass.PrintValue();

            // myClass.SetValue(108);
            myClass.IValue = 10;
           myClass.PrintValue();
            //  Console.WriteLine($"현재 온도는 {myClass.GetValue()}입니다.");
            Console.WriteLine($"현재온도는 {myClass.IValue}입니다");
        }
    }
}
