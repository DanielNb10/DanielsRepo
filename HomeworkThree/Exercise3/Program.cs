using System;

namespace Exercise3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number1;
            int number2;


            while (true)
            {
                Console.WriteLine("Enter the first number");
                string input1 = Console.ReadLine();

                bool succed1 = int.TryParse(input1, out number1);

                if (!succed1)
                {
                    Console.WriteLine("Wrong character");
                    continue;

                }
                break;
            }


            while (true)
            {


                Console.WriteLine("Enter the second number:");
                string input2 = Console.ReadLine();

                bool succed2 = int.TryParse(input2, out number2);

                if (!succed2)
                {
                    Console.WriteLine("Wrong character");
                    continue;
                }
                break;

            }
            int swap = 0;
            swap = number1;
            number1 = number2;
            number2 = swap;

            Console.WriteLine("After the swaping number1 :" + number1 + " number2: " + number2);
        }
    }
}
