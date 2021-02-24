using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chap07App
{
    class ObjectTest
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, world");

            Cat cat1= new Cat(Name : "야옹이",Color : "흰색",Gender : "남");//고양이 객체의 실체(instance) 생성
            /*cat1.Name = "고양이";//Name과 Color는 이렇게 따로 지정해주기
            cat1.Color = "흰색";*/
            cat1.Meow();

            Cat kitty = new Cat();
            kitty.Name = "헬로우 키티";
            kitty.Color = "하얀색";
            kitty.Meow();

            Cat Nero = new Cat();
            Nero.Name = "검은고양이 네로";
            Nero.Color = "검은색";
            Nero.Meow();

            Cat hungry = new Cat("배고파", "진짜", "레알로");
            
            hungry.Meow();

            Cat yomi = new Cat("요미","흰색","여");
            yomi.Meow();

        }

        class Cat
        {
            public Cat() { }
/*
            ~Cat() { }*/
            public Cat(string Name,string Color)//사용자 정의 생성자를 사용하려면 기본 생성자를 만들어야 됨
            {
                this.Name = Name;
                this.Color = Color;

            }

            public Cat(string Name, string Color, string Gender) : this(Name,Color)
            {
                /*this.Name = Name;
                this.Color = Color;*/
                this.Gender = Gender;
            }
            /*public Cat()
            {   
                Name= "배고파";
                Color= "죽을듯";
            }*/

                
            public string Name;
            public string Color;
            public string Gender;

            public void Meow()
            {
                Console.WriteLine($"{this.Name}({this.Color}/성별{this.Gender}) : 야옹");
            } 
        }
    }
}
