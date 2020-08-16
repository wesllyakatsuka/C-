using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uri1044_multiplos
    {
    class Program
        {
        static void Main(string[] args)
            {
            int a, b;
            string[] vetor;

            vetor = Console.ReadLine().Split(' ');
            a = int.Parse(vetor[0]);
            b = int.Parse(vetor[1]);

            if(a % b == 0 || b % a == 0)
                {
                Console.WriteLine("Sao Multiplos");
                }
            else
                {
                Console.WriteLine("Nao sao Multiplos");
                }
            //Console.ReadKey();
            }
        }
    }
