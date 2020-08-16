using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uri1004
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, PROD;

            n1 = int.Parse(Console.ReadLine());
            n2 = int.Parse(Console.ReadLine());

            PROD = n1 * n2;

            Console.WriteLine("PROD = " + PROD);

            //Console.ReadKey();
        }
    }
}
