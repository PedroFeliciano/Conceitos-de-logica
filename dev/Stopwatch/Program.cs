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

      string data = Console.ReadLine().ToLower();
      char type = char.Parse(data.Substring(data.Length-1,1));
      int time = int.Parse(data.Substring(0,data.Length-1));
      int multplier = 1;
      //registra o ultimo caracter 

    if(type=='m')
       multplier = 60;    
    
    if (time==0)
       System.Environment.Exit(0);
       Start(time * multplier);

    
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
