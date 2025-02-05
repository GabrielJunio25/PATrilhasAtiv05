using System;

class Program
{
    static void Main(string[] args)
    {
      Console.WriteLine("Digite um número inteiro: ");
      int num = int.Parse(Console.ReadLine());
    switch(Math.Sign(num)){
    case 1:
        Console.WriteLine("O número é positivo: ");
        break;
    case 0:
        Console.WriteLine("O número é zero: ");
        break;
    case -1:
        Console.WriteLine("O número é negativo: ");
        break;
    }
    }
}