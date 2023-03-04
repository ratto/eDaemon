using eDaemonWS.Models.Skills;
using Microsoft.EntityFrameworkCore;

namespace eDaemonWS.Data
{
    public class BasicSkillContext : DbContext
    {
        public BasicSkillContext(DbContextOptions<BasicSkillContext> options) : base(options) { }

        public virtual DbSet<BasicSkill> BasicSkillList { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // modelBuilder.ApplyConfigurationsFromAssembly(typeof(BasicSkillContext).Assembly);
            modelBuilder.Entity<BasicSkill>().ToTable(nameof(BasicSkill));
        }
    }
}
