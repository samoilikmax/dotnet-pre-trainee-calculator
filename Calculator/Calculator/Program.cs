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
        static double GetvalidNumber(string message)
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
        static void Main(string[] args)
        {
            double firstNumber, secondNumber;
            char operand;

            
        }
    }
}