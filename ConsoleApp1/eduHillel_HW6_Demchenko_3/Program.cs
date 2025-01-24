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

            Console.Write("Введіть максимальне число: ");
            if (int.TryParse(Console.ReadLine(), out int maxNumber) && maxNumber > 1)
            {
                Console.WriteLine($"Прості числа від 1 до {maxNumber}:");

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
                Console.WriteLine("Будь ласка, введіть ціле число більше за 1.");
            }

            Console.WriteLine("Натисніть будь-яку клавішу для завершення програми");
            Console.ReadKey();
        }
    }
}