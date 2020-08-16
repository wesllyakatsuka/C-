using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uri113_oMaior
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, n3, maior = 0;
            string[] v;

            v = Console.ReadLine().Split(' ');
            n1 = int.Parse(v[0]);
            n2 = int.Parse(v[1]);
            n3 = int.Parse(v[2]);

            if (n1 >= maior)
            {
                maior = n1;
            }

            if (n2 >= maior)
            {
                maior = n2;
            }

            if (n3 >= maior)
            {
                maior = n3;
            }

            Console.WriteLine(maior + " eh o maior");

            Console.ReadLine();
        }      

    }
}
