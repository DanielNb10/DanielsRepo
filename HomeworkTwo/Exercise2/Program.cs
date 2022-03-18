using System;

namespace Exercise2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int totalCredits = 102;
            int creditPerMessage = 5;

            int numberOfMessage = totalCredits / creditPerMessage;

            Console.WriteLine("The number of message is " + numberOfMessage);
        }
    }
}
