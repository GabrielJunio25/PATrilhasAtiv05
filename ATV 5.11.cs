using System;

class Program
{
    static void Main(string[] args)
    {
      Console.Write("Digite um número inteiro: ");
      int x = int.Parse(Console.ReadLine());
        Console.Clear();
        int y = 0;

       while (y < x ){
           Console.WriteLine(y);
           y = y + 2;
           
       }
           
           
       
    
    }
}