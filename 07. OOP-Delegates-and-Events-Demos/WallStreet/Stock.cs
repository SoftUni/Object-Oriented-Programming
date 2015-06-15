namespace WallStreet
{
    using System;

    public delegate void OnStockChangeEventHandler(Stock sender, StockChangedEventArgs args);

    /// <summary>
    /// The 'Subject' abstract class
    /// </summary>
    public abstract class Stock
    {
        public event OnStockChangeEventHandler StockChange;

        private readonly string symbol;
        private double price;

        protected Stock(string symbol, double price)
        {
            this.symbol = symbol;
            this.price = price;
        }

        public double Price
        {
            get
            {
                return this.price;
            }

            set
            {
                if (Math.Abs(this.price - value) > 0.001)
                {
                    if (this.StockChange != null)
                    {
                        this.StockChange(this, 
                            new StockChangedEventArgs(this.price, value));
                    }

                    this.price = value;
                }
            }
        }

        public string Symbol
        {
            get { return this.symbol; }
        }
    }
}
