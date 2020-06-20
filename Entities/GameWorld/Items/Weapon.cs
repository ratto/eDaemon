/*
 * Weapon Class
 * Fighters, paladins, rogues, rangers and even the mages 
 * use weapons. They are the key players for direct, physical 
 * (and sometimes magical) damage effects.
 */

using eDaemon.Services;
using System.Collections.Generic;

namespace eDaemon.Entities.GameWorld.Items
{
    class Weapon : Item
    {
        public int iniciative;
        public int[] reach;
        public List<Damage> weaponDamage = new List<Damage>();

        public Weapon(int id, string name, int iniciative, int[] reach, List<Damage> weaponDamage) : base(id, name)
        {
            this.iniciative = iniciative;
            this.reach = reach;
            this.weaponDamage = weaponDamage;
        }

        public Weapon(int id, string name, double price, int iniciative, int[] reach, List<Damage> weaponDamage) : base(id, name, price)
        {
            this.iniciative = iniciative;
            this.reach = reach;
            this.weaponDamage = weaponDamage;
        }
    }
}
