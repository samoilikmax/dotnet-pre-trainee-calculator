using System;

namespace Calculator
{
    internal class Calculator
    {
        public static double Addition(double x, double y)
        {
            return x + y;
        }

        public static double Subtraction(double x, double y)
        {
            return x - y;
        }

        public static double Multiplication(double x, double y)
        {
            return x * y;
        }

        public static double Division(double x, double y)
        {
            return x / y;
        }


    }
    internal class Program
    {
        static double GetValidNumber(string message)
        {
            double number;
            Console.Write(message);

            while(!double.TryParse(Console.ReadLine(), out number))
            {
                Console.WriteLine("Error! Not a number entered!");
                Console.Write(message);
            }

            return number;
        }

        static char GetvalidOperand()
        {
            char op;

            Console.Write("Chose an operation (+ , -, * or /): ");

            while (!char.TryParse(Console.ReadLine(), out op) || (op != '+' && op != '-' && op != '*' && op != '/'))
            {
                Console.WriteLine("Error! Unknown operation!");
                Console.Write("Chose an operation (+ , -, * or /): ");
            }

            return op;
        }
        static void Main(string[] args)
        {
            double firstNumber, secondNumber;
            char operand;

            bool userChoice = true;

            while (userChoice)
            {
                firstNumber = GetValidNumber("Enter the first number: ");
                operand = GetvalidOperand();
                secondNumber = GetValidNumber("Enter the second number: ");

                double result = 0;
                bool isCalculationValid = true;

                switch (operand)
                {
                    case '+': result = Calculator.Addition(firstNumber, secondNumber); break;
                    case '-': result = Calculator.Subtraction(firstNumber, secondNumber); break;
                    case '*': result = Calculator.Multiplication(firstNumber, secondNumber); break;

                    case '/':
                        if (secondNumber == 0)
                        {
                            Console.WriteLine("Error! Division by zero is not allowed.");
                            isCalculationValid = false;
                        }
                        else
                        {
                            result = Calculator.Division(firstNumber, secondNumber);
                        }
                        break;
                }

                if (isCalculationValid)
                {
                    Console.WriteLine($"Result: {firstNumber} {operand} {secondNumber} = {result}");
                }

                Console.WriteLine("Do you want to continue? (y/n)");
                string userInput = Console.ReadLine();
                if(userInput != "y")
                {
                    userChoice = false;
                }
            }

        }
    }
}