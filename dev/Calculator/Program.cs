using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
         Divisao();

        } 
        

        static void Soma(){
        Console.Clear();
         
         Console.WriteLine("Primeiro Valor:");
         float v1 =  float.Parse(Console.ReadLine());

         
         Console.WriteLine("Segundo Valor:");
         float v2 =  float.Parse(Console.ReadLine());
          

         float soma = v1 + v2;
         Console.WriteLine($"O resultado é {soma} "); 
         
         Console.ReadLine();
         Console.ReadKey();

        }
    
        static void Subtracao(){
         
        Console.Clear();

        Console.WriteLine("Primeiro Valor");
        float v1 = float.Parse(Console.ReadLine());
          
        Console.WriteLine("Segundo Valor");
        float v2 = float.Parse(Console.ReadLine());  
        
        float subtraçao = v1-v2;
        Console.WriteLine($"O Resultado  é {subtraçao}");
        
        Console.ReadKey();

        }     
    
        static void Divisao(){

            Console.Clear();

            Console.WriteLine("Primeiro Valor");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo Valor");
            float v2 = float.Parse(Console.ReadLine());

            float resultado = v1/v2;
            Console.WriteLine($"O Valor da Divisão é:{resultado}");

            Console.ReadKey();                                                       
        }

    }  


        
          
}      
    
          
   
         
          
    
    
           
    
    
