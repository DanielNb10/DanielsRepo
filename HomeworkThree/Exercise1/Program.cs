using System;

namespace Exercise1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int number1;
            int number2;


            while (true)
            {
                Console.WriteLine("Vnesete go prviot broj:");
                string input1 = Console.ReadLine();

                bool succed1 = int.TryParse(input1, out  number1);

                if (!succed1)
                {
                    Console.WriteLine("Vnesovte nevaliden broj");
                    continue;

                }
                break;
            }


            while (true)
            {

            
               Console.WriteLine("Vnesete go vtoriot broj:");
               string input2 = Console.ReadLine();

               bool succed2 = int.TryParse(input2, out  number2);

                if(!succed2)
                {
                   Console.WriteLine("Vnesovte nevaliden broj");
                    continue;
                }
                break;
            
            }



            Console.WriteLine("Vnesete matematicka operacija");
            string inputChar = Console.ReadLine();

            if (inputChar == "+")
            {
                int result1 = number1 + number2;
                Console.WriteLine("The result is " + result1);
            }
            else if (inputChar == "-")
            {
                int result2 = number1 + number2;
                Console.WriteLine("The result is " + result2);
            }
            else if (inputChar == "*")
            {
                int result3 = number1 * number2;
                Console.WriteLine("The result is " + result3);
            }
            else if (inputChar == "/")
            {
                float result4 = number1 / (float)number2;
                Console.WriteLine("The result is " + result4);
            }
            else
            {
                Console.WriteLine("Vnesovte nevaliden karakter");
            }





        }
    }
}
