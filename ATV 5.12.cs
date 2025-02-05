using System;

class Program
{
    static void Main(string[] args)
    {
      Console.Write("Digite um número inteiro: ");
      int x = int.Parse(Console.ReadLine());
        Console.Clear();
        int y = 0;
        int z = 1;

       while (y < x && z <= 10 ){
           Console.WriteLine("{0}x{1} = {2}", x, z, x*z);
           y = y + 1;
           z = z + 1;
           
       }
           
           
       
    
    }
}