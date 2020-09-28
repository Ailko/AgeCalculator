using System;

namespace AgeCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            ShowWelcomeMessage();
        }

        static void ShowWelcomeMessage()
        {
            Console.WriteLine("Welkom!! \nDeze applicatie berekent hoe oud je bent. " +
                "\nHiervoor zullen we uw leeftijd vragen (die enkel voor deze functie gebruikt wordt)");
        }

        static DateTime EnterBirthDate()
        {
            int year = askX("year");
            int month = askX("month");
            int day = askX("day");

            return new DateTime(year, month, day);
        }

        static int askX(string toAsk)
        {
            bool entered = false;
            while (!entered)
            {
                Console.Clear();
                Console.Write($"Please enter your birth {toAsk}: ");
                if (Int32.TryParse(Console.ReadLine(), out int value))
                {
                    return value;
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("Please enter a valid number.");
                    Console.ReadLine();
                }
            }
            return 0;
        }

        static void PrintAge(TimeSpan age)
        {
            int years = (int)Math.Floor(age.Days / 365.2425);
            int months = (int)Math.Floor(age.Days / 365.2425 * 12) - (int)Math.Floor(age.Days / 365.2425) * 12;
            int days = age.Days - (int)((Math.Floor(age.Days / 365.2425 * 12) - Math.Floor(age.Days / 365.2425) * 12) / 12 * 365.2425) - (int)(Math.Floor(age.Days / 365.2425) * 365.2425);
            Console.WriteLine($"You are {years} years, {months} months and {days} days old.");
        }
    }
}
