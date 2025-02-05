using System;

class Program
{
    static void Main(string[] args)
    {
      Console.WriteLine("Digite uma cor(vermelho, azul ou verde)");
       string cor  = (Console.ReadLine());
    switch(cor){
    case "vermelho":
        Console.WriteLine("Você escolheu a cor vermelho! ");
        break;
    case "azul":
        Console.WriteLine("Você escolheu a cor azul! ");
        break;
    case "verde":
        Console.WriteLine("Você escolheu a cor verde!");
        break;
    }
    }
}