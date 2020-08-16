using System;

namespace uri1047_tempoDeJogoComMinutos
    {
    class Program
        {
        static void Main(string[] args)
            {

            int h1, m1, h2, m2, inicio, fim, duracao, dh, dm;

            String[] vet = Console.ReadLine().Split(' ');
            h1 = int.Parse(vet[0]);
            m1 = int.Parse(vet[1]);
            h2 = int.Parse(vet[2]);
            m2 = int.Parse(vet[3]);

            inicio = h1 * 60 + m1;
            fim = h2 * 60 + m2;

            if (inicio == fim)
                { // 24 horas exatas
                duracao = 24 * 60;
                }
            else if (fim > inicio)
                { // diferenca simples
                duracao = fim - inicio;
                }
            else
                { // virou o dia
                duracao = 24 * 60 - inicio + fim; // tempo restante para o primeiro dia acabar, mais o tempo do segundo dia
                }

            dh = duracao / 60;
            dm = duracao % 60;

            Console.WriteLine("O JOGO DUROU " + dh + " HORA(S) E " + dm + " MINUTO(S)");

            //Console.ReadLine();
            }
        }
    }

