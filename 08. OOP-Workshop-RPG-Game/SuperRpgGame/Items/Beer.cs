namespace SuperRpgGame.Items
{
    public class Beer : Item
    {
        private const char BeerSymbol = 'B';

        public Beer(Position position, BeerSize beerSize)
            : base(position, BeerSymbol)
        {
            this.BeerSize = beerSize;
        }

        public int HealthRestore
        {
            get
            {
                return (int)this.BeerSize;
            }
        }

        private BeerSize BeerSize { get; set; }
    }
}
