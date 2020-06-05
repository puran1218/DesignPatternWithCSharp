using System;
using SimpleFactory.OperatorLib;

namespace SimpleFactory.OperatorLib
{
    public class OperationAdd : Operation
    {
        public override double getResult()
        {
            double result = 0;
            result = FirstNumber + SecondNumber;
            return result;
        }
    }

    public class OperationSub : Operation
    {
        public override double getResult()
        {
            double result = 0;
            result = FirstNumber + SecondNumber;
            return result;
        }
    }

    public class OperationMul : Operation
    {
        public override double getResult()
        {
            double result = 0;
            result = FirstNumber * SecondNumber;
            return result;
        }
    }

    public class OperationDiv : Operation
    {
        public override double getResult()
        {
            double result = 0;
            if (SecondNumber == 0)
            {
                throw new Exception("Divide number can't be 0.");
            }
            result = FirstNumber / SecondNumber;
            return result;
        }
    }
}