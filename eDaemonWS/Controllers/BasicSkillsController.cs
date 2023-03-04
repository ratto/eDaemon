using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using eDaemonWS.Data;
using eDaemonWS.Models.Skills;

namespace eDaemonWS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BasicSkillsController : ControllerBase
    {
        private readonly BasicSkillContext _context;

        public BasicSkillsController(BasicSkillContext context)
        {
            _context = context;
        }

        // GET: api/BasicSkills
        [HttpGet]
        public async Task<ActionResult<IEnumerable<BasicSkill>>> GetBasicSkillList()
        {
            return await _context.BasicSkillList.ToListAsync();
        }

        // GET: api/BasicSkills/5
        [HttpGet("{id}")]
        public async Task<ActionResult<BasicSkill>> GetBasicSkill(long id)
        {
            var basicSkill = await _context.BasicSkillList.FindAsync(id);

            if (basicSkill == null)
            {
                return NotFound();
            }

            return basicSkill;
        }

        // PUT: api/BasicSkills/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutBasicSkill(long id, BasicSkill basicSkill)
        {
            if (id != basicSkill.Id)
            {
                return BadRequest();
            }

            _context.Entry(basicSkill).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BasicSkillExists(id))
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

        // POST: api/BasicSkills
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<BasicSkill>> PostBasicSkill(BasicSkill basicSkill)
        {
            _context.BasicSkillList.Add(basicSkill);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetBasicSkill), new { id = basicSkill.Id }, basicSkill);
        }

        // DELETE: api/BasicSkills/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBasicSkill(long id)
        {
            var basicSkill = await _context.BasicSkillList.FindAsync(id);
            if (basicSkill == null)
            {
                return NotFound();
            }

            _context.BasicSkillList.Remove(basicSkill);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool BasicSkillExists(long id)
        {
            return _context.BasicSkillList.Any(e => e.Id == id);
        }
    }
}
