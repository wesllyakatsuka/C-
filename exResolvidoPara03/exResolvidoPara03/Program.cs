using System;

namespace exResolvidoPara03
    {
    class Program
        {
        static void Main(string[] args)
            {
            int n, resultado;

            n = int.Parse(Console.ReadLine());           
            for(int i = 1; i <= 10; i++)
                {
                resultado = i * n;
                Console.WriteLine(i.ToString().PadLeft(2) + " x " + n + " = " + resultado.ToString().PadLeft(4));
                }
            Console.ReadKey();
            }
        }
    }
