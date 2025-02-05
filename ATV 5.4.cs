using System;
using System.Collections.Generic;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
       List<DateTime> feriados = new List<DateTime>();
        feriados.Add(DateTime.ParseExact("01/01/2025", "dd/MM/yyyy", CultureInfo.InvariantCulture));
        feriados.Add(DateTime.ParseExact("03/03/2025", "dd/MM/yyyy", CultureInfo.InvariantCulture));
        feriados.Add(DateTime.ParseExact("18/04/2025", "dd/MM/yyyy", CultureInfo.InvariantCulture));
        feriados.Add(DateTime.ParseExact("21/04/2025", "dd/MM/yyyy", CultureInfo.InvariantCulture));
        feriados.Add(DateTime.ParseExact("01/05/2025", "dd/MM/yyyy", CultureInfo.InvariantCulture));
        feriados.Add(DateTime.ParseExact("19/06/2025", "dd/MM/yyyy", CultureInfo.InvariantCulture));
        feriados.Add(DateTime.ParseExact("07/09/2025", "dd/MM/yyyy", CultureInfo.InvariantCulture));
        feriados.Add(DateTime.ParseExact("12/10/2025", "dd/MM/yyyy", CultureInfo.InvariantCulture));
        feriados.Add(DateTime.ParseExact("02/11/2025", "dd/MM/yyyy", CultureInfo.InvariantCulture));
        feriados.Add(DateTime.ParseExact("15/11/2025", "dd/MM/yyyy", CultureInfo.InvariantCulture));
        feriados.Add(DateTime.ParseExact("20/11/2025", "dd/MM/yyyy", CultureInfo.InvariantCulture));
        feriados.Add(DateTime.ParseExact("25/12/2025", "dd/MM/yyyy", CultureInfo.InvariantCulture));


        Console.Write("Digite a data desejada (dd/MM/yyyy): ");
        string data = Console.ReadLine();
        DateTime dataDesejada = DateTime.ParseExact(data, "dd/MM/yyyy", CultureInfo.InvariantCulture);
        if (feriados.Contains(dataDesejada)){
            Console.Write("Essa data é um feriado" );
        }
        else{
            Console.Write("Essa data não é um feriado nacional" );
        }
        
    }
}