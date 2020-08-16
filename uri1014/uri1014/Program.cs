using System;
using System.Globalization;

namespace uri1014
{
    class Program
    {
        static void Main(string[] args)
        {
            int X;
            double Y, CONSUMO;

            X = int.Parse(Console.ReadLine());
            Y = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            CONSUMO = X / Y;

            Console.WriteLine(CONSUMO.ToString("f3", CultureInfo.InvariantCulture) + " km/l");

            //Console.ReadKey();
        }
    }
}
