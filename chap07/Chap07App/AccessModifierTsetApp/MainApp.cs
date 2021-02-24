using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifierTsetApp
{

    class Boiler
    {
        private int temp; //물온도

        public void SetTemp(int temp)
        {
            if (temp< 30 || temp>60)
            {
                Console.WriteLine($"물의 온도가 일정온도를 벗어났습니다. 59로 맞춥니다.");
                this.temp = 59;
                return;
            }
            else
            {
                this.temp = temp;
            }

        }
        public int GetTemp()
        {
            return this.temp;
        }
        public void TurnOnBoiler()
        {
            Console.WriteLine("보일러를 켭니다.");
        }
        public void TurnOffBoiler()
        {
            Console.WriteLine("보일러를 끕니다.");
        }

    }
    
    class MainApp
    {
        static void Main(string[] args)
        {
            Boiler kitturami = new Boiler();
            //위 class에서 public을 사용하지 않았기 때문에 kitturami.을 눌러도 위에 설정한 메소드가 나오지 않음.
            var currTemp = kitturami.GetTemp();
            Console.WriteLine($"현재 온도는 {currTemp}");
            kitturami.SetTemp(40);
            kitturami.TurnOnBoiler();
            kitturami.SetTemp(59);
            if (kitturami.GetTemp()>=59)
            {
                kitturami.TurnOffBoiler();

            }
                
            /*kitturami.TurnOnBoiler();
            Console.WriteLine($"현재 온도는 {kitturami.temp}입니다.");
            kitturami.TurnOffBoiler();*/
        }
    }
}
