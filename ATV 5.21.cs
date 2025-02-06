using System;

class Program
{
    static void Main(string[] args)
    {
        int sequencia = 0;
      int x = 1;
      Console.Write("Digite uma sequencia de números ");

      do{
        Console.Write("\nPróximo número: ");
        x = int.Parse(Console.ReadLine());
        if(x >= 0){
          sequencia = sequencia + x;
        }else{}

      } while(x >= 0);
        Console.WriteLine("\nA soma dos números é: " + sequencia);
    }  

}

