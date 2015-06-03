using System;

namespace StackTrace
{
    class Sales
    {
        static void Main()
        {
            string input = " SteamOp 50";
            string[] args = input.Split(' ');

            string customer = args[0];
            string product = args[1];
            double price = double.Parse(args[2]);

            try
            {
                ProcessSale(customer, product, price);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine("Price cannot be a negative number. Please enter a positive number.");
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine("{0} cannot be left empty.", ex.ParamName);
            }

            Console.WriteLine("Finished");
        }

        private static void ProcessSale(string customer, string product, double price)
        {
            var sale = new Sale(customer, product, price);
            Console.WriteLine(sale);
        }
    }
}
