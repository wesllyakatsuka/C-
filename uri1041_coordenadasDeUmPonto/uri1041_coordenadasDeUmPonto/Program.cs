using System;
using System.Globalization;

namespace uri1041_coordenadasDeUmPonto
    {
    class Program
        {
        static void Main(string[] args)
            {
            double x, y;
            string[] vetor;

            vetor = Console.ReadLine().Split(' ');
            x = double.Parse(vetor[0], CultureInfo.InvariantCulture);
            y = double.Parse(vetor[1], CultureInfo.InvariantCulture);

            if (x == y && y == 0.0)
                {
                Console.WriteLine("Origem");
                }
            else if (x == 0.0 && (y > 0.0 || y < 0.0))
                {
                Console.WriteLine("Eixo Y");
                }
            else if (y == 0.0 && (x > 0.0 || x < 0.0))
                {
                Console.WriteLine("Eixo X");
                }
            else if (x > 0.0 && y > 0.0)
                {
                Console.WriteLine("Q1");
                }
            else if (x < 0.0 && y > 0.0)
                {
                Console.WriteLine("Q2");
                }
            else if (x < 0.0 && y < 0.0)
                {
                Console.WriteLine("Q3");
                }
            else
                {
                Console.WriteLine("Q4");
                }
            //Console.ReadKey();
            }
        }
    }
/*
Regras

1º quadrante = x > 0 e y > 0
2º quadrante = x < 0 e y > 0
3º quadrante = x < 0 e y < 0
4º quadrante = x > 0 e y < 0

Origem, se (x e y == 0)
Eixo Y, se x == 0 e (y > 0 ou y < 0);
Eixo X, se y == 0 e (x > 0 ou x < 0);

Leia mais: https://mundoeducacao.bol.uol.com.br/matematica/plano-cartesiano.htm
*/

