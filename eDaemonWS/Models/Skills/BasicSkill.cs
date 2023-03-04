using eDaemonWS.Models.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace eDaemonWS.Models.Skills
{
    [Table("BasicSkill")]
    public class BasicSkill
    {
        [Key]
        public long Id { get; set; }
        public string? Name { get; set; }
        public AttributeEnum SkillAttribute { get; set; }
    }
}
