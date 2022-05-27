﻿using System;
using System.Collections.Generic;

namespace Exercise_Multi_Dictionaries
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var names = new HashSet<string>();

            for (int i = 0; i < n; i++)
            {
                string name = Console.ReadLine();

                names.Add(name);
            }

            Console.WriteLine(string.Join(Environment.NewLine, names));
        }
    }
}
