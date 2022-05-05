using System;

namespace EditorText
{
    class Program
    {
        static void Main(string[] args)
        {
          Menu();
        }
    
      static void Menu(){

      Console.Clear();
      
      Console.WriteLine("O que deseja Fazer");
      Console.WriteLine("");     
      Console.WriteLine(" 1 ABRIR ARQUIVO");
      Console.WriteLine("");
      Console.WriteLine(" 2 CRIANDO NOVO ARQUIVO");
      Console.WriteLine("");
      Console.WriteLine(" 0 - SAIR");
      Console.WriteLine("");
      short option = short.Parse(Console.ReadLine());

      
      }


    }
}
