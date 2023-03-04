using eDaemonWS.Models.Enums;

namespace eDaemonWS.Models.Skills
{
    public class BasicSkill
    {
        public long Id { get; set; }
        public string? Name { get; set; }
        public AttributeEnum SkillAttribute { get; set; }
    }
}
