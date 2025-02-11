﻿using System;

namespace DevIncubatorCore.HelloWorld
{
    internal class C : ITask
    {
        public void RunTask()
        {
            Console.WriteLine($"Min byte - {byte.MinValue}. Max byte - {byte.MaxValue}.");

            Console.WriteLine($"Min sbyte - {sbyte.MinValue}. Max sbyte - {sbyte.MaxValue}.");

            Console.WriteLine($"Min int - {int.MinValue}. Max int - {int.MaxValue}.");

            Console.WriteLine($"Min float - {float.MinValue}. Max float - {float.MaxValue}.");
        }
    }
}