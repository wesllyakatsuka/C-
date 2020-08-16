using System;

namespace uri1020_IdadeEmDias
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, ano, mes, dia, resto;

            n = int.Parse(Console.ReadLine());

            ano = n / 365;
            resto = n % 365;

            mes = resto / 30;
            resto = resto % 30;

            dia = resto;

            Console.WriteLine(ano + " ano(s)");
            Console.WriteLine(mes + " mes(es)");
            Console.WriteLine(dia + " dia(s)");

           //Console.ReadKey();
        }
    }
}
