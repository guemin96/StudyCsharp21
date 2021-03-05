using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadStateApp
{
    class Program
    {
        static void Printstate(ThreadState state)
        {
            Console.WriteLine($"{state,-16} : {(int)state}");
        }
        static void Main(string[] args)
        {
            Printstate(ThreadState.Running);

            Printstate(ThreadState.Aborted);
            Printstate(ThreadState.StopRequested);
            Printstate(ThreadState.SuspendRequested);
            Printstate(ThreadState.Suspended);
            Printstate(ThreadState.Stopped);
            Printstate(ThreadState.Unstarted);
            Printstate(ThreadState.WaitSleepJoin);
            Printstate(ThreadState.AbortRequested);
            Printstate(ThreadState.Aborted);

        }
    }
}
