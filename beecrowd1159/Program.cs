﻿using System;
using System.Globalization;

namespace uri1159
{
    class Program
    {
        static void Main(string[] args)
        {

            int x = int.Parse(Console.ReadLine());

            while (x != 0)
            {
                if (x % 2 != 0)
                {
                    x += 1;
                }

                int soma = 5 * x + 20;

                Console.WriteLine(soma);

                x = int.Parse(Console.ReadLine());

            }

        }
    }
}