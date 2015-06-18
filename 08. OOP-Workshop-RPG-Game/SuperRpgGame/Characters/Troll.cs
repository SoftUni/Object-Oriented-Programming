namespace SuperRpgGame.Characters
{
    using Attributes;

    [Enemy]
    public class Troll : Character
    {
        private const int TrollDamage = 75;
        private const int TrollHealth = 400;
        private const char TrollSymbol = 'T';

        public Troll(Position position, string name)
            : base(position, TrollSymbol, name, TrollDamage, TrollHealth)
        {
        }
    }
}
