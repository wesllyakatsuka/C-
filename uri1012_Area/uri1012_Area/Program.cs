using System;
using System.Globalization;

namespace uri1012_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, triangulo, circulo, trapezio, quadrado, retangulo;
            string[] v;

            v = Console.ReadLine().Split(' ');
            a = double.Parse(v[0], CultureInfo.InvariantCulture);
            b = double.Parse(v[1], CultureInfo.InvariantCulture);
            c = double.Parse(v[2], CultureInfo.InvariantCulture);

            triangulo = (a * c) / 2.0;
            circulo = Math.Pow(c, 2.0) * 3.14159;
            trapezio = ((a + b) / 2.0) * c;
            quadrado = b * b;
            retangulo = a * b;

            Console.WriteLine("TRIANGULO: " + triangulo.ToString("f3", CultureInfo.InvariantCulture));
            Console.WriteLine("CIRCULO: " + circulo.ToString("f3", CultureInfo.InvariantCulture));
            Console.WriteLine("TRAPEZIO: " + trapezio.ToString("f3", CultureInfo.InvariantCulture));
            Console.WriteLine("QUADRADO: " + quadrado.ToString("f3", CultureInfo.InvariantCulture));
            Console.WriteLine("RETANGULO: " + retangulo.ToString("f3", CultureInfo.InvariantCulture));


            //Console.ReadKey();
        }
    }
}
