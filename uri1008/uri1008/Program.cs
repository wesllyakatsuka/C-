using System;
using System.Globalization;

namespace uri1008
{
    class Program
    {
        static void Main(string[] args)
        {
            int numeroDoFuncionario, horasTrabalhadas;
            double salarioHora, salarioMensal;
      
            numeroDoFuncionario = int.Parse(Console.ReadLine());
            horasTrabalhadas = int.Parse(Console.ReadLine());
            salarioHora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            salarioMensal = horasTrabalhadas * salarioHora;

            Console.WriteLine("NUMBER = " + numeroDoFuncionario);
            Console.WriteLine("SALARY = U$ " + salarioMensal.ToString("F2", CultureInfo.InvariantCulture));

            Console.ReadKey();


        }
    }
}
