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
    class Weapon : Equipment
    {
        public int Iniciative { get; private set; }
        public int[] Reach { get; private set; }

        public List<Damage> WeaponDamage = new List<Damage>();

        // Common meelee weapon
        public Weapon(int id, string name, int iniciative, List<Damage> weaponDamage) : base(id, name)
        {
            Iniciative = iniciative;
            WeaponDamage = weaponDamage;
        }

        // Common ranged weapon
        public Weapon(int id, string name, int iniciative, int[] reach, List<Damage> weaponDamage) : base(id, name)
        {
            Iniciative = iniciative;
            Reach = reach;
            WeaponDamage = weaponDamage;
        }

        // Special meelee weapon
        public Weapon(int id, string name, List<DamageType> specialTraits, int iniciative, List<Damage> weaponDamage) : base(id, name, specialTraits)
        {
            Iniciative = iniciative;
            WeaponDamage = weaponDamage;
        }

        // Special ranged weapon
        public Weapon(int id, string name, List<DamageType> specialTraits, int iniciative, int[] reach, List<Damage> weaponDamage) : base(id, name, specialTraits)
        {
            Iniciative = iniciative;
            Reach = reach;
            WeaponDamage = weaponDamage;
        }

        // Common meelee weapon with price
        public Weapon(int id, string name, double price, int iniciative, List<Damage> weaponDamage) : base(id, name, price)
        {
            Iniciative = iniciative;
            WeaponDamage = weaponDamage;
        }

        // Common ranged weapon with price
        public Weapon(int id, string name, double price, int iniciative, int[] reach, List<Damage> weaponDamage) : base(id, name, price)
        {
            Iniciative = iniciative;
            Reach = reach;
            WeaponDamage = weaponDamage;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            // test if it has special feature
            if (SpecialTraits.Count != 0)
            {
                foreach(DamageType trait in SpecialTraits)
                {
                    sb.Append(trait.ToString() + " ");
                }
            }
            sb.Append(Name + " (");

            foreach (Damage type in WeaponDamage)
            {
                sb.Append(type.ToString() + ", ");
            }

            sb.Append(Iniciative);
            // test if it is a ranged weapon
            if (Reach != null)
            {
                sb.Append(", Alcance " + Reach[0] + "/" + Reach[1]);
            }
            sb.Append(")");

            return sb.ToString();
        }
    }
}
