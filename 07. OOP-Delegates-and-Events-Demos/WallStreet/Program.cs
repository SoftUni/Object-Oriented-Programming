namespace WallStreet
{
    using System;

    public class Program
    {
        static void Main()
        {
            // Create IBM stock
            var ibm = new IBM("IBM", 120.00);

            // Attach event handler to StockChange event
            ibm.StockChange += (stock, args) =>
            {
                Console.WriteLine("Stock has changed from {0:F2} to {1:F2}",
                    args.OldPrice, args.NewPrice);
            };

            // Fluctuating prices will fire the event
            ibm.Price = 120.10;
            ibm.Price = 121.00;
            ibm.Price = 120.50;
            ibm.Price = 120.75;
        }
    }
}
