using System;

namespace uri1071_somaIntervaloImpares
    {
    class Program
        {
        static void Main(string[] args)
            {
            int x, y, menor, maior, soma;

            x = int.Parse(Console.ReadLine());
            y = int.Parse(Console.ReadLine());
            //A estrutura if...else garante que a ordem seja sempre subtrair um número maior pelo menor.
            if(x < y)
                {
                menor = x;
                maior = y;
                }
            else
                {
                menor = y;
                maior = x;
                }
            //inicializa a variável soma
            soma = 0;
            //percorrre todoo interevalo entre os números (x - y) ou (y - x)
            for(int i = menor + 1; i < maior; i++)
                {
                //se for impar, então soma
                if(i % 2 != 0)
                    {
                    soma = soma + i;
                   }                
                }
            Console.WriteLine(soma);
           // Console.ReadKey(); 
            }
        }
    }
