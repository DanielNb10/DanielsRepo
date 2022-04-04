using System;

namespace SumOfEven
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int[] numbers = new int[6];

            for (int i = 0; i < numbers.Length; i++)
            {
                while (true)
                {
                    Console.WriteLine("Vnesete go " + (i + 1) + " broj");
                    string input = Console.ReadLine();

                    bool succes = int.TryParse(input, out int number);

                    if (!succes)
                    {
                        Console.WriteLine("Vnesete validen broj");
                        continue;
                    }

                    numbers[i] = number;
                    break;
                }
            }
            int sum = 0;
            foreach(int number in numbers)
            {
                if(number % 2 == 0)
                {
                    sum += number;
                }
            }
            Console.WriteLine("Rezultatot e " + sum);
        }
    }
}
