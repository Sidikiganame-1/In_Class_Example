using System;

namespace MIS_Problem_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string footballTicket = "";
            double Ticket;
            double Price;

            Console.WriteLine("What is the product name of the item you are purchassing?");
            footballTicket = Console.ReadLine();

            Console.WriteLine("How many football ticket's do you want to buy?");
            Ticket = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("What is the price for each football ticket?");
            Price = Convert.ToDouble(Console.ReadLine());

            const double Tax = .085;
            double result = Ticket * Price;
            double SalesTax = result * Tax;
            double Total = result + SalesTax;
            Console.WriteLine($"Your subtotal is:  {result.ToString("C")}");
            Console.WriteLine($"Your sales tax is {SalesTax.ToString("C")}");
            Console.WriteLine($"Your total after tax is {Total.ToString("C")}");
            Console.ReadLine();
        }
    }
}
