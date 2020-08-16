using System;
using System.Globalization;

namespace uri1043_triangulo
    {
    class Program
        {
        static void Main(string[] args)
            {
            double a, b, c, area, perimetro;
            string[] vetor;

            vetor = Console.ReadLine().Split(' ');
            a = double.Parse(vetor[0], CultureInfo.InvariantCulture);
            b = double.Parse(vetor[1], CultureInfo.InvariantCulture);
            c = double.Parse(vetor[2], CultureInfo.InvariantCulture);

            if(a > (b + c) || b > (a + c) || c > (a + b)){
                perimetro = a + b + c;
                Console.WriteLine("Perimetro = " + perimetro.ToString("f1", CultureInfo.InvariantCulture));
                }

            if (Math.Abs(b - c) < a && a < (b + c)
                || Math.Abs(a - c) < b && b < (a + c)
                || Math.Abs(a - b) < c && c < (a + b))
                {
                perimetro = a + b + c;
                Console.WriteLine("Perimetro = " + perimetro.ToString("F1", CultureInfo.InvariantCulture));
                }
            else
                {
                area = ((a + b) * c) / 2;
                Console.WriteLine("Area = " + area.ToString("F1", CultureInfo.InvariantCulture));
                }
            //Console.ReadLine();

            }
        }
    }
