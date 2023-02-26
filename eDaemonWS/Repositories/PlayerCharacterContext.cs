using eDaemonWS.Models.Characters;
using Microsoft.EntityFrameworkCore;

namespace eDaemonWS.Repositories
{
    public class PlayerCharacterContext : DbContext
    {
        public PlayerCharacterContext(DbContextOptions<PlayerCharacterContext> options) : base(options) { }

        public DbSet<PlayerCharacter> PlayerCharacters { get; set; } = null!;
    }
}
