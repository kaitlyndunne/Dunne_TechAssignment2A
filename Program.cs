/*
    Author: Kaitlyn Dunne
    Date: 09-15-2020
    Comments: Demonstrates the use of iterative statements after getting input from users.
*/


using System;

namespace Dunne_TechAssignment2A
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ask the user for input
            Console.Write("Enter an integer value between 1 and 25 to execute an iterative statement:");

            // Use the try catch to validate user input or handle errors if bad input
            try
            {
                //Variable will gather data from user input
                string input = Console.ReadLine();
                // This variable will be used in iterative statements and parsed as an integer
                int value_of_input = int.Parse(input);

                // If the value is between 1 and 25, execute a for loop
                if ((value_of_input > 0) && (value_of_input <= 25))
                {
                    Console.WriteLine("Executing a For Loop!");

                    // Here is the for loop
                    for (int i = 0; i < value_of_input; i++)
                    {
                        Console.WriteLine("You have entered " + value_of_input.ToString() + ". This is the current integer value in the loop: " +i.ToString());
                    }
                    Console.WriteLine("Press any key to exit the program...");
                    Console.ReadKey(true);
                }
                // If the user does not enter a value between 1 and 25, display a message
                else if (value_of_input <= 26)
                {
                    Console.WriteLine("Please enter an integer value between 1 and 25 and try again...");
                    Console.WriteLine("Press any key to exit the program and try again...");
                    Console.ReadKey(true);
                }
            }

            catch
            {
                Console.WriteLine("Please enter an integer value and try running the program again...");
                Console.WriteLine("Press any key to exit the program...");
                Console.ReadKey(true);
            }
        }
    }
}
