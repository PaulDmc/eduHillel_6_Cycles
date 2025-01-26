//3.Генерація простих чисел: Напишіть програму, яка генерує прості числа від 1 до заданого користувачем числа. Просте число - це число, яке ділиться лише на 1 і на себе.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eduHillel_HW6_Demchenko_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNumber;
            int isDivision;
            int count;

            Console.Write("Enter the max number: ");
            if (int.TryParse(Console.ReadLine(), out int maxNumber) && maxNumber > 1)
            {
                Console.WriteLine($"Prime numbers from 1 to {maxNumber}:");

                for (firstNumber = 2; firstNumber <= maxNumber; firstNumber++)
                {
                    count = 0;

                    for (isDivision = 1; isDivision <= firstNumber; isDivision++)
                    {
                        if (firstNumber % isDivision == 0)
                        {
                            count++;
                        }
                    }

                    if (count == 2)
                    {
                        Console.WriteLine($"{firstNumber} ");
                    }
                }
            }
            else
            {
                Console.WriteLine("Enter an integer greater than 1.");
            }

            Console.WriteLine("Press any key to end the program.");
            Console.ReadKey();
        }
    }
}