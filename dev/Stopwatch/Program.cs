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

          Console.Clear();  
        Console.WriteLine("Valor do tempo:");
        int v1 = int.Parse(Console.ReadLine());

            int time=v1;
            int currentTime =0; 
            
            while(currentTime != time )
            {
             Console.Clear();
              currentTime ++;
              Console.WriteLine(currentTime);
             Thread.Sleep(1000);  
            }
            Console.WriteLine("O tempo acabou");
            Start();        
        }


    }
}
