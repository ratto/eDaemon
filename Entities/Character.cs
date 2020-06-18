using System;
using System.Text;

/**
* Character Class
* This is the superclass for all the characters of the game.
* Wether is a player character, a monster or a regular NPC that interacts 
* with the player, will inherit this class characteristics.
*/

namespace eDaemon.Entities
{
    class Character
    {
        // Physical attributes
        public int Strength { get; set; }
        public int Dexterity { get; private set; }
        public int Agility { get; private set; }
        public int Constitution { get; private set; }
        // Mental attributes
        public int Intelligence { get; private set; }
        public int WillPower { get; private set; }
        public int Perception { get; private set; }
        public int Charisma { get; private set; }

        protected int _hpTotal;
        protected int _hpCurrent;

        public Character(int strength, int dexterity, int agility, int constitution, int intelligence, int willPower, int perception, int charisma)
        {
            Strength = strength;
            Dexterity = dexterity;
            Agility = agility;
            Constitution = constitution;
            Intelligence = intelligence;
            WillPower = willPower;
            Perception = perception;
            Charisma = charisma;
            
            _hpTotal = (int)Math.Ceiling((double)(strength + constitution) / 2); // Total HP equals the sum of Strength and Constitution scores divided by 2
            _hpCurrent = _hpTotal;
        }

        // In Daemon RPG system the attribute modifier is 4 times the attribute score
        public int getMod(int attribute)
        {
            return attribute * 4;
        }

        // HP control
        public int getTotalHP()
        {
            return _hpTotal;
        }

        public int getCurrentHP()
        {
            return _hpCurrent;
        }

        public void increaseHP(int hp)
        {
            _hpCurrent += hp;
        }

        public void decreaseHP(int hp)
        {
            _hpCurrent -= hp;
        }
    }
}
