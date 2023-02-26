using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using eDaemonWS.Models.Characters;
using eDaemonWS.Repositories;

namespace eDaemonWS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlayerCharactersController : ControllerBase
    {
        private readonly PlayerCharacterContext _context;

        public PlayerCharactersController(PlayerCharacterContext context)
        {
            _context = context;
        }

        // GET: api/PlayerCharacters
        [HttpGet]
        public async Task<ActionResult<IEnumerable<PlayerCharacter>>> GetPlayerCharacters()
        {
            return await _context.PlayerCharacters.ToListAsync();
        }

        // GET: api/PlayerCharacters/5
        [HttpGet("{id}")]
        public async Task<ActionResult<PlayerCharacter>> GetPlayerCharacter(long id)
        {
            var playerCharacter = await _context.PlayerCharacters.FindAsync(id);

            if (playerCharacter == null)
            {
                return NotFound();
            }

            return playerCharacter;
        }

        // PUT: api/PlayerCharacters/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPlayerCharacter(long id, PlayerCharacter playerCharacter)
        {
            if (id != playerCharacter.Id)
            {
                return BadRequest();
            }

            _context.Entry(playerCharacter).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PlayerCharacterExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/PlayerCharacters
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<PlayerCharacter>> PostPlayerCharacter(PlayerCharacter playerCharacter)
        {
            _context.PlayerCharacters.Add(playerCharacter);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetPlayerCharacter), new { id = playerCharacter.Id }, playerCharacter);
        }

        // DELETE: api/PlayerCharacters/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePlayerCharacter(long id)
        {
            var playerCharacter = await _context.PlayerCharacters.FindAsync(id);
            if (playerCharacter == null)
            {
                return NotFound();
            }

            _context.PlayerCharacters.Remove(playerCharacter);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool PlayerCharacterExists(long id)
        {
            return _context.PlayerCharacters.Any(e => e.Id == id);
        }
    }
}
