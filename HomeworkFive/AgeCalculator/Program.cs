using System;

namespace AgeCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime birthDay = new DateTime(1997, 4, 6);
            int result = AgeCalculator(birthDay);
            Console.WriteLine($"You have {result} years.");
        }

        public static int AgeCalculator(DateTime birthDate)
        {
            DateTime now = DateTime.Now;
            int age = now.Year - birthDate.Year;

            if (now.Month < birthDate.Month || (now.Month == birthDate.Month && now.Day < birthDate.Day))
                age--;

            return age;
        }
    }
}
