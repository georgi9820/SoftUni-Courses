﻿using System;

namespace _07.ProjectsCreation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int number = int.Parse(Console.ReadLine());
            int hoursPerProject = number * 3;
            Console.WriteLine($"The architect {name} will need {hoursPerProject} hours to complete {number} project/s.");
        }
    }
}
