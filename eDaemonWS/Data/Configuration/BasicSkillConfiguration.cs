using eDaemonWS.Models.Enums;
using eDaemonWS.Models.Skills;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace eDaemonWS.Data.Configuration
{
    public class BasicSkillConfiguration : IEntityTypeConfiguration<BasicSkill>
    {
        public void Configure(EntityTypeBuilder<BasicSkill> builder)
        {
            builder.Property(b => b.SkillAttribute).HasConversion(c => c.ToString(), c => Enum.Parse<AttributeEnum>(c));
        }
    }
}
