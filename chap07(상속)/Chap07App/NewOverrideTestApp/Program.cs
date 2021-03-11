using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewOverrideTestApp
{
    class Mammal
    {
        public string Name { get; set; }

        public void Breathe()
        {
            Console.WriteLine($"{this.Name}이(가) 숨을 쉰다.");
        }
        public virtual void Move()
        {
            Console.WriteLine($"{this.Name}이(가) 이동한다.");
        }

    }
    class Dog : Mammal
    {
        public override void Move()
        {
            Console.WriteLine($"{this.Name}이(가) 네발로 달린다.");
        }
    }
    class Human : Mammal
    {
        public new void Move()// 부모에 있는 메서드를 숨긴다.(new!)
        {
            base.Move();
            Console.WriteLine($"{this.Name}이(가) 두발로 달린다.");
        }
    }
    class Whale : Mammal
    {
        public override void Move()
        {
            base.Move();
            Console.WriteLine($"{this.Name}은(는) 헤엄친다.");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Mammal mammal = new Mammal();
            mammal.Name = "박규민";
            mammal.Move();

            Dog dog = new Dog();
            dog.Name = "뽀삐";
            dog.Move();

            Whale whale = new Whale();
            whale.Name = "고래";
            whale.Move();


        }
    }
}
