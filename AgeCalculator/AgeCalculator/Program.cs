using System;

namespace AgeCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            ShowWelcomeMessage();
            PrintAge(AgeCalculator(EnterBirthDate()));
        }


        static void ShowWelcomeMessage()
        {
            Console.WriteLine("Welkom!! \nDeze applicatie berekent hoe oud je bent. " +
                "\nHiervoor zullen we uw leeftijd vragen (die enkel voor deze functie gebruikt wordt)");
            Console.WriteLine("\n press enter to continue");
            Console.ReadLine();
        }

        static TimeSpan AgeCalculator(DateTime birthDay)
        {
            TimeSpan age = new TimeSpan();
            age = DateTime.Now - birthDay;

            return age;
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
            while (true)
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
        }

        static void PrintAge(TimeSpan age)
        {
            int years = (int)Math.Floor(age.Days / 365.2425);
            int months = (int)Math.Floor(age.Days / 365.2425 * 12) - years * 12;
            int days = age.Days - (int)(months / 12 * 365.2425) - (int)(years * 365.2425);
            Console.WriteLine($"You are {years} years, {months} months and {days} days old.");
        }
    }
}

