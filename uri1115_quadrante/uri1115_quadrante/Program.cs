using System;

namespace uri1115_quadrante
    {
    class Program
        {
        static void Main(string[] args)
            {
            int x, y;
            string[] vetor;

            vetor = Console.ReadLine().Split(' ');
            x = int.Parse(vetor[0]);
            y = int.Parse(vetor[1]);

            while (x != 0.0 && y != 0.0)
                {
                    if (x > 0.0 && y > 0.0)
                    {
                    Console.WriteLine("primeiro");
                    }
                else if (x < 0.0 && y > 0.0)
                    {
                    Console.WriteLine("segundo");
                    }
                else if (x < 0.0 && y < 0.0)
                    {
                    Console.WriteLine("terceiro");
                    }
                else
                    {
                    Console.WriteLine("quarto");
                    }
                vetor = Console.ReadLine().Split(' ');
                x = int.Parse(vetor[0]);
                y = int.Parse(vetor[1]);                      
                }
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




