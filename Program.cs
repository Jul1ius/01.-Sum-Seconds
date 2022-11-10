﻿using System;

namespace _01.__Sum_Seconds
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstSeconds = int.Parse(Console.ReadLine());
            int secondSeconds = int.Parse(Console.ReadLine());
            int thirdSeconds = int.Parse(Console.ReadLine());
            
            int secondsSum = (firstSeconds + secondSeconds + thirdSeconds);
            double minutes = secondsSum / 60;
            int leftSeconds = secondsSum % 60;

            if (leftSeconds < 10 )
            {
                Console.WriteLine($"{minutes}:0{leftSeconds}");
            }
            else
            {
                Console.WriteLine($"{minutes}:{leftSeconds}");
            }
             
        }
    }
}
