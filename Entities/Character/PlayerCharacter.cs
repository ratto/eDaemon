using System;
using System.Collections.Generic;
using System.Text;
using eDaemon.Entities.GameWorld.Items;

namespace eDaemon.Entities.Character
{
    class PlayerCharacter : Character
    {
        public string Name { get; }
        public int Age { get; }

        private List<Item> Backpack = new List<Item>(); // This represents the player's carried items
        

        public PlayerCharacter(string name, int age, int strength, int dexterity, int agility, int constitution, int intelligence, int willPower, int perception, int charisma) : base(strength, dexterity, agility, constitution, intelligence, willPower, perception, charisma)
        {
            Name = name;
            Age = age;
        }

        // Backpack maintenance
        public void ShowItems()
        {
            foreach(Item item in Backpack)
            {
                Console.WriteLine(item.ToString());
            }
        }

        public void StoreItem(Item item) // Put an item in the backpack
        {
            Backpack.Add(item);
        }

        public void RemoveItem(Item item) // Take out an item from the backpack
        {
            Backpack.Remove(item);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(Name);
            sb.AppendLine("Idade: " + Age);
            sb.AppendLine("--------------------------");
            sb.AppendLine("Força " + Strength + " / " + getMod(Strength));
            sb.AppendLine("Destreza " + Dexterity + " / " + getMod(Dexterity));
            sb.AppendLine("Agilidade " + Agility + " / " + getMod(Agility));
            sb.AppendLine("Constituição " + Constitution + " / " + getMod(Constitution));

            sb.AppendLine("Inteligência " + Intelligence + " / " + getMod(Intelligence));
            sb.AppendLine("Força de Vontade " + WillPower + " / " + getMod(WillPower));
            sb.AppendLine("Percepção " + Perception + " / " + getMod(Perception));
            sb.AppendLine("Carisma " + Charisma + " / " + getMod(Charisma));

            sb.AppendLine("--------------------------");
            sb.AppendLine("HP " + _hpTotal + " / " + _hpCurrent);

            return sb.ToString();
        }
    }
}
