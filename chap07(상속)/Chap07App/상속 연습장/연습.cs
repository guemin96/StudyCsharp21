using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassTypeCastApp
{

    class 포유류
    {
        public void 키우다()
        {
            Console.WriteLine("자식을 키우다()");
        }
    }
    class 강아지 : 포유류
    {
        public void 멍멍()
        {
            Console.WriteLine("멍멍");
        }
    }
    class 고양이 : 포유류
    {
        public void 야옹()
        {
            Console.WriteLine("야옹!");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            포유류 a = new 포유류();// 클래스의 내용을 가지고 와야되기 때문에
            a.키우다();
            //사용자 정의를 사용하는 이유는 키우다()와 같은 여러 값을 넣어주기 위해서 


            a = new 강아지();// a는 포유류의 지역변수이다. 강아지의 참조를 넣어줘도 포유류의 지역변수를 가지고 있기 때문에 강아지의 참조인 멍멍을 사용할 수 없다.
            
            a.키우다();// 멍멍을 나오게 하고 싶을 때는
            (a as 강아지).멍멍();// 이렇게 하면 된다. as를 써서 형변환
            강아지 b = new 강아지();
            b.멍멍();
            b.키우다();
            


            강아지 쭈쭈;//쭈쭈에 new class를 통해 따로 적용시켜주지 않았기 때문에 밑에서 넣어줘야함

            if (a is 강아지)//a의 지역변수(본질은 포유류)는 포유류이지만 값은 강아지이기 때문에 a is 강아지(값)이 참이다.
            {
                Console.WriteLine("쭈쭈도 되나");
                쭈쭈 = a as 강아지;// 쭈쭈는 그저 강아지의 지역 변수로만 지정되어 있는 것임, 참조!!!!가 있어야지만 멍멍이나 키우기를 사용할 수 잇음
                쭈쭈.멍멍();//참조 을 넣어줘야 
            }

            // 부모가 자식에게 상속을 하는 것과 반대 개념으로 부모가 자식이 될 수는 없음
            // 반대로 자식이 부모에게 상속하는 것은 안되고 이와 반대로 자식이 부모는 될 수 있음


            //강아지 뽀삐 = new 강아지(); //강아지 뽀삐라는 지역 변수에 강아지 참조를 넣어줌

            강아지 뽀삐 = null;// null???? 왜 넣는지 잘 모르겠음.. 그리고 생략하면 왜 오류가 나는 것이고 
            if (뽀삐 is 포유류)//강아지(자식)가 포유류(부모)가 될 수 있기 때문에 true가 나옴, null을 넣었던 이유는 뽀삐 is 포유류를 false로 만들어 주기 위해서
            {
                Console.WriteLine("이 부분이 실행됩니다.");
                뽀삐 = new 포유류() as 강아지;
                뽀삐.키우다();
                뽀삐.멍멍();

            }

        }
    }
}
