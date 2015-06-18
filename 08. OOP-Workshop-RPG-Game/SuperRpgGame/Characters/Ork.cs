namespace SuperRpgGame.Characters
{
    using Attributes;

    [Enemy]
    public class Ork : Character
    {
        private const int OrkDamage = 100;
        private const int OrkHealth = 150;
        private const char OrkSymbol = 'O';

        public Ork(Position position, string name)
            : base(position, OrkSymbol, name, OrkDamage, OrkHealth)
        {
        }
    }
}
