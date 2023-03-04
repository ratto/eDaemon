using System.ComponentModel.DataAnnotations;

namespace eDaemonWS.Models.Characters
{
    public abstract class Character
    {
        [Key]
        public long Id { get; set; }
        public short Constitution { get; set; }
        public short Strength { get; set; }
        public short Dexterity { get; set; }
        public short Agility { get; set; }
        public short Intelligence { get; set; }
        public short WillPower { get; set; }
        public short Perception { get; set; }
        public short Charisma { get; set; }

        public ICollection<BasicSkillSet> Skills { get; set; } = new List<BasicSkillSet>();
    }
}
