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
            포유류 _포유류 = new 포유류();// 클래스의 내용을 가지고 와야되기 때문에
            _포유류.키우다();
            

            _포유류 = new 강아지();//포유류->강아지 큰거(부모)에서 작은것(자식)으로 가는 것은 상관없음
            _포유류.키우다();
            강아지 쭈쭈;//쭈쭈에 new class를 통해 따로 적용시켜주지 않았기 때문에 밑에서 넣어줘야함

            if (_포유류 is 강아지)
            {
                Console.WriteLine("쭈쭈도 되나");
                쭈쭈 = _포유류 as 강아지;// 쭈쭈는 그저 강아지의 지역 변수로만 지정되어 있는 것임, 값을 생성해줘야 함
                쭈쭈.멍멍();
            }




            강아지 뽀삐 = new 강아지(); //강아지 뽀삐라는 지역 변수에 강아지 클래스를 넣어줌
            뽀삐 = null;// null???? 왜 넣는지 잘 모르겠음.. 그리고 생략하면 왜 오류가 나는 것이고 
            if (뽀삐 is 포유류)//강아지 -> 포유류   작은것(자식)에서 큰거(부모)으로 가는 것은 안됨.. overriding(값이 넘쳐버리게 됨)
            {
                Console.WriteLine("이 부분이 실행됩니다.");
                뽀삐 = new 포유류() as 강아지;
                뽀삐.키우다();
                뽀삐.멍멍();

            }
            
        }
    }
}
