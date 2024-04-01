using System;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to my C# program");
            Console.WriteLine("This is my first homework\n");

            int input;

            do
            {
                Console.WriteLine("What do you want to do? Enter a number:");
                Console.WriteLine("1. Monday");
                Console.WriteLine("2. Tuesday");
                Console.WriteLine("3. Wednesday");
                Console.WriteLine("4. Thursday");
                Console.WriteLine("0. Exit");

                // Read user input
                input = Convert.ToInt32(Console.ReadLine());

                // Perform action based on user input
                switch (input)
                {
                    case 1:
                        Console.WriteLine("process 1 is running");
                        break;
                    case 2:
                        Console.WriteLine("process 2 is running");
                        break;
                    case 3:
                        Console.WriteLine("process 3 is running");
                        break;
                    case 4:
                        Console.WriteLine("process 4 is running");
                        break;
                    case 0:
                        Console.WriteLine("Exiting program...");
                        break;
                    default:
                        Console.WriteLine("Invalid input. Please enter a number between 0 and 4.");
                        break;
                }

                // Add a newline for better readability
                Console.WriteLine();
            }
            while (input != 0); // Keep looping until the user inputs 0 to exit
        }
    }
}
