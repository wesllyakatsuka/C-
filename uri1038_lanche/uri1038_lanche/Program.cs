using System;
using System.Globalization;

namespace uri1038_lanche
    {
    class Program
        {
        static void Main(string[] args)
            {
            int cod, quantidade;
            double total;
            string[] vetor;

            vetor = Console.ReadLine().Split(' ');
            cod = int.Parse(vetor[0]);
            quantidade = int.Parse(vetor[1]);

            if(cod == 1)
                {
                total = quantidade * 4.00;
                }
            else if(cod == 2)
                {
                total = quantidade * 4.50;
                }
            else if(cod == 3)
                {
                total = quantidade * 5.00;
                }
            else if(cod == 4)
                {
                total = quantidade * 2.00;
                }
            else
                {
                total = quantidade * 1.50;
                }
            Console.WriteLine("Total: R$ " + total.ToString("f2",CultureInfo.InvariantCulture));
            //Console.ReadKey();
            }
        }
    }
