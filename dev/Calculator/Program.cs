﻿using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
         Soma();
         
        }
        static void Soma()
        {
Console.Clear();

          Console.WriteLine("Primeiro valor:");
          float v1 =float.Parse (Console.ReadLine());

          Console.WriteLine();

          Console.WriteLine("segundo valor:");
          float v2 = float.Parse(Console.ReadLine());
        
         Console.WriteLine("");
         
         float resultado = v1 + v2 ;
         Console.WriteLine("O resultado da some é :" + resultado);
        }
    
     static void Subtracao() {
       
       Console.Clear();
       
       Console.WriteLine("Primeiro Valor:");
       float v1 = float.Parse(Console.ReadLine());

        Console.WriteLine("Segundo Valor:");
       float v2 = float.Parse(Console.ReadLine());
    
              Console.WriteLine("");
       
       float resultado = v1-v2;
        Console.WriteLine("o resultado da subtraçao é " + resultado );      
   
          Console.ReadKey();   
    }


}
