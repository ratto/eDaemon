using eDaemon.Services;
using System.Collections.Generic;
using System.Text;

namespace eDaemon.Entities.GameWorld.Items
{
    class Armor : Item
    {
        public string prename;
        public int dexPenalty;
        public int agiPenalty;
        public List<Damage> protectionIndex = new List<Damage>();

        public Armor(int id, string name, int dexPenalty, int agiPenalty, List<Damage> protectionIndex) : base(id, name)
        {
            this.dexPenalty = dexPenalty;
            this.agiPenalty = agiPenalty;
            this.protectionIndex = protectionIndex;
        }

        public Armor(int id, string prename, string name, int dexPenalty, int agiPenalty, List<Damage> protectionIndex) : base(id, name)
        {
            this.prename = prename;
            this.dexPenalty = dexPenalty;
            this.agiPenalty = agiPenalty;
            this.protectionIndex = protectionIndex;
        }

        public Armor(int id, string name, double price, int dexPenalty, int agiPenalty, List<Damage> protectionIndex) : base(id, name, price)
        {
            this.dexPenalty = dexPenalty;
            this.agiPenalty = agiPenalty;
            this.protectionIndex = protectionIndex;
        }

        public Armor(int id, string prename, string name, double price, int dexPenalty, int agiPenalty, List<Damage> protectionIndex) : base(id, name, price)
        {
            this.dexPenalty = dexPenalty;
            this.agiPenalty = agiPenalty;
            this.protectionIndex = protectionIndex;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            
            if(this.prename != null)
            {
                sb.Append(this.prename + " ");
            }
            sb.Append(this.Name + " (");

            foreach(Damage type in protectionIndex)
            {
                sb.Append("IP " + type + ", ");
            }

            sb.Append("DEX" + this.dexPenalty + " / AGI" + this.agiPenalty + ")");

            return sb.ToString();
        }
    }
}
