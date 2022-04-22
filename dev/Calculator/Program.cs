using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
         Menu();

        } 
        
        static void Menu(){
          
         Console.Clear();
         
         Console.WriteLine("...Oque Deseja ?:"); 
         Console.WriteLine("1-Soma");
         Console.WriteLine("2-Subtração");
         Console.WriteLine("3-Divisão");
         Console.WriteLine("4-Multiplicação");

         Console.WriteLine("------");
         Console.WriteLine("Selecione umaopção");
         short res = short.Parse(Console.ReadLine());

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

        static void Multiplicação(){
            Console.Clear();

            Console.WriteLine("Primeiro Valor:");
            float v1 = float.Parse(Console.ReadLine());
        
           Console.WriteLine("Segundo Valor");
           float v2 = float.Parse(Console.ReadLine());

           float  resultado = v1*v2;                
           Console.WriteLine($"O Valor da Multiplicação é:{resultado}");

           Console.ReadKey();  
        }


    }  


        
          
}      
    
          
   
         
          
    
    
           
    
    
