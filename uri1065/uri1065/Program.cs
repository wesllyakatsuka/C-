using System;

namespace uri1065
    {
    class Program
        {
        static void Main(string[] args)
            {
            int n1, n2, n3, n4, n5, contador = 0;

            n1 = int.Parse(Console.ReadLine());
            n2 = int.Parse(Console.ReadLine());
            n3 = int.Parse(Console.ReadLine());
            n4 = int.Parse(Console.ReadLine());
            n5 = int.Parse(Console.ReadLine());

            if(n1 % 2 == 0)
                {
                contador ++;
                }
            if (n2 % 2 == 0)
                {
               contador ++;
                }
            if (n3 % 2 == 0)
                {
                contador++;
                }
            if (n4 % 2 == 0)
                {
                contador++;
                }
            if (n5 % 2 == 0)
                {
                contador++;
                }
            Console.WriteLine(contador + " valores pares");
            //Console.ReadKey();
            }
        }
    }
