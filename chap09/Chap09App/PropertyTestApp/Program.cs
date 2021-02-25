using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyTestApp
{
    //생일정보 클래스
    class BirthdayInfo
    {
        private string name;
        private DateTime birthday;

        public string _name
        {
            get { return this.name; }
            set { this.name = value; }
        }
        public DateTime _birthday
        {
            get { return this.birthday; }
            set { this.birthday = value; }//value는 프로그램안에 존재하는 값
        }
        public string GetName()
        {
            return this.name;
        }
        public void SetName(string name)
        {
            this.name = name;
        }
        public DateTime GetBirthday()
        {
            return this.birthday;
        }
        public void SetBirthday(DateTime birthday)
        {
            this.birthday = birthday;
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            BirthdayInfo info = new BirthdayInfo();
            info.SetName("홍길동");
            info.SetBirthday(new DateTime(1990, 1, 8));

            Console.WriteLine($"이름 : {info.GetName()}");
            Console.WriteLine($"생년월일 : {info.GetBirthday()}");

            BirthdayInfo info2 = new BirthdayInfo();
            info2._name = "홍길순";
            info2._birthday = new DateTime(1996,01,04);

            Console.WriteLine($"이름 : {info2._name}");

            Console.WriteLine($"생년월일 : {info2._birthday}");

        }
    }
}
