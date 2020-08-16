﻿using System;
using System.Globalization;
namespace uri1036_bhaskara
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, delta, x1, x2;
            string[] vetor;

            vetor = Console.ReadLine().Split(' ');
            a = double.Parse(vetor[0], CultureInfo.InvariantCulture);
            b = double.Parse(vetor[1], CultureInfo.InvariantCulture);
            c = double.Parse(vetor[2], CultureInfo.InvariantCulture);

            delta = Math.Pow(b, 2.0) - 4 * a * c;

            if (delta < 0.0 || a == 0)
            {
                Console.WriteLine("Impossivel calcular");
            }
            else
            {

                x1 = (-b + Math.Sqrt(delta)) / (2.0 * a);

                x2 = (-b - Math.Sqrt(delta)) / (2.0 * a);

                Console.WriteLine("R1 = " + x1.ToString("f5", CultureInfo.InvariantCulture));

                Console.WriteLine("R2 = " + x2.ToString("f5", CultureInfo.InvariantCulture));
            }
           // Console.ReadKey();
        }
    }
}
