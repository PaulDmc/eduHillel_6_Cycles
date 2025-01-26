//4. Перевірка паролю: Напишіть програму, яка перевіряє пароль користувача. Пароль вважається прийнятним, якщо він містить принаймні 8 символів, з яких принаймні один символ - це цифра, а також принаймні один символ - це спеціальний символ (наприклад, !, @, # тощо).
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




namespace eduHillel_HW6_Demchenko_4
{
    public class Program
    {

        public static void Main()
        {
            string specialChars = "!@#$%^&*()_+[]{}|;:,.<>?`~";
            bool hasDigit = false;
            bool hasSpecialChar = false;

            Console.WriteLine("Enter password:");
            var password = Console.ReadLine();

            bool isValidPassword(string password)
            {
                if (password.Length < 8)
                {
                    Console.WriteLine("Password must contain at least 8 characters.");
                    return false;
                }
                if (password is null)
                {
                    Console.WriteLine("Password cannot be empty.");
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
                Console.WriteLine("Password is valid.");
            }
            else
            {
                Console.WriteLine("Password does not match.");
            }
            Console.WriteLine("Press any key to end the program.");
            Console.ReadKey();
        }
    }
}