using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverrideTestApp
{
    class ArmorSuite
    {
        public virtual void Initialize()//초기화, virtual은 자식클래스에서 재정의를 한다는 소리
        {
            Console.WriteLine("ArmorSuite 초기화!");
        }
    }
    class IronMan : ArmorSuite
    {
        public override void Initialize()
        {
            base.Initialize();
            Console.WriteLine("리펄서 레이저 장착!");
        }
    }
    class WarMachine : ArmorSuite
    {
        public override void Initialize()
        {
            //base.Initialize(); 부모값을 기본 값으로 넣어줌, 사용자에 따라 생략하면 됨
            Console.WriteLine("ArmorSuiter개량 Warmachine 초기화!");
            Console.WriteLine("Double-Barrel 캐논 장착!");
            Console.WriteLine("Micro-Rocket 런처 장착!");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Armorsuite 생산");
            ArmorSuite suite = new ArmorSuite();
            suite.Initialize();

            Console.WriteLine("WarMachine 생산");
            WarMachine Machine = new WarMachine();
            Machine.Initialize();

            Console.WriteLine("Iron Man 생산!");
            IronMan ironMan = new IronMan();
            ironMan.Initialize();
        }
    }
}
