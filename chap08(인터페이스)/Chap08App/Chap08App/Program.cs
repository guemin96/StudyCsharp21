using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chap08App
{
    interface ILogger
    {
        void WriteLog(string msg);
    }

    class ConsoleLogger : ILogger
    {
        public void WriteLog(string msg)
        {
            Console.WriteLine($"{DateTime.Now} log : {msg}!!");
        }
    }

    class CustomLogger : ILogger
    {
        public void WriteLog(string msg)
        {
            Console.WriteLine($"Log : {msg}\a\a");
        }
    }

    class ClimateLogger
    {
        private ILogger logger;
        public ClimateLogger(ILogger logger)//climateLogger 클래스를 사용할 때 인수 값으로는 ILogger를 사용한 클래스만 넣을 수 있다.()안에 ILogger logger이 들어 있기 때문에 
        {
            this.logger = logger;
        }
        public void Start()
        {
            while (true)
            {
                Console.WriteLine("온도를 입력 : ");
                string temp = Console.ReadLine();//
                if (string.IsNullOrEmpty(temp)) break;

                logger.WriteLog($"현재온도 : {temp}");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            ConsoleLogger logger = new ConsoleLogger();//Ilogger logger = new ConsoleLogger();로 해도 상관없음 왜냐 consoleLogger가 ILogger를 구현했기 때문에
            logger.WriteLog("로그 출력!");//직접 제어

            ClimateLogger clogger = new ClimateLogger(new CustomLogger());
            clogger.Start();//IOC (제어의 역전(역흐름))
        }
    }
}
