using System;

namespace Ecercise2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //AverageNumber

            int number1;
            int number2;
            int number3;
            int number4;
            int number5;
            int sum = 0;

            while (true) 
            {
                 Console.WriteLine("Enter the first number ");
                 string input1 = Console.ReadLine();

                 bool succed1 = int.TryParse(input1, out  number1);
                 if (!succed1)
                 {
                      Console.WriteLine("You put wrong charachter!");
                      continue;
                 }
                break;

            }


            while (true)
            {

            
                Console.WriteLine("Enter the second number ");
                string input2 = Console.ReadLine();

                bool succed2 = int.TryParse(input2, out  number2);
                if (!succed2)
                {
                    Console.WriteLine("You put wrong charachter!");
                    continue;
                }
                

                Console.WriteLine("Enter the third number ");
                string input3 = Console.ReadLine();

                bool succed3 = int.TryParse(input3, out  number3);
                if (!succed3)
                {
                    Console.WriteLine("You put wrong charachter!");
                    continue;
                }
                break;
               }


            while (true)
            {

            
                Console.WriteLine("Enter the fourth number ");
                string input4 = Console.ReadLine();

                bool succed4 = int.TryParse(input4, out  number4);
                if (!succed4)
                {
                    Console.WriteLine("You put wrong charachter!");
                    continue;
                }
                break;
            }

            while (true)
            {

            
                Console.WriteLine("Enter the fifth number ");
                string input5 = Console.ReadLine();

                bool succed5 = int.TryParse(input5, out  number5);
                if (!succed5)
                {
                    Console.WriteLine("You put wrong charachter!");
                    continue;
                }
                break;
            }

            sum = number1 + number2 + number3 + number4 + number5;
            float average = (float)sum / 5;

            Console.WriteLine("The average of the numbers is " + average);
            
               

        } 
    }
}
