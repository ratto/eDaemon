using eDaemonWS.Models.Skills;
<<<<<<< HEAD
=======
using System.ComponentModel.DataAnnotations;
>>>>>>> dev

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
<<<<<<< HEAD
        public ICollection<BasicSkillSet> Skills { get; set; } = new List<BasicSkillSet>();
=======
        public ICollection<BasicSkillSet> BasicSkillList { get; set; } = new List<BasicSkillSet>();
>>>>>>> dev
    }
}
