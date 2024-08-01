using System;

namespace SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Simple Calculator");
            Console.WriteLine("------------------");

            // Get the first number
            Console.Write("Enter the first number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            // Get the operator
            Console.Write("Enter an operator (+, -, *, /): ");
            char op = Console.ReadLine()[0];

            // Get the second number
            Console.Write("Enter the second number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            // Perform the calculation
            double result = 0;
            bool validOperation = true;

            switch (op)
            {
                case '+':
                    result = num1 + num2;
                    break;
                case '-':
                    result = num1 - num2;
                    break;
                case '*':
                    result = num1 * num2;
                    break;
                case '/':
                    if (num2 != 0)
                    {
                        result = num1 / num2;
                    }
                    else
                    {
                        Console.WriteLine("Error: Division by zero.");
                        validOperation = false;
                    }
                    break;
                default:
                    Console.WriteLine("Error: Invalid operator.");
                    validOperation = false;
                    break;
            }

            if (validOperation)
            {
                Console.WriteLine($"The result of {num1} {op} {num2} = {result}");
            }
        }
    }
}
