using System;

namespace StudentGroup
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] studentsG1 = new string[] {"Zdravko", "Petko", "Stanko", "Branko", "Trajko"};
            string[] studentsG2 = new string[] {"Petar", "Ile", "Darko", "Teo", "Mile"};
            int number;

            while (true)
            { 
                 Console.WriteLine("Vnesi broj izmegu, 1 ili 2: ");
                 string input = Console.ReadLine();
                 bool succes = int.TryParse(input, out  number);

            if (!succes)
              {
                 Console.WriteLine("Ne vnesovte broj");
                    continue;
              }
                break;

            }
            if(number == 1)
            {
                Console.WriteLine("The students in G1 are :");
                foreach(string student in studentsG1)
                {
                    Console.WriteLine(student);

                }         
            }
             else if(number == 2)
            {
                Console.WriteLine("The students in G2 are : ");
                foreach(string student in studentsG2) 
                {
                    Console.WriteLine(student);
                 
                }

            }
            else
            {
                Console.WriteLine("Ne vnesovte broj izmegu 1 i 2");
            }
        }
    }
}
