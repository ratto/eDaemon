using eDaemonWS.Models.Enums;
<<<<<<< HEAD

namespace eDaemonWS.Models.Skills
{
    public class BasicSkill
    {
=======
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace eDaemonWS.Models.Skills
{
    [Table("BasicSkill")]
    public class BasicSkill
    {
        [Key]
>>>>>>> dev
        public long Id { get; set; }
        public string? Name { get; set; }
        public AttributeEnum SkillAttribute { get; set; }
    }
}
