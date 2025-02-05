using System;

class Program
{
    static void Main(string[] args)
    {
      while(true){
        Console.Write("\n\nDigite a opção de menu desejada: ");
        int opcao = int.Parse(Console.ReadLine());
          switch(opcao){
      case 1: 
          Console.Clear();
          Console.Write("\nVocê está no menu 1!");
          break;
      case 2: 
          Console.Clear();
          Console.Write("\nVocê está no menu 1!");
          break;
      case 3: 
          Console.Clear();
          Console.Write("\nVocê está no menu 1!");
          break;
      default:
          Console.Write("Opção inválida!");
              break;
              }
          
      }
    }
}