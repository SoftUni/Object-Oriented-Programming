namespace SuperRpgGame.Engine
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Reflection;
    using System.Text;
    using Attributes;
    using Characters;
    using Exceptions;
    using Interfaces;
    using Items;

    public class SuperEngine
    {
        public const int MapWidth = 5;
        public const int MapHeight = 5;

        private const int InitialNumberOfEnemies = 2;
        private const int InitialNumberOfBeers = 5;

        private static readonly Random Rand = new Random();

        private readonly IInputReader reader;
        private readonly IRenderer renderer;

        private readonly string[] characterNames =
        {
            "Alinar",
            "Zandro",
            "Llombaerth",
            "Inchel",
            "Aymer",
            "Folre",
            "Nyvorlas",
            "Khuumal",
            "Intevar",
            "Nopos"
        };

        private readonly IList<GameObject> characters;
        private readonly IList<GameObject> items;
        private IPlayer player;

        public SuperEngine(IInputReader reader, IRenderer renderer)
        {
            this.reader = reader;
            this.renderer = renderer;
            this.characters = new List<GameObject>();
            this.items = new List<GameObject>();
        }

        public bool IsRunning { get; private set; }

        public void Run()
        {
            this.IsRunning = true;

            var playerName = this.GetPlayerName();
            PlayerRace race = this.GetPlayerRace();

            this.player = new Player(new Position(0, 0), 'P', playerName, race);

            this.PopulateEnemies();
            this.PopulateItems();

            while (this.IsRunning)
            {
                string command = this.reader.ReadLine();

                try
                {
                    this.ExecuteCommand(command);
                }
                catch (ObjectOutOfBoundsException ex)
                {
                    this.renderer.WriteLine(ex.Message);
                }
                catch (NotEnoughBeerException ex)
                {
                    this.renderer.WriteLine(ex.Message);
                }
                catch (Exception ex)
                {
                    this.renderer.WriteLine(ex.Message);
                }

                if (this.characters.Count == 0)
                {
                    this.IsRunning = false;
                    this.renderer.WriteLine("Valar morgulis!");
                }
            }
        }

        private void ExecuteCommand(string command)
        {
            switch (command)
            {
                case "help":
                    this.ExecuteHelpCommand();
                    break;
                case "map":
                    this.PrintMap();
                    break;
                case "left":
                case "right":
                case "up":
                case "down":
                    this.MovePlayer(command);
                    break;
                case "status":
                    this.ShowStatus();
                    break;
                case "heal":
                    this.player.Heal();
                    this.renderer.WriteLine("Healed!");
                    break;
                case "clear":
                    this.renderer.Clear();
                    break;
                case "exit":
                    this.IsRunning = false;
                    this.renderer.WriteLine("Bye, noob!");
                    break;
                default:
                    throw new ArgumentException("Unknown command", "command");
            }
        }

        private void ShowStatus()
        {
            this.renderer.WriteLine(this.player.ToString());

            this.renderer.WriteLine(
                "Number of enemies left: {0}", 
                this.characters.Count);
        }

        private void MovePlayer(string command)
        {
            this.player.Move(command);

            ICharacter enemy =
                this.characters.Cast<ICharacter>()
                .FirstOrDefault(
                    e => e.Position.X == this.player.Position.X 
                        && e.Position.Y == this.player.Position.Y 
                        && e.Health > 0);

            if (enemy != null)
            {
                this.EnterBattle(enemy);
                return;
            }

            Item beer =
                this.items.Cast<Item>()
                .FirstOrDefault(
                    e => e.Position.X == this.player.Position.X 
                        && e.Position.Y == this.player.Position.Y 
                        && e.ItemState == ItemState.Available);

            if (beer != null)
            {
                this.player.AddItemToInventory(beer);
                beer.ItemState = ItemState.Collected;
                this.renderer.WriteLine("Beer collected!");
            }
        }

        private void EnterBattle(ICharacter enemy)
        {
            this.player.Attack(enemy);

            if (enemy.Health <= 0)
            {
                this.renderer.WriteLine("Enemy killed!");
                this.characters.Remove(enemy as GameObject);
                return;
            }

            enemy.Attack(this.player);

            if (this.player.Health <= 0)
            {
                this.IsRunning = false;
                this.renderer.WriteLine("You dead!");
            }
        }

        private void PrintMap()
        {
            StringBuilder sb = new StringBuilder();

            for (int row = 0; row < MapHeight; row++)
            {
                for (int col = 0; col < MapWidth; col++)
                {
                    if (this.player.Position.X == col && this.player.Position.Y == row)
                    {
                        sb.Append('P');
                        continue;
                    }

                    var character =
                         this.characters
                         .Cast<ICharacter>()
                         .FirstOrDefault(c => c.Position.X == col 
                             && c.Position.Y == row 
                             && c.Health > 0);

                    var item = this.items
                        .Cast<Item>()
                        .FirstOrDefault(c => c.Position.X == col 
                            && c.Position.Y == row 
                            && c.ItemState == ItemState.Available);

                    if (character == null && item == null)
                    {
                        sb.Append('.');
                    }
                    else if (character != null)
                    {
                        var ch = character as GameObject;
                        sb.Append(ch.ObjectSymbol);
                    }
                    else
                    {
                        sb.Append(item.ObjectSymbol);
                    }
                }

                sb.AppendLine();
            }

            this.renderer.WriteLine(sb.ToString());
        }

        private void ExecuteHelpCommand()
        {
            string helpInfo = File.ReadAllText("../../HelpInfo.txt");

            this.renderer.WriteLine(helpInfo);
        }

        private PlayerRace GetPlayerRace()
        {
            this.renderer.WriteLine("Choose a race:");
            this.renderer.WriteLine("1. Elf (damage: 300, health: 100)");
            this.renderer.WriteLine("2. Archangel (damage: 250, health: 150)");
            this.renderer.WriteLine("3. Hulk (damage: 350, health: 75)");
            this.renderer.WriteLine("4. Alcoholic (damage: 200, health: 200)");

            string choice = this.reader.ReadLine();

            string[] validChoises = { "1", "2", "3", "4" };

            while (!validChoises.Contains(choice))
            {
                this.renderer.WriteLine("Invalid choice of race, please re-enter.");
                choice = this.reader.ReadLine();
            }

            PlayerRace race = (PlayerRace)int.Parse(choice);

            return race;
        }

        private string GetPlayerName()
        {
            this.renderer.WriteLine("Please enter your name:");

            string playerName = this.reader.ReadLine();
            while (string.IsNullOrWhiteSpace(playerName))
            {
                this.renderer.WriteLine("Player name cannot be empty. Please re-enter.");
                playerName = this.reader.ReadLine();
            }

            return playerName;
        }

        private void PopulateItems()
        {
            for (int i = 0; i < InitialNumberOfBeers; i++)
            {
                Item beer = this.CreateItem();
                this.items.Add(beer);
            }
        }

        private Item CreateItem()
        {
            int currentX = Rand.Next(1, MapWidth);
            int currentY = Rand.Next(1, MapHeight);

            bool containsEnemy = this.characters
                .Any(e => e.Position.X == currentX && e.Position.Y == currentY);

            bool containsBeer = this.items
                .Any(e => e.Position.X == currentX && e.Position.Y == currentY);

            while (containsEnemy || containsBeer)
            {
                currentX = Rand.Next(1, MapWidth);
                currentY = Rand.Next(1, MapHeight);

                containsEnemy = this.characters
                .Any(e => e.Position.X == currentX && e.Position.Y == currentY);

                containsBeer = this.items
                .Any(e => e.Position.X == currentX && e.Position.Y == currentY);
            }

            int beerType = Rand.Next(0, 3);

            BeerSize beerSize;

            switch (beerType)
            {
                case 0:
                    beerSize = BeerSize.Small;
                    break;
                case 1:
                    beerSize = BeerSize.Medium;
                    break;
                case 2:
                    beerSize = BeerSize.Large;
                    break;
                default:
                    throw new ArgumentOutOfRangeException("beerType", "Invalid beer type.");
            }

            return new Beer(new Position(currentX, currentY), beerSize);
        }

        private void PopulateEnemies()
        {
            for (int i = 0; i < InitialNumberOfEnemies; i++)
            {
                GameObject enemy = this.CreateEnemy();
                this.characters.Add(enemy);
            }
        }

        private GameObject CreateEnemy()
        {
            int currentX = Rand.Next(1, MapWidth);
            int currentY = Rand.Next(1, MapHeight);

            bool containsEnemy = this.characters
                .Any(e => e.Position.X == currentX && e.Position.Y == currentY);

            while (containsEnemy)
            {
                currentX = Rand.Next(1, MapWidth);
                currentY = Rand.Next(1, MapHeight);

                containsEnemy = this.characters
                .Any(e => e.Position.X == currentX && e.Position.Y == currentY);
            }

            int nameIndex = Rand.Next(0, this.characterNames.Length);
            string name = this.characterNames[nameIndex];

            var enemyTypes = Assembly.GetExecutingAssembly()
                .GetTypes()
                .Where(t => t.CustomAttributes
                    .Any(a => a.AttributeType == typeof(EnemyAttribute)))
                    .ToArray();

            var type = enemyTypes[Rand.Next(0, enemyTypes.Length)];

            GameObject character = Activator
                .CreateInstance(type, new Position(currentX, currentY), name) as GameObject;

            return character;
        }
    }
}
