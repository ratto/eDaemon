/*
 * Backpack Class
 * This is a item storage for players only. It can be used by 
 * each player character (for mmorpgs or hack'n'slash game 
 * styles) or by a player controlled company or party (for 
 * tactical or RTS game types).
 * 
 * No non-player character should use this class as they use 
 * a different class to represent their "carried stuff". 
 * Monsters and other NPC should use the Drop class to 
 * manipulate the treasure droped from a NPC when it dies.
 */
using System;
using System.Collections.Generic;
using eDaemon.Entities.GameWorld.Items;

namespace eDaemon.Entities.Character
{
    class Backpack
    {
        private int gold;
        private List<Item> items = new List<Item>();

        public Backpack()
        {
        }

        public int getGold()
        {
            return this.gold;
        }

        public void IncreaseGold(int amount)
        {
            this.gold += amount;
        }

        public void DecreaseGold(int amount)
        {
            this.gold -= amount;
        }

        public void ShowItems()
        {
            foreach(Item i in items)
            {
                Console.WriteLine(i.ToString());
            }
        }

        public void HoldItem(Item item)
        {
            items.Add(item);
        }

        public void RemoveItem(Item item)
        {
            items.Remove(item);
        }
    }
}
