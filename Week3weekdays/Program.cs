﻿using System;

namespace Week3weekdays
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What day is it today?");
            string day = Console.ReadLine().ToLower();

            if (day == "monday" || day == "tuesday" || day == "wednesday" || day == "thursday" || day == "friday")
            {
                Console.WriteLine($"{day} is a workday");
            }
            else if (day == "saturday" || day == "sunday")
            {
                Console.WriteLine("Its weekend!");
            }
            else
            {
                Console.WriteLine("This is not day of the week");
            }
                
        }
    }
}
