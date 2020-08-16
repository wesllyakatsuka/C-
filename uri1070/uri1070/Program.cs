using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uri1070
    {
    class Program
        {
        static void Main(string[] args)
            {
            int number = Convert.ToInt32(Console.ReadLine());
            int range = number + 12;
            for (int i = number; i <= range; i++)
                {
                if (i == number)
                    {
                    if (i % 2 != 0)
                        {
                        range--;
                        }
                    }
                if (i % 2 != 0)
                    {
                    Console.WriteLine(i);
                    }
                }
            //Console.ReadKey();
            }
        }
    }