using eDaemonWS.Models.Skills;
<<<<<<< HEAD
=======
using System.ComponentModel.DataAnnotations.Schema;
>>>>>>> dev

namespace eDaemonWS.Models.Characters
{
    public class BasicSkillSet
    {
<<<<<<< HEAD
        public BasicSkill? Skill { get; set; }
=======
        [ForeignKey("Id")]
        public BasicSkill? BasicSkills { get; set; }
>>>>>>> dev
        public short Score { get; set; }
    }
}
