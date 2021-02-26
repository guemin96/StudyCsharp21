using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewTypeCastApp
{
    class Mammal // 포유류
    {
        public string Name { get; set; }
        public void Nurse()
        {
            Console.WriteLine($"{this.Name}을/를 키우다");
        }
    }
    class Dog : Mammal
    {
        public void Bark()
        {
            Console.WriteLine($"{this.Name}, 멍멍!");
        }
    }
    class Cat : Mammal
    {
        public void Meow()
        {
            Console.WriteLine($"{this.Name}, 야옹!!");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Mammal mammal = new Dog();//new Mammal(); dog 값을 넣어줬지만 mammal 자체가 mammal(부모 형식)이기 때문에 mammal에서 bark를 사용하지 못한다.(부모는 자식이 될 수 없기 때문에!!!)
            //하지만 mammal is dog라고 물었을 때 true라는 값을 줄 수 있다.
            mammal.Name = "포유류";
            mammal.Nurse();
           

            Dog ppopi = null; //= new Dog();
            /*ppopi.Name = "뽀삐";
            ppopi.Nurse();
            ppopi.Bark();*/

            Cat chichi = new Cat();
            chichi.Name = "치치";
            chichi.Nurse();
            chichi.Meow();

            if (ppopi is Mammal)// null 이면 형식 ppopi is Mammal 했을 때 형식도 null로 인식되어 false 값이 나오게 된다.
            {
                Mammal mammal1 = ppopi as Mammal;//ppopi의 값을 지정해주는 것이 아니라(메인이 아님) mammal의 값이 중심이 됨 ppopi as Mammal은 그저 복사하여 mammal1의 값에 넣어주기 위한 역할
                //ppopi(자손)의 값을 mammal(부모)의 값에 넣는 것은 상관없기 때문에 as Mammal이라는 형변환을 하지 않아도 됨
                mammal1.Nurse();
                //mammal1.Bark(); 에러 발생

            }
            if (mammal is Dog)// 부모은 자손이 될 수 없기 때문에 false가 나오지만 위에서 new Dog() 라는 값을 넣어줬기 때문에 dog 형식을 가지고 있기 때문에 true가 된다.
            {
                ppopi = mammal as Dog;//ppopi는 자손의 형식인데 mammal은 부모의 형식이기 때문에 mammal을 dog(자손)의 형식으로 바꿔주지 않으면 ppopi에 값을 넣을 수 없다.
                ppopi.Nurse();
                ppopi.Bark();
            }
        }
    }
}
