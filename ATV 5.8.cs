using System;

class Program
{
    static void Main(string[] args)
    {
      Console.WriteLine("Digite uma letra: ");
       string letra  = (Console.ReadLine());
    switch(letra.ToLower()){
    case "a":
        Console.WriteLine("A letra é uma vogal");
        break;
    case "e":
        Console.WriteLine("A letra é uma vogal");
        break;
    case "i":
        Console.WriteLine("A letra é uma vogal");
        break;
    case "o":
        Console.WriteLine("A letra é uma vogal ");
        break;
    case "u":
        Console.WriteLine("A letra é uma vogal");
        break;
    default:
        Console.WriteLine("A letra é uma consoante");
        break;
    }
    }
}