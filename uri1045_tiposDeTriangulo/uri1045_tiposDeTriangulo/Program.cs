using System;
using System.Globalization;

namespace uri1045_tiposDeTriangulo
    {
    class Program
        {
        static void Main(string[] args)
            {
            double a, b, c, T, S, P;
            string[] vetor;

            vetor = Console.ReadLine().Split(' ');
            a = double.Parse(vetor[0], CultureInfo.InvariantCulture);
            b = double.Parse(vetor[1], CultureInfo.InvariantCulture);
            c = double.Parse(vetor[2], CultureInfo.InvariantCulture);
        
            //verificação de ordem decrescente
            if (a >= b && b >= c){ T = c; S = b; P = a; }
            else if (a <= b && b <= c) { T = a; S = b; P = c; }
            else if (a <= b && b >= c) { T = a; S = c; P = b; }
            else if (a >= b && b <= c) { T = b; S = c; P = a; }
            else if (a <= b && b >= c) { T = c; S = a; P = b; }
            else { T = b; S = a; P = c; }
            a = P;
            b = S;
            c = T;
            
            if (a >= (b + c))
                {
                Console.WriteLine("NAO FORMA TRIANGULO");
                }
            else
                {
                if (Math.Pow(a, 2.0) == (Math.Pow(b, 2.0) + Math.Pow(c, 2.0)))
                    {
                    Console.WriteLine("TRIANGULO RETANGULO");
                    }
                if (Math.Pow(a, 2.0) > (Math.Pow(b, 2.0) + Math.Pow(c, 2.0)))
                    {
                    Console.WriteLine("TRIANGULO OBTUSANGULO");
                    }
                else if (Math.Pow(a, 2.0) < (Math.Pow(b, 2.0) + Math.Pow(c, 2.0)))
                    {
                    Console.WriteLine("TRIANGULO ACUTANGULO");
                    }

                if (a == b && a == c && b == c)
                    {
                    Console.WriteLine("TRIANGULO EQUILATERO");
                    }
                else if (a == b || a == c || b == c)
                    {
                    Console.WriteLine("TRIANGULO ISOSCELES");
                    }
                }
            //Console.ReadKey();
            }
        }
    }

