using System;
using System.Globalization;
namespace uri1037_intervalo
    {
    class Program
        {
        static void Main(string[] args)
            {
            double a;
            string[] vetor;

            vetor = Console.ReadLine().Split(' ');
            a = double.Parse(vetor[0], CultureInfo.InvariantCulture);

            if (a >= 0.0 && a <= 25.0000)
                {
                Console.WriteLine("Intervalo [0,25]");
                }
            else if (a >= 25.00001 && a <= 50.0000000)
                {
                //temos que abrir com parenteses e fechar com chaves (25,50]
                Console.WriteLine("Intervalo (25,50]");
                }
            else if (a >= 50.0000001 && a <= 75.0000000)
                {
                Console.WriteLine("Intervalo [50,75]");
                }
            else if (a >= 75.0000001 && a <= 100.0000000)
                {
                //temos que abrir com parenteses e fechar com chaves (75,100]
                Console.WriteLine("Intervalo (75,100]");
                }
            else
                {
                Console.WriteLine("Fora de intervalo");
                }
            // Console.ReadKey();

            }
        }
    }
