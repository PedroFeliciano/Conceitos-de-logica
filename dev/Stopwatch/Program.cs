using System;
using System.Threading;
using System.Threading.Tasks;

namespace Stopwatch
{
    class Program
    {
        static void Main()
        {
            Start();
        }

        static void Start()
        {

            int time=10;
            int currentTime =0; 
            
            while(currentTime != time )
            {
             Console.Clear();
              currentTime ++;
              Console.WriteLine(currentTime);
             Thread.Sleep(1000);  
            }
            Console.WriteLine("O tempo acabou");
        }
    }
}
