namespace SuperRpgGame.Characters
{
    using System;
    using Interfaces;

    public abstract class Character : GameObject, ICharacter
    {
        private string name;

        protected Character(Position position, char objectSymbol, string name, int damage, int health)
            : base(position, objectSymbol)
        {
            this.Damage = damage;
            this.Health = health;
            this.Name = name;
        }

        public int Damage { get; set; }

        public int Health { get; set; }

        public string Name
        {
            get
            {
                return this.name;
            }

            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("name", "Name cannot be null, empty or whitespace.");
                }

                this.name = value;
            }
        }

        public void Attack(ICharacter enemy)
        {
            enemy.Health -= this.Damage;
        }
    }
}
