using System;

class Program
{
    static void Main(string[] args)
    {
        int sequencia = 0;
        int i = 0;
      while(i < 5){
        Console.Write("Digite um número: ");
        int x = int.Parse(Console.ReadLine());
        sequencia = sequencia + x;
        i++;
      } 
        Console.WriteLine("A soma dos números é: " + sequencia);
    }  
    
}