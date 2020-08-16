using System;

namespace uri1060_numerosPositivos
    {
    class Program
        {
        static void Main(string[] args)
            {
            int loopCount = 1;
            int count = 0;
            while (loopCount < 7)
                {
                double number = double.Parse(Console.ReadLine());
                if (number >= 0)
                    {
                    count++;
                    }
                loopCount++;
                }
            Console.WriteLine(count + " valores positivos");
           // Console.ReadLine();
            }
        }
    }
