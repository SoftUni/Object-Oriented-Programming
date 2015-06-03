using System;

namespace CustomExceptions
{
    public class TankBattle
    {
        static void Main()
        {
            try
            {
                var germanTank = new Tank(300);
                var russianTank = new Tank(200);
                ExecuteAttack(germanTank, russianTank);
            }
            catch (TankException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private static void ExecuteAttack(Tank tankA, Tank tankB)
        {
            while (tankB.Health > 0)
            {
                tankA.Shoot(tankB);
            }
        }
    }
}
