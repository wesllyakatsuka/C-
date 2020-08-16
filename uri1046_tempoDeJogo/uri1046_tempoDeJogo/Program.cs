using System;


namespace uri1046_tempoDeJogo
    {
    class Program
        {
        static void Main(string[] args)
            {
            int horaInicial, horaFinal, duracao;
            string[] vetor;
            
            vetor = Console.ReadLine().Split(' ');
            horaInicial = int.Parse(vetor[0]);
            horaFinal = int.Parse(vetor[1]);
 
            if (horaInicial < horaFinal)
                {
                duracao = horaFinal - horaInicial;
                }
            else
                {
                duracao = (24 - horaInicial) + horaFinal;
                }
            Console.WriteLine("O JOGO DUROU " + duracao + " HORA(S)");
           // Console.ReadKey();
            }      
        }
    }
