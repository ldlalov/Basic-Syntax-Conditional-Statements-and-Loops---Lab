﻿using System;

namespace _11._Multiplication_Table_2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int multiplayer = int.Parse(Console.ReadLine());
            if (multiplayer > 10)
            {
                Console.WriteLine($"{n} X {multiplayer} = {n * multiplayer}");
            }
            else
            {
                for (int i = multiplayer; i <= 10; i++)
                {
                    Console.WriteLine($"{n} X {i} = {n * i}");
                }
            }
        }
    }
}
