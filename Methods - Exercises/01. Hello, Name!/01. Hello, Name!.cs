﻿using System;
namespace _01.Hello__Name_
{
    class Program
    {
        public static void Main()
        {
            string name = Console.ReadLine();
            PrintName(name);
        }
        private static void PrintName(string name)
        {
            Console.WriteLine($"Hello, {name}!");
            return;
        }
    }
}
