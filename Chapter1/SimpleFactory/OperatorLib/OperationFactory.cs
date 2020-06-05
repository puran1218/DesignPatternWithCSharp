using SimpleFactory.OperatorLib;

namespace SimpleFactory.SimpleFactory
{
    public class OperationFactory
    {
        public static Operation createOperator(string inputOperator)
        {
            Operation oper = null;
            switch(inputOperator)
            {
                case "+":
                    oper = new OperationAdd();
                    break;
                case "-":
                    oper = new OperationSub();
                    break;
                case "*":
                    oper = new OperationMul();
                    break;
                case "/":
                    oper = new OperationDiv();
                    break;
            }
            return oper;
        }
    }
}