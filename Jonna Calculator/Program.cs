using System;
using System.Collections.Generic;
using System.Linq;

namespace Jonna_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Setting up the settings
            Console.Title = "Calculator";
            Console.BackgroundColor = ConsoleColor.Magenta;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Clear();

			//Create a list where the total sum will be stored
            List<int> calculationSummary = new List<int>();
			//Create a bool set to true so the program can be repeated until exited
            bool isRunning = true;

			//Create a loop
            while(isRunning)
            {

				//Enter your first operator
				Console.WriteLine("Enter your first operator :");
				//Save first operator in string
				string op = Console.ReadLine();

				//Enter your second operator
				Console.WriteLine("Enter your second operator");
				//Save second operator in string
				string op2 = Console.ReadLine();

				//Enter your first number
				Console.WriteLine("Enter your first number");
				//Save first number in string
				string firstNumber = Console.ReadLine();
				//Convert string to int
				int firstNumberInInt = Convert.ToInt32(firstNumber);

				//Enter your second number
				Console.WriteLine("Enter your second number");
				//Save second number in string
				string secondNumber = Console.ReadLine();
				//Convert string to int
				int secondNumberInInt = Convert.ToInt32(secondNumber);

				//Enter your third number
				Console.WriteLine("Enter your third number");
				//Save third number in string
				string thirdNumber = Console.ReadLine();
				//Convert string to int
				int thirdNumberInInt = Convert.ToInt32(thirdNumber);
				Console.Clear();

				//Set up variables to store sums for the different calculations
				int sum1 = 0;
				int sum2 = 0;

				//If first operator is plus
				if (op == "+")
				{
					//Create a int to pass on to next operator
					sum1 = firstNumberInInt + secondNumberInInt;

					//And if second operator is plus
					if (op2 == "+")
					{
						//Add the third number into the calculation
						sum2 = sum1 + thirdNumberInInt;
						//Display the result
						Console.WriteLine("Your result is " + sum2);
					}
					//And if second operator is minus
					else if (op2 == "-")
					{
						//Add the third number into the calculation
						sum2 = sum1 - thirdNumberInInt;
						//Display the result
						Console.WriteLine("Your result is " + sum2);
					}
					//And if second operator is multiply
					else if (op2 == "*")
					{
						sum2 = sum1 * thirdNumberInInt;
						Console.WriteLine("Your result is " + sum2);
					}
					//And if second operator is divide
					else if (op2 == "/")
					{
						sum2 = sum1 / thirdNumberInInt;
						Console.WriteLine("Your result is " + sum2);
					}
				}
				else if (op == "-")
				{

					sum1 = firstNumberInInt - secondNumberInInt;

					if(op2 == "+")
                    {
						sum2 = sum1 + thirdNumberInInt;
						Console.WriteLine("Your result is " + sum2);
					}
					else if(op2 == "-")
                    {
						sum2 = sum1 - thirdNumberInInt;
						Console.WriteLine("Your result is " + sum2);
					}
					else if(op2 == "*")
                    {
						sum2 = sum1 * thirdNumberInInt;
						Console.WriteLine("Your result is " + sum2);
					}
					else if(op2 == "/")
                    {
						sum2 = sum1 * thirdNumberInInt;
						Console.WriteLine("Your result is " + sum2);
					}

				}
				else if (op == "*")
				{
					//Create a int to pass on to next operator
					sum1 = firstNumberInInt * secondNumberInInt;

					if (op2 == "+")
					{
						sum2 = sum1 + thirdNumberInInt;
						Console.WriteLine("Your result is " + sum2);
					}
					else if (op2 == "-")
					{
						sum2 = sum1 - thirdNumberInInt;
						Console.WriteLine("Your result is " + sum2);
					}
					else if (op2 == "*")
					{
						sum2 = sum1 * thirdNumberInInt;
						Console.WriteLine("Your result is " + sum2);
					}
					else if (op2 == "/")
					{
						sum2 = sum1 * thirdNumberInInt;
						Console.WriteLine("Your result is " + sum2);
					}
				}
				else if (op == "/")
				{
					//Create a int to pass on to next operator
					sum1 = firstNumberInInt / secondNumberInInt;

					if (op2 == "+")
					{
						sum2 = sum1 + thirdNumberInInt;
						Console.WriteLine("Your result is " + sum2);
					}
					else if (op2 == "-")
					{
						sum2 = sum1 - thirdNumberInInt;
						Console.WriteLine("Your result is " + sum2);
					}
					else if (op2 == "*")
					{
						sum2 = sum1 * thirdNumberInInt;
						Console.WriteLine("Your result is " + sum2);
					}
					else if (op2 == "/")
					{
						sum2 = sum1 * thirdNumberInInt;
						Console.WriteLine("Your result is " + sum2);
					}
				}

				//Add the sum to the list that will display the full sum when quitting the calculator
				calculationSummary.Add(sum2);
				int theWholeSum = calculationSummary.Sum();

				//Check what the summary is of the chosen calculation
				if (sum2 < 50)
				{
					Console.WriteLine("Your sum is below 50!");
				}
				else if( sum2 == 100)
                {
                    Console.WriteLine("Wow your sum is 100!");
                }
				else if(sum2 > 100)
                {
                    Console.WriteLine("Your sum is over 100! gz");
                }

				//Ask the user if they want to do another calculation
				Console.WriteLine("Want to play again? Write yes/no");
				string answer = Console.ReadLine();

				//If yes, repeat the loop from the start
				if (answer == "yes")
				{
					Console.Clear();
					continue;
				}
				//If no show the total summary of all tries and then exit the program
				else
				{
                    Console.WriteLine("Thank you for playing the calculator! Your total sum for this session was " + theWholeSum + " Good bye!");
					isRunning = false;
				}

			}

		}
	}
}
