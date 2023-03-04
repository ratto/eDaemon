using eDaemonWS.Models.Characters;
using eDaemonWS.Models.Skills;
using Microsoft.EntityFrameworkCore;

namespace eDaemonWS.Data
{
    public class PlayerCharacterContext : DbContext
    {
        public PlayerCharacterContext(DbContextOptions<PlayerCharacterContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BasicSkill>().ToTable(nameof(BasicSkill));
        }

        public DbSet<PlayerCharacter> PlayerCharacters { get; set; } = null!;
    }
}
