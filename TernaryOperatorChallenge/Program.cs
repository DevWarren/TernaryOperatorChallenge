using System;

namespace TernaryOperatorChallenge
{
    /// <summary>
    /// Create an application that takes a temperature value as input and checks
    /// if the input is an int or not.
    /// If the input is not an int, it should output "not a valid temperature'
    /// And if the input is valid, it should work like:
    /// <=15 "it is too cold here"
    /// >=16 and <=28 "it is ok"
    /// >28 it "is hot here"
    /// Don't use if statements for valid input.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            int temperature;
            string input;
            string message;
            
            Console.WriteLine("Please enter a valid temperature: ");
            input = Console.ReadLine();
            bool validInt = int.TryParse(input, out temperature);
            if (validInt)
            {
                message = temperature <= 15 ? "It's too cold" : temperature > 28 ? "It's hot here" : "It's ok";
                Console.WriteLine(message);
            }
            else
            {
                Console.WriteLine("Not a valid temperature");
            }
        }
    }
}
