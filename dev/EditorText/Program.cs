using System;
using System.IO;
using System.Threading.Tasks;

namespace EditorText
{
    class Program
    {
        static  void Main(string[] args)
        {
           ShowingAsyncronous().Wait();
        }
        public static  async Task ShowingAsyncronous(){
          var list = new char[]{'E','u',' ','s','e','i', ' ', 'O','n','d','e', ' ', 'v','o','c', 'ê',' ', 'm','o','r','a'};
          var text = string.Empty;
          await Task.Delay(1000);
          for (int i = 0; i < list.Length; i++)
          {
            Console.ForegroundColor = ConsoleColor.Green;
            // Console.ForegroundColor = i % 2 == 0 ? ConsoleColor.Green :ConsoleColor.Blue ;
            await Task.Delay(250);
            Console.Write(list[i]);
            
          }
        }
    
      static void Menu(){
        

      Console.Clear();
      
      Console.WriteLine("O que deseja Fazer?");
      Console.WriteLine("");     
      Console.WriteLine(" 1 ABRIR ARQUIVO");
      Console.WriteLine("");
      Console.WriteLine(" 2 CRIANDO NOVO ARQUIVO");
      Console.WriteLine("");
      Console.WriteLine(" 0 - SAIR");
      Console.WriteLine("");
      short option = short.Parse(Console.ReadLine());

       switch(option){
      
      case 0:System.Environment.Exit(0); break;
      case 1:Abrir();break;
      case 2:Editar();break;
      default: Menu();break;
       
       }

      
      }
      

      static void Abrir(){
    Console.Clear();
    Console.WriteLine("Qual é o caminho do arquivo?");
     string path = Console.ReadLine();
     
      using(var file = new StreamReader(path))
      {
         string text  =  file.ReadToEnd();
         Console.WriteLine(text);
      }
      
      Console.WriteLine("");
      Console.ReadLine();
      Menu();
      
      }
      static void Editar(){
     
     Console.Clear();
     Console.WriteLine("Digite qualquer coisa");
     Console.WriteLine("---------------------");
     string text = "";

    do
    {
      text += Console.ReadLine();
      text += Environment.NewLine;
    }
    while(Console.ReadKey().Key != ConsoleKey.Escape);
     
     Salvar(text);
      }


     static void Salvar(string text){

       Console.Clear();
       Console.WriteLine("Qual meio de salvamento do arquivo?");
       var path = Console.ReadLine();
     
       using (var file = new StreamWriter(path))
       {
          file.Write(text);
       }
     
      Console.WriteLine($"Arquivo{path} salvo com sucesso!");
      Console.Read();
      Menu();
     }


    }
    
}

