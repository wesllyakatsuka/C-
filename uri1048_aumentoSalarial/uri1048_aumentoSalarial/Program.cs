using System;
using System.Globalization;

namespace uri1048_aumentoSalarial
    {
    class Program
        {
        static void Main(string[] args)
            {
            double salarioAtual, novoSalario, reajusteGanho, percentual;

            salarioAtual = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if(salarioAtual >= 0.0 && salarioAtual <= 400.00)
                {
                novoSalario = salarioAtual + (salarioAtual * 15 / 100);
                reajusteGanho = novoSalario - salarioAtual;
                percentual = 15;
                Console.WriteLine("Novo salario: " + novoSalario.ToString("f2", CultureInfo.InvariantCulture));
                Console.WriteLine("Reajuste ganho: " + reajusteGanho.ToString("f2", CultureInfo.InvariantCulture));
                Console.WriteLine("Em percentual: " + percentual + " %");
                }
            else if (salarioAtual >= 400.01 && salarioAtual <= 800.00)
                {
                novoSalario = salarioAtual + (salarioAtual * 12 / 100);
                reajusteGanho = novoSalario - salarioAtual;
                percentual = 12;
                Console.WriteLine("Novo salario: " + novoSalario.ToString("f2", CultureInfo.InvariantCulture));
                Console.WriteLine("Reajuste ganho: " + reajusteGanho.ToString("f2", CultureInfo.InvariantCulture));
                Console.WriteLine("Em percentual: " + percentual + " %");
                }
            else if (salarioAtual >= 800.01 && salarioAtual <= 1200.00)
                {
                novoSalario = salarioAtual + (salarioAtual * 10 / 100);
                reajusteGanho = novoSalario - salarioAtual;
                percentual = 10;
                Console.WriteLine("Novo salario: " + novoSalario.ToString("f2", CultureInfo.InvariantCulture));
                Console.WriteLine("Reajuste ganho: " + reajusteGanho.ToString("f2", CultureInfo.InvariantCulture));
                Console.WriteLine("Em percentual: " + percentual + " %");
                }
            else if (salarioAtual >= 1200.01 && salarioAtual <= 2000.00)
                {
                novoSalario = salarioAtual + (salarioAtual * 7 / 100);
                reajusteGanho = novoSalario - salarioAtual;
                percentual = 7;
                Console.WriteLine("Novo salario: " + novoSalario.ToString("f2", CultureInfo.InvariantCulture));
                Console.WriteLine("Reajuste ganho: " + reajusteGanho.ToString("f2", CultureInfo.InvariantCulture));
                Console.WriteLine("Em percentual: " + percentual + " %");
                }
            else 
                {
                novoSalario = salarioAtual + (salarioAtual * 4 / 100);
                reajusteGanho = novoSalario - salarioAtual;
                percentual = 4;
                Console.WriteLine("Novo salario: " + novoSalario.ToString("f2", CultureInfo.InvariantCulture));
                Console.WriteLine("Reajuste ganho: " + reajusteGanho.ToString("f2", CultureInfo.InvariantCulture));
                Console.WriteLine("Em percentual: " + percentual + " %");
                }
            //Console.ReadKey();
            }
        
        }
    }
