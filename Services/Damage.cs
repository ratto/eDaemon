/*
 * Damage Class
 * Everything that can do harm to a character will use
 * this class. A character in Daemon system can receive 
 * damage from different sources: when it gets hit by a 
 * weapon, or gets hit by some fireball spell or even 
 * if a character falls from a rooftop.
 */

namespace eDaemon.Services
{
    class Damage
    {
        public DamageType type;
        public int minDamage;
        public int maxDamage;
        public int damageScore;

        // This overload is used when you need only one damage score, as when used by shield to indicate it's Protection Index
        public Damage(DamageType type, int damageScore)
        {
            this.type = type;
            this.damageScore = damageScore;
        }

        // This overload is used whenever a die is used to apply dammage, like in weapon damage
        public Damage(DamageType type, int minDamage, int maxDamage) : this(type, minDamage)
        {
            this.maxDamage = maxDamage;
        }
    }
}
