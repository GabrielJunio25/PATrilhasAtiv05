using System;
class Program
{
  static void Main()
  {
   DateTime dt1 = new DateTime(2025, 02, 04);
   DateTime dt2 = new DateTime(2008, 02, 25);
    TimeSpan diferenca = dt1 - dt2;
    
    Console.WriteLine("A diferença entre as datas é de: " + diferenca.Days + " dias");
  }

}