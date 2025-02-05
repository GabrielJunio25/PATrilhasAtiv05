using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite sua data de nascimento: ");
        string dataNascimento = Console.ReadLine();
        DateTime data = DateTime.ParseExact(dataNascimento, "dd/MM/yyyy", null);
        DateTime dtAtual = DateTime.Now;
        TimeSpan idade = dtAtual - data;
        Console.WriteLine($"Sua idade é {idade.Days / 365} anos");
    }
}