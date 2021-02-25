using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultinterfaceApp
{
    interface IRunnable // 자동차 종류
    {
        void Run();
    }
    interface IFlyable//
    {
        void Fly();
    }
    class DroneCar : IRunnable, IFlyable
    {
        public void Fly()
        {
            Console.WriteLine("날아");
        }

        public void Run()
        {
            Console.WriteLine("달려");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("드론카!");

            DroneCar dreamCar = new DroneCar();
            dreamCar.Fly();
            dreamCar.Run();

            Console.WriteLine("자동차로 변경(interface)");
            IRunnable car = dreamCar;//dreamCar는 DronCar의 지역 변수이기 때문에 부모인 IRunnable로 가는 것 됨
            car.Run();

            IFlyable plane = dreamCar;
            plane.Fly();

        }
    }
}
