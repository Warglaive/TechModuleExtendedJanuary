﻿using System;
namespace _01.Time_Since_Birthday
{
    class Program
    {
        public static void Main()
        {
            byte years = byte.Parse(Console.ReadLine());
            int days = years * 365;
            int hours = days * 24;
            int minutes = hours * 60;
            Console.WriteLine($"{years} years, {days} days, {hours} hours, {minutes} minutes");

        }
    }
}
