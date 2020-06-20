/**
* Character Class
* This is the superclass for all the characters of the game.
* Wether is a player character, a monster or a regular NPC that interacts 
* with the player, will inherit this class characteristics.
*/

using System;
using System.Collections.Generic;

namespace eDaemon.Entities.Character
{
    class Character
    {
        // Physical attributes
        public int Strength { get; protected set; }
        public int Dexterity { get; protected set; }
        public int Agility { get; protected set; }
        public int Constitution { get; protected set; }
        // Mental attributes
        public int Intelligence { get; protected set; }
        public int WillPower { get; protected set; }
        public int Perception { get; protected set; }
        public int Charisma { get; protected set; }
        public List<CombatSkill> CombatSkills = new List<CombatSkill>();
        public List<Skill> CommonSkills = new List<Skill>();

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

        public int useGreaterMod(int attribute1, int attribute2)
        {
            if(attribute1 > attribute2)
            {
                return attribute1;
            }
            else
            {
                return attribute2;
            }
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
