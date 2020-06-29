/*
 * The Equipment Class
 * Equipment is a kind of item that a character may wear 
 * or equip it on so he can use it or make use of it's 
 * benefits.
 * 
 * The armor in Daemon RPG system is treated as a complete 
 * piece. You can only buy a complete full plate armor to 
 * get the IP 6 increase benefit. You can not buy just an 
 * iron helmet nor the breast plate.
 * 
 * In eDaemon we treat the armor system the same way. Feel 
 * free to change this settings to attend your game needs.
 */

using System.Collections.Generic;
using eDaemon.Services;

namespace eDaemon.Entities.GameWorld.Items
{
    abstract class Equipment : Item
    {
        protected List<DamageType> SpecialTraits = new List<DamageType>();

        // Empty constructor without pricing
        protected Equipment(int id, string name) : base(id, name)
        {
        }

        // Empty constructor with pricing
        protected Equipment(int id, string name, double price) : base(id, name, price)
        {
        }

        protected Equipment(int id, string name, List<DamageType> specialTraits) : base(id, name)
        {
            SpecialTraits = specialTraits;
        }

        // Add an special feature to the equipment
        public void ImbueWithSpecialTrait(DamageType type)
        {
            SpecialTraits.Add(type);
        }
    }
}
