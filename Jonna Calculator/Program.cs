using System;
using System.Collections.Generic;
using System.Linq;

namespace Jonna_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Calculator";
            Console.BackgroundColor = ConsoleColor.Magenta;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Clear();

            List<double> calculationSummary = new List<double>();
            bool isRunning = true;

            while(isRunning)
            {

				Console.WriteLine("Enter your first operator :");
				string op = Console.ReadLine();

				Console.WriteLine("Enter your second operator");
				string op2 = Console.ReadLine();

				Console.WriteLine("Enter your first number");
				string firstNumber = Console.ReadLine();
				double firstNumberInDouble = Convert.ToDouble(firstNumber);

				Console.WriteLine("Enter your second number");
				string secondNumber = Console.ReadLine();
				double secondNumberInDouble = Convert.ToDouble(secondNumber);

				Console.WriteLine("Enter your third number");
				string thirdNumber = Console.ReadLine();
				double thirdNumberInDouble = Convert.ToDouble(thirdNumber);
				Console.Clear();

				double sum1 = 0;
				double sum2 = 0;

				if (op == "+")
				{

					sum1 = firstNumberInDouble + secondNumberInDouble;

					if (op2 == "+")
					{
						sum2 = sum1 + thirdNumberInDouble;
						Console.WriteLine("Your result is " + sum2);
					}

					else if (op2 == "-")
					{
						sum2 = sum1 - thirdNumberInDouble;
						Console.WriteLine("Your result is " + sum2);
					}

					else if (op2 == "*")
					{
						sum2 = sum1 * thirdNumberInDouble;
						Console.WriteLine("Your result is " + sum2);
					}

					else if (op2 == "/")
					{
						sum2 = sum1 / thirdNumberInDouble;
						Console.WriteLine("Your result is " + sum2);
					}
				}
				else if (op == "-")
				{

					sum1 = firstNumberInDouble - secondNumberInDouble;

					if(op2 == "+")
                    {
						sum2 = sum1 + thirdNumberInDouble;
						Console.WriteLine("Your result is " + sum2);
					}
					else if(op2 == "-")
                    {
						sum2 = sum1 - thirdNumberInDouble;
						Console.WriteLine("Your result is " + sum2);
					}
					else if(op2 == "*")
                    {
						sum2 = sum1 * thirdNumberInDouble;
						Console.WriteLine("Your result is " + sum2);
					}
					else if(op2 == "/")
                    {
						sum2 = sum1 * thirdNumberInDouble;
						Console.WriteLine("Your result is " + sum2);
					}

				}
				else if (op == "*")
				{

					sum1 = firstNumberInDouble * secondNumberInDouble;

					if (op2 == "+")
					{
						sum2 = sum1 + thirdNumberInDouble;
						Console.WriteLine("Your result is " + sum2);
					}
					else if (op2 == "-")
					{
						sum2 = sum1 - thirdNumberInDouble;
						Console.WriteLine("Your result is " + sum2);
					}
					else if (op2 == "*")
					{
						sum2 = sum1 * thirdNumberInDouble;
						Console.WriteLine("Your result is " + sum2);
					}
					else if (op2 == "/")
					{
						sum2 = sum1 * thirdNumberInDouble;
						Console.WriteLine("Your result is " + sum2);
					}
				}
				else if (op == "/")
				{

					sum1 = firstNumberInDouble / secondNumberInDouble;

					if (op2 == "+")
					{
						sum2 = sum1 + thirdNumberInDouble;
						Console.WriteLine("Your result is " + sum2);
					}
					else if (op2 == "-")
					{
						sum2 = sum1 - thirdNumberInDouble;
						Console.WriteLine("Your result is " + sum2);
					}
					else if (op2 == "*")
					{
						sum2 = sum1 * thirdNumberInDouble;
						Console.WriteLine("Your result is " + sum2);
					}
					else if (op2 == "/")
					{
						sum2 = sum1 * thirdNumberInDouble;
						Console.WriteLine("Your result is " + sum2);
					}
				}

				calculationSummary.Add(sum2);
				double theWholeSum = calculationSummary.Sum();

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

				Console.WriteLine("Want to play again? Write yes/no");
				string answer = Console.ReadLine();

				if (answer == "yes")
				{
					Console.Clear();
					continue;
				}
				else
				{
                    Console.WriteLine("Thank you for playing the calculator! Your total sum for this session was " + theWholeSum + " Good bye!");
					isRunning = false;
				}

			}

		}
	}
}
