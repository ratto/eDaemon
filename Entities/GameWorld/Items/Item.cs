/*
 * Item Class
 * Every item will be covered by this class
 */

namespace eDaemon.Entities.GameWorld.Items
{
    abstract class Item
    {
        public int Id { get; }
        public string Name { get; private set; }
        public double Price { get; set; }

        public Item(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public Item(int id, string name, double price) : this(id, name)
        {
            Price = price;
        }

        public void changeName(string name)
        {
            Name = name;
        }
    }
}
