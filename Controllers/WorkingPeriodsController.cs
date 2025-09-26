using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using HiredProject.DbContexts;
using HiredProject.Domains;

namespace HiredProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WorkingPeriodsController : ControllerBase
    {
        private readonly HiredDbContext _context;

        public WorkingPeriodsController(HiredDbContext context)
        {
            _context = context;
        }

        // GET: api/WorkingPeriods
        [HttpGet]
        public async Task<ActionResult<IEnumerable<WorkingPeriod>>> GetEmploymentHistories()
        {
            return await _context.EmploymentHistories.ToListAsync();
        }

        // GET: api/WorkingPeriods/5
        [HttpGet("{id}")]
        public async Task<ActionResult<WorkingPeriod>> GetWorkingPeriod(Guid id)
        {
            var workingPeriod = await _context.EmploymentHistories.FindAsync(id);

            if (workingPeriod == null)
            {
                return NotFound();
            }

            return workingPeriod;
        }

        // PUT: api/WorkingPeriods/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutWorkingPeriod(Guid id, WorkingPeriod workingPeriod)
        {
            if (id != workingPeriod.id)
            {
                return BadRequest();
            }

            _context.Entry(workingPeriod).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!WorkingPeriodExists(id))
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

        // POST: api/WorkingPeriods
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<WorkingPeriod>> PostWorkingPeriod(WorkingPeriod workingPeriod)
        {
            _context.EmploymentHistories.Add(workingPeriod);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetWorkingPeriod", new { id = workingPeriod.id }, workingPeriod);
        }

        // DELETE: api/WorkingPeriods/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteWorkingPeriod(Guid id)
        {
            var workingPeriod = await _context.EmploymentHistories.FindAsync(id);
            if (workingPeriod == null)
            {
                return NotFound();
            }

            _context.EmploymentHistories.Remove(workingPeriod);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool WorkingPeriodExists(Guid id)
        {
            return _context.EmploymentHistories.Any(e => e.id == id);
        }
    }
}
