using System;

namespace Test_Project
{
    public class Programm
    {
        public static void printPyramid(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write('*');
                }
                Console.WriteLine();
            }
        }

        public static void printEvenNumbers(int minValue, int maxValue)
        {
            if (minValue > maxValue)
            {
                int temp = maxValue;
                maxValue = minValue;
                minValue = temp;
            }
            for (int i = minValue; i <= maxValue; i++)
            {
                if (i % 2 == 0)
                {
                    Console.Write(i + " ");
                }
            }
        }

        public static void calculator(double num1, double num2, string op)
        {
            try
            {
                double result;

                switch (op)
                {
                    case "+":
                        result = num1 + num2;
                        break;
                    case "-":
                        result = num1 - num2;
                        break;
                    case "*":
                        result = num1 * num2;
                        break;
                    case "/":
                        if (num2 == 0)
                        {
                            throw new DivideByZeroException("You cannot divide by zero!");
                        }
                        result = num1 / num2;
                        break;
                    default:
                        throw new InvalidOperationException("Invalid operator!");
                }

                Console.WriteLine("Result: " + result);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }

        public static void Main(string[] args)
        {
            //დავალება 1 
            Console.WriteLine("Enter pyramids height: ");
            int n = int.Parse(Console.ReadLine());
            printPyramid(n);
            //დავალება 2 
            Console.WriteLine("Enter min value and max value: ");
            int min = int.Parse(Console.ReadLine()), max = int.Parse(Console.ReadLine());
            printEvenNumbers(min, max);
            Console.WriteLine();
            // დავალება 3
            while (true)
            {
                Console.WriteLine("Enter X to exit the program");
                string exitChoice = Console.ReadLine();
                if (exitChoice.Equals("X", StringComparison.OrdinalIgnoreCase))
                    break;

                try
                {
                    Console.WriteLine("Enter first number: ");
                    double num1 = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Enter operator (+, -, *, /): ");
                    string op = Console.ReadLine();

                    Console.WriteLine("Enter second number: ");
                    double num2 = Convert.ToDouble(Console.ReadLine());

                    calculator(num1, num2, op);
                }
                catch (FormatException)
                {
                    Console.WriteLine("Error: Please enter valid numbers!");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Unexpected error: " + ex.Message);
                }
            }
        }
    }
}
