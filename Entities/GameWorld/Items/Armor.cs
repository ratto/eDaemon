using eDaemon.Services;
using System.Collections.Generic;

namespace eDaemon.Entities.GameWorld.Items
{
    class Armor : Item
    {
        public int dexPenalty;
        public int agiPenalty;
        public List<Damage> protectionIndex = new List<Damage>();

        public Armor(int id, string name, int dexPenalty, int agiPenalty, List<Damage> protectionIndex) : base(id, name)
        {
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
    }
}
