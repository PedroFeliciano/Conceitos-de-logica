using System;

namespace Editorhtml
{
  public static class Menu 
  {
      public static void   Show()
      {
          Console.Clear();
          Console.BackgroundColor = ConsoleColor.Blue;
          Console.ForegroundColor = ConsoleColor.Black;
        
        DrawScreen();
        WriteOptions();

        var option = short.Parse(Console.ReadLine());
      }

  public static void DrawScreen()
  {
    Console.Write("+");
    for (int i = 0; i <= 30; i++)
       Console.Write("-");  
    
    Console.Write("+");
    Console.Write("\n");

    for(int lines =0; lines <=10; lines++)
    {
      Console.Write("|");
      
      for (int i = 0; i <= 30; i++)
        Console.Write(" ");

      Console.Write("|");
      Console.Write("\n");
    }
  Console.Write("+");
    for (int i = 0; i <= 30; i++)
       Console.Write("-"); 
  
  } 
  
  public static void WriteOptions()
  {
   Console.SetCursorPosition(3,2);
   Console.WriteLine("Editor Html");
   Console.SetCursorPosition(3,3);
   Console.WriteLine("===========");
   Console.SetCursorPosition(3,4);
   Console.WriteLine("Selecione uma opção");
   Console.SetCursorPosition(3,6);
   Console.WriteLine("1-Novo Arquivo");
   Console.SetCursorPosition(3,7);
   Console.WriteLine("2-Abrir");
   Console.SetCursorPosition(3,9);
   Console.WriteLine("0-Sair");
   Console.SetCursorPosition(3,10);
   Console.Write("Opção: ");
  }

  } 
}