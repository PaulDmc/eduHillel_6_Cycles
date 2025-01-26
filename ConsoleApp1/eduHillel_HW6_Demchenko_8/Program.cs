// 8. Перевірка на простоту: Напишіть програму, яка перевіряє, чи є задане користувачем число простим. Число вважається простим, якщо воно ділиться лише на 1 і на себе.

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




namespace eduHillel_HW6_Demchenko_8
{
    public class Program
    {

        public static void Main()
        {
            {
                string inputNumber;
                Console.Write("Number to check for primality: ");
                inputNumber = Console.ReadLine();

                if (int.TryParse(inputNumber, out int number))
                {
                    if (number > 1)
                    {
                        bool isPrime = true;

                        for (int i = 2; i < number; i++)
                        {
                            if (number % i == 0)
                            {
                                isPrime = false;
                                break;
                            }
                        }

                        if (isPrime)
                        {
                            Console.WriteLine($"Number {number} is prime.");
                        }
                        else
                        {
                            Console.WriteLine($"Число {number} is't prime.");
                        }
                    }
                    else
                    {
                        Console.WriteLine($"Число {number} is't prime.");
                    }
                }
                else
                {
                    Console.WriteLine("Enter a valid number.");
                }

                Console.WriteLine("Press any key to end the program.");
                Console.ReadKey();
            }
        }
    }
}
