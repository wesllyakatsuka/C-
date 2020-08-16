using System;
using System.Globalization;

namespace uri1064_positvosEMedia
    {
    class Program
        {
        static void Main(string[] args)
            {
            int loopCount = 1;
            int count = 0;
            double sum = 0.00, number;
            while (loopCount < 7)
                {
                number = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                if (number >= 0)
                    {
                    count++;
                    sum = sum + number;
                    }
                loopCount++;
                }
            Console.WriteLine(count + " valores positivos");
            Console.WriteLine((sum / count).ToString("f1", CultureInfo.InvariantCulture));
            //Console.ReadKey();
            }
        }
    }
