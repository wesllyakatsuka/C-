using System;
using System.Globalization;

namespace teoria_facaEnquanto
    {
    class Program
        {
        static void Main(string[] args)
            {
            string resposta;
            double c, f;

            do
                {
                Console.Write("Digite a temperatura em Celsius: ");
                c = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                f = ((9.0 * c) / 5.0) + 32.0;
                Console.WriteLine("Equivalente em Fahrenheit: " + f.ToString("f1", CultureInfo.InvariantCulture));
                Console.Write("Deseja repetir (s/n)? ");
                resposta = Console.ReadLine();
                }
            while (resposta == "s" || resposta == "S");
            Console.ReadKey();
            }
        }
    }


