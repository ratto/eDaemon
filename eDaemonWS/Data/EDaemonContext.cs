using eDaemonWS.Models.Characters;
using eDaemonWS.Models.Skills;
using Microsoft.EntityFrameworkCore;

namespace eDaemonWS.Data
{
    public class EDaemonContext : DbContext
    {
        public EDaemonContext(DbContextOptions<EDaemonContext> options) : base(options) { }

        public virtual DbSet<PlayerCharacter> PlayerCharacters { get; set; }
        public virtual DbSet<BasicSkill> BasicSkill { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(BasicSkillContext).Assembly);
        }
    }
}
