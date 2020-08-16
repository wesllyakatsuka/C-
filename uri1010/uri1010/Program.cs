using System;
using System.Globalization;
namespace uri1010
{
    class Program
    {
        static void Main(string[] args)
        {
            int codigoPeca1, numeroDePecas1, codigoPeca2, numeroDePecas2;
            double valorUnitarioPeca1, valorUnitarioPeca2, total;
            string[] v;

            v = Console.ReadLine().Split(' ');
            codigoPeca1 = int.Parse(v[0]);
            numeroDePecas1 = int.Parse(v[1]);
            valorUnitarioPeca1 = double.Parse(v[2], CultureInfo.InvariantCulture);

            v = Console.ReadLine().Split(' ');
            codigoPeca2 = int.Parse(v[0]);
            numeroDePecas2 = int.Parse(v[1]);
            valorUnitarioPeca2 = double.Parse(v[2], CultureInfo.InvariantCulture);

            total = (numeroDePecas1 * valorUnitarioPeca1) + (numeroDePecas2 * valorUnitarioPeca2);

            Console.WriteLine("VALOR A PAGAR: R$ " + total.ToString("f2", CultureInfo.InvariantCulture));

            //Console.ReadKey();

        }
    }
}
