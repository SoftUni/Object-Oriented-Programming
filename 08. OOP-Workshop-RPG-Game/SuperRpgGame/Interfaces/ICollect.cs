namespace SuperRpgGame.Interfaces
{
    using System.Collections.Generic;
    using Items;

    public interface ICollect
    {
        IEnumerable<Item> Inventory { get; }

        void AddItemToInventory(Item item);
    }
}
