using System;

namespace LoopDaddy
{
    class Program
    {
        static void Main(string[] args)
        {
            //EXERCISE 3 -
            //Use a for loop to output a triangle of asterisks with a height of ten.
            for (int i = 1; i <= 10; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }


            //EXERCISE 2 - 
            //Prompt the user for a number.  Use a for loop to output all the numbers from that number to 0.           
            /*Console.Write("Please enter a number: ");
            string userInput = Console.ReadLine();
            int number;
            number = int.Parse(userInput);
            for (int i = number; i>= 0; i--)
            {
                Console.WriteLine(i);
            }
           */


            //EXERCISE 1 - 
            //Use a do-while loop to output "Hello, World!" in a loop.  Each time you output "Hello, World!"
            //Ask the user wheher or not they wouldl ike to continue.
            /*		string input;
            do
            {
                Console.WriteLine("Hello World!");
                Console.Write("Are you ready for this jelly?(yes/no) ");
                input = Console.ReadLine();

            }
            while (input.ToLower() == "yes" || input.ToLower().Contains("y")); */
        }
    }
}
