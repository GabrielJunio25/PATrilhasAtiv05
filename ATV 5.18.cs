using System;

class Program
{
    static void Main(string[] args)
    {
      Console.Write("Digite um número : ");
      int x = int.Parse(Console.ReadLine());
      int i = 0;
      int multi= 0;
      
      do{
        Console.Write("{0} x {1} = {2} \n", x, i, x * i);
        i++;
      }while (i <= x);
    }  

}

