using System;

class Program
{
    static void Main(string[] args)
    {
        int senha = 123456;
        int i = 0;
      
        Console.Write("Digite a senha: ");
        int senhaDigitada = int.Parse(Console.ReadLine());

        while (senhaDigitada != senha && i < 3){
          Console.Write("senha incorreta, digite novamente: ");
          senhaDigitada = int.Parse(Console.ReadLine());
          i++;
          
          
        }
        if (senhaDigitada == senha){
          Console.WriteLine("senha correta");
        }else{
          Console.WriteLine("Acesso bloqueado!");
        }
       
       
    }  
    
}