/*
 * Character's Combat Skill Class
 * 
 * In Daemon system every character has some combat skill.
 * Even that merchant NPC that flees at the first sign of 
 * battle can defend himself if cornered.
 * 
 * Different from other skill, like listen or spot, combat 
 * skills commonly has two distinct scores: attack and 
 * defense. Bows and ranged-only weapons have only attack 
 * score and shield use (mostly) use defense score.
 */

namespace eDaemon.Entities.Character
{
    class CombatSkill
    {
        public string name;
        public int attack;
        public int defense;

        public CombatSkill()
        {
        }

        public CombatSkill(string name, int attack, int defense)
        {
            this.name = name;
            this.attack = attack;
            this.defense = defense;
        }

        public override string ToString()
        {
            return name + " " + attack + " / " + defense;
        }
    }
}
