using System;
using System.Globalization;

namespace exResolvidoWhile02
    {
    class Program
        {
        static void Main(string[] args)
            {
            double idade, soma, media;
            int contador;

            idade = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            contador = 0;
            soma = 0.0;
            media = 0.0;
            while(idade >= 0.0)
                {
                soma = soma + idade;
                contador = contador + 1;
                media = soma / contador;               
                idade = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);              
                }
            //Se o primeiro valor digitado for negativo, ele cai aqui depois de passar pelo while acima
            if(contador == 0)
                {
                Console.WriteLine("Impossivel calcular");
                }
            else
                {
                Console.WriteLine(media.ToString("f2", CultureInfo.InvariantCulture));              
                }
        
            Console.ReadKey();
            }
        }
    }
