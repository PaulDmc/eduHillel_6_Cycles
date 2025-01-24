//1. Калькулятор середньої зарплати працівників за місяць

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




namespace Cycles
{
    internal class Program
    {
        static void Main()
        {

            int numEmployees = 0;
            double salary = 0;
            double averageSalary = 0;
            double[] salaries;

            Console.Write("Введіть кількість працівників: ");
            if (!int.TryParse(Console.ReadLine(), out numEmployees) || numEmployees <= 0)
            {
                Console.WriteLine("Кількість працівників має бути цілим числом більше 0.");
                return;
            }

            salaries = new double[numEmployees];

            for (int i = 0; i < numEmployees; i++)
            {
                Console.Write($"Введіть зарплату працівника {i + 1}: ");
                if (!double.TryParse(Console.ReadLine(), out salary) || salary < 0)
                {
                    Console.WriteLine("Зарплата має бути числом і не може бути від'ємною. Спробуйте ще раз.");
                    i--;
                    continue;
                }
                salaries[i] = salary;
            }

            if (salaries.Length > 0)
            {
                averageSalary = salaries.Sum() / salaries.Length;
            }

            Console.WriteLine($"Середній заробіток: {averageSalary}");
            Console.ReadLine();
        }


    }
}
