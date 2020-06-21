/*
 * Damage Class
 * Everything that can do harm to a character will use
 * this class. A character in Daemon system can receive 
 * damage from different sources: when it gets hit by a 
 * weapon, or gets hit by some fireball spell or even 
 * if a character falls from a rooftop.
 */

using System;
using System.Globalization;
using System.Text;

namespace eDaemon.Services
{
    class Damage
    {
        public DamageType type;
        public int minDamage;
        public int maxDamage;
        public int damageScore = 0;

        // This overload is used when you need only one damage score, as when used by shield to indicate it's Protection Index
        public Damage(DamageType type, int damageScore)
        {
            this.type = type;
            this.damageScore = damageScore;
        }

        // This overload is used whenever a die is used to apply dammage, like in weapon damage
        public Damage(DamageType type, int minDamage, int maxDamage)
        {
            this.type = type;
            this.minDamage = minDamage;
            this.maxDamage = maxDamage;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            // test if it has just one or two damage scores
            if (damageScore != 0)
            {
                sb.Append(damageScore);
            }
            else
            {
                sb.Append(minDamage + "-" + maxDamage);
            }
        
            sb.Append(" " + this.type);

            return sb.ToString();
        }

        private class nullable
        {
        }
    }
}
