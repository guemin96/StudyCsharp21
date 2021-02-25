using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritTestApp
{
    class Parent
    {
        protected string Name;

        public Parent(string Name)
        {
            this.Name = Name;
            Console.WriteLine($"{this.Name=Name}.parent() 생성자");
        }
        public void ParentMethod()
        {
            //...
            Console.WriteLine($"{this.Name}.ParentMethod() 실행");
        }
    }

    class Child : Parent
    {
        public string Color; //색상

        public Child(string Name) : base(Name)
        {
            
            Console.WriteLine($"{this.Name}.child() 생성자");

        }
        public void ChildMethod()
        {
            Console.WriteLine($"{this.Name}.ChildMethod() 실행");
        }

    }
    class MainApp
    {
        static void Main(string[] args)
        {
            Parent p = new Parent("부모");
            p.ParentMethod();
            

            Child c = new Child("자식");
            //c.Color = "황색";
            c.ParentMethod();
            c.ChildMethod();
            
        }
    }
}
