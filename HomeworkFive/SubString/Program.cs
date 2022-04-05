using System;

namespace SubString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vnesete broj: ");
            string input = Console.ReadLine();

            bool succes = int.TryParse(input, out int n);

            while(true)
            { 
               if (!succes)
               {
                  Console.WriteLine("Vnesi broj");
                    continue;
               }
                break;
            }
            string final;
            string result = Substrings();

            if(result.Length < n)
            {
                final = result.Substring(0, result.Length );
                Console.WriteLine(final);
            }
            else 
            { 
                final = result.Substring(0, n);
                Console.WriteLine(final);
                Console.WriteLine(final.Length);
            }

            

        }

        public static string Substrings()
        {
            return  "Hello from SEDC Codeacademy 2022";
            
        }
    }
}
