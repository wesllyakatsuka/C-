using System;
using System.Globalization;
namespace ex3_terreno
{
    class Program
    {
        static void Main(string[] args)
        {
            double largura, comprimento, area, perimetro, diagonal;

            Console.WriteLine("Digite a largura do terreno: ");
            largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Digite o comprimento do terreno: ");
            comprimento = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            area = largura * comprimento;
          //perimetro = (2 * largura) + (2 * comprimento);
            perimetro = 2 * (largura + comprimento);
          //diagonal = Math.Sqrt((largura * largura) + (comprimento * comprimento));
            diagonal = Math.Sqrt(Math.Pow(largura, 2.0) + (Math.Pow(comprimento, 2.0)));
            

            Console.WriteLine("AREA " + area.ToString("f4", CultureInfo.InvariantCulture));
            Console.WriteLine("PERIMETRO " + perimetro.ToString("f4", CultureInfo.InvariantCulture));
            Console.WriteLine("DIAGONAL " + diagonal.ToString("f4", CultureInfo.InvariantCulture));

            Console.ReadKey();
        }
    }
}
