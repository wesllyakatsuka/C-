using System;

namespace uri1066
    {
    class Program
        {
        static void Main(string[] args)
            {
            int contador = 1;
            int par = 0;
            int impar = 0;
            int positivo = 0;
            int negativo = 0;
            double number;

            while (contador < 6)
                {
                number = double.Parse(Console.ReadLine());
                if (number % 2 == 0)
                    {
                    par++;
                    }
                else
                    {
                    impar++;
                    }
                if (number > 0)
                    {
                    positivo++;
                    }
                else if (number < 0)
                    {
                    negativo++;
                    }
                contador++;
                }
            Console.WriteLine(par + " valor(es) par(es)");
            Console.WriteLine(impar+ " valor(es) impar(es)");
            Console.WriteLine(positivo + " valor(es) positivo(s)");
            Console.WriteLine(negativo + " valor(es) negativo(s)");
            //Console.ReadKey();
            }
        }
    }
