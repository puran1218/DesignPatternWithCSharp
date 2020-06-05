using System;

namespace SimpleFactory.OperatorLib
{
    public class Operation
    {
        private double firstNumber = 0;
        private double secondNumber = 0;

        public double FirstNumber
        {
            get { return firstNumber; }
            set { firstNumber = value; }
        }
        public double SecondNumber
        {
            get { return secondNumber; }
            set { secondNumber = value; }
        }
        public virtual double getResult()
        {
            double result = 0;
            return result;
        }
    }
}
