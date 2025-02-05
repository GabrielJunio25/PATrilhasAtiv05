using System;

class Program
{
    static void Main(string[] args)
    {
      Console.WriteLine("Digite um tamanho de camisa (P/M/G): ");
    string tamanho = (Console.ReadLine());
    switch(tamanho.ToLower()){
    case "p":
        Console.WriteLine("R$ 49,90");
        break;
    case "m":
        Console.WriteLine("R$ 59,90");
        break;
    case "g":
        Console.WriteLine("R$ 69,90");
        break;
    default:
        Console.WriteLine("Tamanho inválido");
        break;
    }
    }
}