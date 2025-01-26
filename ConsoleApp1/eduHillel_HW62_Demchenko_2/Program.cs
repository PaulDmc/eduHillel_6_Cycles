﻿//2. Побудова графіку зірочками: Напишіть програму, яка будує графік за допомогою зірочок. Користувач повинен ввести кількість рядків графіка. Кожен рядок графіка має містити відповідну кількість зірочок.

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




namespace eduHillel_HW6_Demchenko_2
{
    internal class Program
    {
        static void Main()
        {
            int rows;

            Console.Write("Enter the number of lines to graph:");
            while (!int.TryParse(Console.ReadLine(), out rows) || rows <= 0)
            {
                Console.WriteLine("Enter a positive integer.");
            }
            for (int i = 1; i <= rows; i++)
            {
                Console.WriteLine(new string('*', i));
            }
            Console.WriteLine("Press any key to end the program.");
            Console.ReadKey();

        }
    }
}
