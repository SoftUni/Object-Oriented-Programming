namespace SuperRpgGame.Characters
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Exceptions;
    using Interfaces;
    using Items;

    public class Player : Character, IPlayer
    {
        private readonly List<Item> inventory;
 
        public Player(Position position, char objectSymbol, string name, PlayerRace race)
            : base(position, objectSymbol, name, 0, 0)
        {
            this.Race = race;
            this.inventory = new List<Item>();
            this.SetPlayerStats();
        }

        public PlayerRace Race { get; private set; }

        public IEnumerable<Item> Inventory
        {
            get
            {
                return this.inventory;
            }
        }

        public void Move(string direction)
        {
            switch (direction)
            {
                case "up":
                    this.Position = new Position(this.Position.X, this.Position.Y - 1);
                    break;
                case "down":
                    this.Position = new Position(this.Position.X, this.Position.Y + 1);
                    break;
                case "right":
                    this.Position = new Position(this.Position.X + 1, this.Position.Y);
                    break;
                case "left":
                    this.Position = new Position(this.Position.X - 1, this.Position.Y);
                    break;
                default:
                    throw new ArgumentException("Invalid direction.", "direction");
            }
        }

        public void AddItemToInventory(Item item)
        {
            this.inventory.Add(item);
        }

        public void Heal()
        {
            var beer = this.inventory.FirstOrDefault() as Beer;

            if (beer == null)
            {
                throw new NotEnoughBeerException("Not enough beer!!!");
            }

            this.Health += beer.HealthRestore;
            this.inventory.Remove(beer);
        }

        public override string ToString()
        {
            return string.Format(
                "Player {0} ({1}): Damage ({2}), Health ({3}), Number of beers: {4}", 
                this.Name, 
                this.Race, 
                this.Damage, 
                this.Health, 
                this.Inventory.Count());
        }

        private void SetPlayerStats()
        {
            switch (this.Race)
            {
                case PlayerRace.Elf:
                    this.Damage = 300;
                    this.Health = 100;
                    break;
                case PlayerRace.Archangel:
                    this.Damage = 250;
                    this.Health = 150;
                    break;
                case PlayerRace.Hulk:
                    this.Damage = 350;
                    this.Health = 75;
                    break;
                case PlayerRace.Alcoholic:
                    this.Damage = 200;
                    this.Health = 200;
                    break;
                default:
                    throw new ArgumentException("Unknown player race.");
            }
        }
    }
}
