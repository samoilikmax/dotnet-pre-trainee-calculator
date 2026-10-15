using System;

namespace Calculator
{
    internal class Calculator
    {
        internal int Addition(int x, int y)
        {
            return x + y;
        }

        internal int Subtraction(int x, int y)
        {
            return x - y;
        }

        internal int Multiplication(int x, int y)
        {
            return x * y;
        }

        internal int Division(int x, int y)
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

            firstNumber = GetValidNumber("Enter the first number: ");
            operand = GetvalidOperand();
            secondNumber = GetValidNumber("Enter the second number: ");
        }
    }
}