using System;

namespace BasicInformation
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Prompt the user for their name
                Console.Write("Enter your name: ");
                string name = Console.ReadLine();

                // Prompt the user for their surname
                Console.Write("Enter your surname: ");
                string surname = Console.ReadLine();

                // Prompt the user for their age
                Console.Write("Enter your age: ");
                string ageInput = Console.ReadLine();
                int age = int.Parse(ageInput);

                // Display the entered details in a formatted message
                Console.WriteLine("********************************");
                Console.WriteLine($"Name: {name}");
                Console.WriteLine($"Surname: {surname}");
                Console.WriteLine($"Age: {age}");
                Console.WriteLine("********************************");
            }
            catch (FormatException ex)
            {
                // Handle format exception if the input is not a valid number
                Console.WriteLine("Error: The input for age is not a valid number.");
                Console.WriteLine($"Details: {ex.Message}");
            }
            catch (Exception ex)
            {
                // Handle any other exceptions
                Console.WriteLine("An unexpected error occurred.");
                Console.WriteLine($"Details: {ex.Message}");
            }
        }
    }
}
