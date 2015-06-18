namespace SuperRpgGame.Interfaces
{
    public interface IAttack
    {
        int Damage { get; set; }

        void Attack(ICharacter enemy);
    }
}
