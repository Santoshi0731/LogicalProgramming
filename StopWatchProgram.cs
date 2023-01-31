using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgram
{
    public class StopWatchProgram
    {
        public static void DisplayStopwatchProgram()
        {
            Stopwatch stopwatch= new Stopwatch();
            stopwatch.Start();

            for(int i=0; i<100; i++) 
            {
                Thread.Sleep(2);
            }
            stopwatch.Stop();
            Console.WriteLine("Time elapsed : {0}", stopwatch.Elapsed);
        }
    }
}
