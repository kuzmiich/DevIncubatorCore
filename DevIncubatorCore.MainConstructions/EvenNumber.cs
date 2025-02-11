﻿using System;

namespace DevIncubatorCore.MainConstructions
{
    internal class EvenNumber : ITask
    {
        public void RunTask()
        {
            Console.WriteLine("Input start range number: ");
            var n = Extractor.GetInt32(Console.ReadLine());

            Console.WriteLine("Input end range number: ");
            var m = Extractor.GetInt32(Console.ReadLine());

            if (n > m)
            {
                (n, m) = (m, n); // swap
            }

            // if n not even
            if (n % 2 != 0)
            {
                n++;
            }

            // if n not even
            if (n % 2 != 0)
            {
                n++;
            }

            for (var i = n; i <= m; i += 2)
            {
                Console.Write($"{i} ");
            }

            Console.WriteLine();
        }
    }
}