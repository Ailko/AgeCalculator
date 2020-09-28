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

        static TimeSpan AgeCalculator(DateTime birthDay)
        {
            TimeSpan age = new TimeSpan();
            age = DateTime.Now - birthDay;

            return age;
        }
    }
}
