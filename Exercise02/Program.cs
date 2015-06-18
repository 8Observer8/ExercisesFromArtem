using System;

namespace Exercise02
{
    /// <summary>
    /// Задание 2. Вывести времена года в зависимости от месяца введенного пользователем.
    /// Conditional Statement <if>
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            // Спрашиваем пользователя: какой текущий месяц?

            Console.Write("What is the current month?  ");

            // Присваиваем переменной полученное значение

            string month = Console.ReadLine();

            if (month == "December" || month == "January" || month == "Febrary")
            {
                Console.WriteLine("It is winter");
            }


            else if (month == "March" || month == "April" || month == "May")
            {
                Console.WriteLine("It is spring");
            }


            else if (month == "June" || month == "July" || month == "August")
            {
                Console.WriteLine("It is summer");
            }


            else if (month == "September" || month == "October" || month == "November")
            {
                Console.WriteLine("It is autumn");
            }


            else
            {
                Console.WriteLine("Provide appropriate input");
            }

            Console.ReadKey();

        }
    }
}
