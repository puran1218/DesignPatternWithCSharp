using System;
using Chapter2.ClassLibrary.Strategy;

namespace Chapter2
{
    class Program
    {
        static void Main(string[] args)
        {
            double total = 0;
            string add = "add";

            while(add == "add")
            {
                Console.Write("Please input the price: ");
                double price = Convert.ToDouble(Console.ReadLine());

                Console.Write("Please input the number: ");
                double number = Convert.ToDouble(Console.ReadLine());
                
                Console.Write("Please input the discount: 0/满百返百/8折 ");
                string discount = Console.ReadLine();

                // CashSuper cashsuper = CashFactory.createCashAccept(discount);

                CashContext cashsuper = new CashContext(discount);

                double totalPrice = 0;

                totalPrice = cashsuper.GetResult(price * number);

                total += totalPrice;

                Console.Write("Price: " + price + ", ");
                Console.Write("Number: " + number + ", ");
                Console.Write("Discount: " + discount + ", ");
                Console.Write("The totalPrice is: " + totalPrice);
                Console.WriteLine("\nThe total price is: " + total);

                Console.Write("Add more items or checkout? (add/check)");
                add = Console.ReadLine();
            }
            
        }
    }
}
