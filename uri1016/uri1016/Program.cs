using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uri1016
{
    class Program
    {
        static void Main(string[] args)
        {
            int distanciaEmKm, tempoEmMinutos;

            distanciaEmKm = int.Parse(Console.ReadLine());

            tempoEmMinutos = distanciaEmKm * 2;

            Console.WriteLine(tempoEmMinutos + " minutos");

            //Console.ReadKey();


        }
    }
}
