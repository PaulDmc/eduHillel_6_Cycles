//5.Генерація фібоначчівської послідовності: Напишіть програму, яка генерує перші N чисел Фібоначчі. Послідовність Фібоначчі починається з 0 і 1, а кожне наступне число є сумою двох попередніх чисел у послідовності.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace eduHillel_HW6_Demchenko_5 
{ 
    public class Program
    {
        static void Main()
        {
            string inputNumber;
            int n;

            Console.Write("Enter the number of Fibonacci: ");
            inputNumber = Console.ReadLine();
            if (int.TryParse(inputNumber, out n) && n >= 0)
            {
                Console.WriteLine("Received Fibonacci numbers:");
                GenerateFibonacci(n);
            }
            else
            {
                Console.WriteLine("Enter a positive integer.");
            }
        }

        static void GenerateFibonacci(int n)
        {
            int first = 0;
            int second = 1;
            int next;

            if (n == 0)
            {
                Console.WriteLine("No numbers to output.");
                return;
            }
            if (n >= 1)
            {
                Console.Write(first);
            }
            if (n >= 2)
            {
                Console.Write(", " + second);
            }
            for (int i = 3; i <= n; i++)
            {   
                next = first + second;
                Console.Write(", " + next);
                first = second;
                second = next;
            }
            Console.WriteLine();
        }
    }
}