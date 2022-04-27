using System;
using System.Threading;
using System.Threading.Tasks;

namespace Stopwatch
{
    class Program
    {
        static void Main()
        {
            Menu();
        }
           
     static void Menu(){
     
       Console.Clear();
       Console.WriteLine("S = Segundos");
       Console.WriteLine("M= Minuto");
       Console.WriteLine("0= Sair");
       Console.WriteLine("Qunato tempo deseja?");

     }

     

        static void Start(int time)
        {
            int currentTime =0; 
            
            while(currentTime != time )
            {
             Console.Clear();
              currentTime ++;
              Console.WriteLine(currentTime);
             Thread.Sleep(1000);  
            }
            Console.Clear();
            Console.WriteLine("O tempo acabou");
            Thread.Sleep(2500);
        }


    }
}
