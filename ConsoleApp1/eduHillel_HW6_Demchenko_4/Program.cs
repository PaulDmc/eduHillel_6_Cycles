//4. Перевірка паролю: Напишіть програму, яка перевіряє пароль користувача. Пароль вважається прийнятним, якщо він містить принаймні 8 символів, з яких принаймні один символ - це цифра, а також принаймні один символ - це спеціальний символ (наприклад, !, @, # тощо).
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




namespace eduHillel_HW62_Demchenko_2
{
    public class Program
    {

        public static void Main()
        {
            string specialChars = "!@#$%^&*()_+[]{}|;:,.<>?`~";
            bool hasDigit = false;
            bool hasSpecialChar = false;

            Console.WriteLine("Введіть пароль:");
            var password = Console.ReadLine();

            bool isValidPassword(string password)
            {
                if (password.Length < 8)
                {
                    Console.WriteLine("Пароль повинен містити принаймні 8 символів.");
                    return false;
                }
                if (password is null)
                {
                    Console.WriteLine("Пароль не може бути порожнім.");
                    return false;
                }

                foreach (char c in password)
                {
                    if (char.IsDigit(c))
                    {
                        hasDigit = true;
                    }
                    else if (specialChars.Contains(c))
                    {
                        hasSpecialChar = true;
                    }
                }
                return hasDigit && hasSpecialChar;
            }
            if (isValidPassword(password))
            {
                Console.WriteLine("Пароль прийнятний.");
            }
            else
            {
                Console.WriteLine("Пароль не відповідає вимогам.");
            }
            Console.WriteLine("Натисніть будь-яку клавішу для завершення програми");
            Console.ReadKey();
        }
    }
}