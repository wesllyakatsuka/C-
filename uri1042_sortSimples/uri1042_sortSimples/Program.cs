using System;
using System.Globalization;

namespace uri1042_sortSimples
    {
    class Program
        {
        static void Main(string[] args)
            {
            int a, b, c, maiorAB, maiorTodos, menorAB, menorBC, menorTodos;

            string[] vetor = Console.ReadLine().Split(' ');

            a = int.Parse(vetor[0]);
            b = int.Parse(vetor[1]);
            c = int.Parse(vetor[2]);

            maiorAB = ((a + b) + (Math.Abs(a - b))) / 2;
            maiorTodos = ((maiorAB + c) + (Math.Abs(maiorAB - c))) / 2;

            if (a < b)
                {
                menorAB = a;
                }
            else
                {
                menorAB = b;
                }

            if (menorAB < c)
                {
                menorTodos = menorAB;
                }
            else
                {
                menorTodos = c;
                }

            Console.WriteLine(menorTodos);

            Console.WriteLine(a + b + c - menorTodos - maiorTodos);

            Console.WriteLine(maiorTodos);

            Console.WriteLine();

            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);

            //Console.ReadLine();
            }
        }
    }


