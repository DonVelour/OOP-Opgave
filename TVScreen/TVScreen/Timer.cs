using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TVScreen
{
    class Timer
    {
        public void TimeToShutdown()
        {
            Television tele = new Television();
            int time = 600;
            while(time >= 0)
            {
                time = time - 1;
                Thread.Sleep(1000);
            }
            Console.WriteLine("Times up \nPress a button");
            tele.mode = false;
            
        }
        
    }
}
