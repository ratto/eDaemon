using eDaemon.Services;
using System.Collections.Generic;
using System.Text;

namespace eDaemon.Entities.GameWorld.Items
{
    class Armor : Equipment
    {
        public int DexPenalty { get; private set; }
        public int AgiPenalty { get; private set; }

        public int dexPenalty;
        public int agiPenalty;
        public List<Damage> ProtectionIndex = new List<Damage>();

        // Common armor without pricing
        public Armor(int id, string name, int dexPenalty, int agiPenalty, List<Damage> protectionIndex) : base(id, name)
        {
            DexPenalty = dexPenalty;
            AgiPenalty = agiPenalty;
            ProtectionIndex = protectionIndex;
        }

        // Special protection armor
        public Armor(int id, string name, List<DamageType> specialTraits, int dexPenalty, int agiPenalty, List<Damage> protectionIndex) : base(id, name, specialTraits)
        {
            DexPenalty = dexPenalty;
            AgiPenalty = agiPenalty;
            ProtectionIndex = protectionIndex;
        }

        // Common armor with pricing
        public Armor(int id, string name, double price, int dexPenalty, int agiPenalty, List<Damage> protectionIndex) : base(id, name, price)
        {
            DexPenalty = dexPenalty;
            AgiPenalty = agiPenalty;
            ProtectionIndex = protectionIndex;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            // test if it has special feature
            if (SpecialTraits.Count != 0)
            {
                foreach (DamageType trait in SpecialTraits)
                {
                    sb.Append(trait.ToString() + " ");
                }
            }

            sb.Append(Name + " (");

            foreach(Damage type in ProtectionIndex)
            {
                sb.Append("IP " + type + ", ");
            }

            sb.Append("DEX" + DexPenalty + " / AGI" + AgiPenalty + ")");

            return sb.ToString();
        }
    }
}
