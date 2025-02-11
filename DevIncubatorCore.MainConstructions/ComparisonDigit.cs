﻿using System;

namespace DevIncubatorCore.MainConstructions
{
    internal class ComparisonDigit : ITask
    {
        public void RunTask()
        {
            Console.WriteLine("Input first natural number a: ");
            var a = Extractor.GetInt32(Console.ReadLine());

            Console.WriteLine("Input second natural number b: ");
            var b = Extractor.GetInt32(Console.ReadLine());

            while (a > 0)
            {
                var remA = a % 10;
                var temp = b;
                while (temp > 0)
                {
                    var remB = temp % 10;
                    if (remA == remB)
                    {
                        Console.Write($"{remA} ");
                    }

                    temp /= 10;
                }

                a /= 10;
            }

            Console.WriteLine();
        }
    }
}