﻿using System;
using System.Globalization;

namespace uri1006
{
    class Program
    {
        static void Main(string[] args)
        {
            double A, B, C, MEDIA;

            A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            MEDIA = ((A * 2) + (B * 3) + (C * 5)) / 10;

            Console.WriteLine("MEDIA = " + MEDIA.ToString("f1",CultureInfo.InvariantCulture));

           Console.ReadKey();
        }
    }
}
