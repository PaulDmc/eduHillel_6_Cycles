//7. Генерація таблиці множення для конкретного числа: Напишіть програму, яка запитує в користувача число, а потім генерує таблицю множення для цього числа від 1 до 10.

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




namespace eduHillel_HW6_Demchenko_7
{
    public class Program
    {
        static void Main()
        {
            const int startNumber = 1;
            const int end = 10;

            Console.Write("Enter a number for the multiplication table: ");
            var numbString = Console.ReadLine();

            if (int.TryParse(numbString, out int numb))
            {
                for (int i = startNumber; i <= end; i++)
                {
                    Console.WriteLine($"{numb}*{i} = {numb * i}");
                }
            }
            else
            {
                Console.WriteLine("Invalid value. Enter a number, please.");
            }

            Console.WriteLine("Press any key to end the program.");
            Console.ReadKey();
        }
    }
}