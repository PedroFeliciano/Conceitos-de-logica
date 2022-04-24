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

         Console.WriteLine("-----------------------");
         Console.WriteLine("Selecione uma opção");
         short res = short.Parse(Console.ReadLine());
        
         switch(res) {
            
            case 1: Soma();break;
            case 2: Subtracao();break;
            case 3: Divisao();break;
            case 4: Multiplicaçao();break;
            default: Menu();break;
                   
         }

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
        Menu();
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
        Menu();
        
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
            Menu();

        }

        static void Multiplicaçao(){
            Console.Clear();

            Console.WriteLine("Primeiro Valor:");
            float v1 = float.Parse(Console.ReadLine());
        
           Console.WriteLine("Segundo Valor");
           float v2 = float.Parse(Console.ReadLine());

           float  resultado = v1*v2;                
           Console.WriteLine($"O Valor da Multiplicação é:{resultado}");

           Console.ReadKey();  
           Menu();

        }


    }  


        
          
}      
    
          
   
         
          
    
    
           
    
    
