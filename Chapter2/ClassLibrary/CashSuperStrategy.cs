using System;

namespace Chapter2.ClassLibrary.Strategy
{
    abstract class CashSuper
    {
        public abstract double acceptCash(double money); //现金收取抽象类，参数为原价，返回原价
    }

    class CashNormal : CashSuper
    {
        public override double acceptCash(double money)
        {
            return money;
        }
    }

    class CashRebate : CashSuper
    {
        private double moneyRebate = 1;
        public CashRebate(string moneyRebate)
        {
            this.moneyRebate = double.Parse(moneyRebate);
        }

        public override double acceptCash(double money)
        {
            return money * moneyRebate;
        }
    }

    class CashReturn : CashSuper
    {
        private double moneyCondition = 0;
        private double moneyReturn = 0;
        public CashReturn(string moneyCondition, string moneyReturn)
        {
            this.moneyCondition = double.Parse(moneyCondition);
            this.moneyReturn = double.Parse(moneyReturn);
        }
        public override double acceptCash(double money)
        {
            double result = money;
            if (money >= moneyCondition)
            {
                result = money - Math.Floor(money / moneyCondition) * moneyReturn;
            }
            return result;
        }
    }

    // class CashContext
    // {
    //     private CashSuper cashsuper;
    //     public CashContext(CashSuper cashsuper)
    //     {
    //         this.cashsuper = cashsuper;
    //     }

    //     public double GetResult(double money)
    //     {
    //         return cashsuper.acceptCash(money);
    //     }
    // }

    class CashContext
    {
        CashSuper cashsuper = null;
        public CashContext(string type)
        {
            switch (type)
            {
                case "0":
                    CashNormal cashNormal = new CashNormal();
                    cashsuper = cashNormal;
                    break;
                case "满百返百":
                    CashReturn cashReturn = new CashReturn("300", "100");
                    cashsuper = cashReturn;
                    break;
                case "8折":
                    CashRebate cashRebate = new CashRebate("0.8");
                    cashsuper = cashRebate;
                    break;
            }
        }

        public double GetResult(double money)
        {
            return cashsuper.acceptCash(money);
        }
    }

    // class CashFactory
    // {
    //     public static CashSuper createCashAccept(string type)
    //     {
    //         CashSuper cashsuper = null;
    //         switch (type)
    //         {
    //             case "0":
    //                 cashsuper = new CashNormal();
    //                 break;
    //             case "满百返百":
    //                 CashReturn cashReturn = new CashReturn("300", "100");
    //                 cashsuper = cashReturn;
    //                 break;
    //             case "8折":
    //                 CashRebate cashRebate = new CashRebate("0.8");
    //                 cashsuper = cashRebate;
    //                 break;
    //         }

    //         return cashsuper;
    //     }
    // }
}