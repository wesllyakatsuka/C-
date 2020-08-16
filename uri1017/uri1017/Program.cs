using System;
using System.Globalization;
namespace uri1017
{
    class Program
    {
        static void Main(string[] args)
        {
            int horas, velocidade, distancia;
            double litros;

            horas = int.Parse(Console.ReadLine());
            velocidade = int.Parse(Console.ReadLine());

            distancia = horas * velocidade;

            litros = (double) distancia / 12;

            Console.WriteLine(litros.ToString("f3", CultureInfo.InvariantCulture));

           // Console.ReadKey();

        }
    }
}
