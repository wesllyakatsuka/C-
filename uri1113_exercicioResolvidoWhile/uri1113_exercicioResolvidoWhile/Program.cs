﻿using System;

namespace uri1113_exercicioResolvidoWhile
    {
    class Program
        {
        static void Main(string[] args)
            {
            int x, y;
            string[] vetor;

            vetor = Console.ReadLine().Split(' ');
            x = int.Parse(vetor[0]);
            y = int.Parse(vetor[1]);

            while(x != y)
                {
                if(x < y)
                    {
                    Console.WriteLine("Crescente");
                    }
                else 
                    {
                    Console.WriteLine("Decrescente");
                    }
                vetor = Console.ReadLine().Split(' ');
                x = int.Parse(vetor[0]);
                y = int.Parse(vetor[1]);
                }
            }
        }
    }
