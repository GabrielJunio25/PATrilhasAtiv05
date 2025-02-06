using System;

class Program
{
    static void Main(string[] args)
    {
      Console.Write("Digite uma sequencia de numeros ");
      int i = 0;
      int sequencia = 0;
      
      do{
        Console.Write("\nNumero: ");
        int x = int.Parse(Console.ReadLine());
        sequencia = sequencia + x;
        
        i++;
      }while (i <= 5);
      Console.WriteLine("A soma dos numeros é: " + sequencia);
    }  

}

