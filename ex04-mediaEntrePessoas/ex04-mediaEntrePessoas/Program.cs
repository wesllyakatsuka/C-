using System;
using System.Globalization;

namespace ex04_mediaEntrePessoas
{
    class Program
    {
        static void Main(string[] args)
        {           
            string nome1, nome2;
            int idade1, idade2;
            double media;
            string[] v;

            v = Console.ReadLine().Split(' ');
            nome1 = v[0];
            idade1 = int.Parse(v[1]);

            v = Console.ReadLine().Split(' ');
            nome2 = v[0];
            idade2 = int.Parse(v[1]);

            media = (double) (idade1 + idade2) / 2.0;

            Console.WriteLine("A idade média de " + nome1 +
                " e " + nome2 + " é de " + media.ToString("f1", CultureInfo.InvariantCulture) + " anos");

            Console.ReadKey();

        }
    }
}
