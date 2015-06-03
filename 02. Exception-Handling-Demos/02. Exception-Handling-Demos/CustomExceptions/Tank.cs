namespace CustomExceptions
{
    public class Tank
    {
        private const int ShellDamage = 40;

        public Tank(int health)
        {
            this.Health = 200;
            this.Shells = 3;
        }

        public int Health { get; set; }

        public int Shells { get; private set; }

        public void Shoot(Tank enemy)
        {
            if (this.Shells == 0)
            {
                throw new TankException("Not enough shells to shoot");
            }

            enemy.Health -= ShellDamage;
            this.Shells--;
        }
    }
}
