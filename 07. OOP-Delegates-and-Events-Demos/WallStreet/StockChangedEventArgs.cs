namespace WallStreet
{
    using System;

    public class StockChangedEventArgs : EventArgs
    {
        public StockChangedEventArgs(double oldPrice, double newPrice)
        {
            this.OldPrice = oldPrice;
            this.NewPrice = newPrice;
        }

        public double OldPrice { get; set; }

        public double NewPrice { get; set; }
    }

}
