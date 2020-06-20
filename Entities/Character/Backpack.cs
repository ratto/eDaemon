/*
 * Backpack Class
 * This is a item storage for players only. It can be used by 
 * each player character (for mmorpgs or hack'n'slash game 
 * styles) or by a player controlled company or party (for 
 * tactical or RTS game types).
 * 
 * No non-player character should use this class as they use 
 * a different class to represent their "carried stuff". 
 * Monsters and other NPC should use the Drop class to 
 * manipulate the treasure droped from a NPC when it dies.
 */

namespace eDaemon.Entities.Character
{
    class Backpack
    {
        public int gold;

    }
}
