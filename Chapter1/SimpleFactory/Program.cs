using System;
using SimpleFactory.SimpleFactory;
using SimpleFactory.OperatorLib;

namespace SimpleFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Please input a number: ");
                double firstNumber = Convert.ToDouble(Console.ReadLine());
                Console.Write("Please input an operator (+, -, *, /): ");
                string inputOperator = Console.ReadLine();
                Console.Write("Please input the second number: ");
                double secondNumber = Convert.ToDouble(Console.ReadLine());

                Operation oper;
                oper = OperationFactory.createOperator(inputOperator);
                oper.FirstNumber = firstNumber;
                oper.SecondNumber = secondNumber;
                double result = oper.getResult();
                
                Console.WriteLine("The result of " + firstNumber + inputOperator + secondNumber + " is: " + result);
            }
            catch
            {
                Console.WriteLine("There is something wrong about your input.");
            }

        }
    }
}
