using eDaemonWS.Models.Skills;
using System.ComponentModel.DataAnnotations.Schema;

namespace eDaemonWS.Models.Characters
{
    public class BasicSkillSet
    {
        [ForeignKey("Id")]
        public BasicSkill? BasicSkills { get; set; }
        public short Score { get; set; }
    }
}
