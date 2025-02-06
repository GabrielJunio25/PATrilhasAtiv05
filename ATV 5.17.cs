using System;

class Program
{
    static void Main(string[] args)
    {
      Console.Write("Digite um número inteiro: ");
      int x = int.Parse(Console.ReadLine());
      int i = 0;

      do{
        if (i % 2 == 0){
          Console.WriteLine(i);
        }else{}
        i++;
      }while (i <= x);
    }  

}

