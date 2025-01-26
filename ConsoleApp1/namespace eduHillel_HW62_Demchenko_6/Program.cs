//6. Калькулятор оплати праці за годину: Напишіть програму, яка запитує в користувача кількість годин, працюваних за день, та розмір годинної ставки. Після введення значень програма має обчислити та вивести оплату за день.

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




namespace eduHillel_HW6_Demchenko_6
{
    public class Program
    {
        static void Main()
        {
            string hoursInput;
            string hourRate;
            double dailyPay;


            Console.Write("Enter the number of hours worked per day: ");
            hoursInput = Console.ReadLine();

            Console.Write("Enter your hourly rate: ");
            hourRate = Console.ReadLine();

            if (double.TryParse(hoursInput, out double hours) && hours >= 0 &&
                double.TryParse(hourRate, out double rate) && rate >= 0)
            {
                dailyPay = hours * rate;
                Console.WriteLine($"Your payment per day: {dailyPay:F}");
            }
            else
            {
                Console.WriteLine("Enter valid numeric values.");
            }
        }
    }

}