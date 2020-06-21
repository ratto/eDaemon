/*
 * Weapon Class
 * Fighters, paladins, rogues, rangers and even the mages 
 * use weapons. They are the key players for direct, physical 
 * (and sometimes magical) damage effects.
 */

using eDaemon.Services;
using System.Collections.Generic;
using System.Text;

namespace eDaemon.Entities.GameWorld.Items
{
    class Weapon : Item
    {
        public int iniciative;
        public int[] reach;
        public string prename;
        public List<Damage> weaponDamage = new List<Damage>();

        // Common meelee weapon
        public Weapon(int id, string name, int iniciative, List<Damage> weaponDamage) : base(id, name)
        {
            this.iniciative = iniciative;
            this.weaponDamage = weaponDamage;
        }

        // Common ranged weapon
        public Weapon(int id, string name, int iniciative, int[] reach, List<Damage> weaponDamage) : base(id, name)
        {
            this.iniciative = iniciative;
            this.reach = reach;
            this.weaponDamage = weaponDamage;
        }

        // Special meelee weapon
        public Weapon(int id, string prename, string name, int iniciative, List<Damage> weaponDamage) : base(id, name)
        {
            this.prename = prename;
            this.iniciative = iniciative;
            this.weaponDamage = weaponDamage;
        }

        // Special ranged weapon
        public Weapon(int id, string prename, string name, int iniciative, int[] reach, List<Damage> weaponDamage) : base(id, name)
        {
            this.prename = prename;
            this.iniciative = iniciative;
            this.reach = reach;
            this.weaponDamage = weaponDamage;
        }

        // Common meelee weapon with price
        public Weapon(int id, string name, double price, int iniciative, List<Damage> weaponDamage) : base(id, name, price)
        {
            this.iniciative = iniciative;
            this.weaponDamage = weaponDamage;
        }

        // Common ranged weapon with price
        public Weapon(int id, string name, double price, int iniciative, int[] reach, List<Damage> weaponDamage) : base(id, name, price)
        {
            this.iniciative = iniciative;
            this.reach = reach;
            this.weaponDamage = weaponDamage;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            // test if it has special feature
            if(this.prename != null)
            {
                sb.Append(this.prename + " ");
            }
            sb.Append(this.Name + " (");

            foreach(Damage type in weaponDamage)
            {
                sb.Append(type.ToString() + ", ");
            }

            sb.Append(this.iniciative);
            // test if it is a ranged weapon
            if(this.reach != null)
            {
                sb.Append(", Alcance " + reach[0] + "/" + reach[1]);
            }
            sb.Append(")");

            return sb.ToString();
        }
    }
}
