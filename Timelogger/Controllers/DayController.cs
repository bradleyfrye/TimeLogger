using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Timelogger.Models;

namespace Timelogger.Controllers
{
    [Produces("application/json")]
    [Route("api/Day")]
    public class DayController : Controller
    {
        private readonly DayContext _context;

        public DayController(DayContext context)
        {
            _context = context;
        }

        // GET: api/Day
        [HttpGet]
        public IEnumerable<Day> GetDay()
        {
            return _context.Day;
        }

        // GET: api/Day/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetDay([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var day = await _context.Day.SingleOrDefaultAsync(m => m.Id == id);

            if (day == null)
            {
                return NotFound();
            }

            return Ok(day);
        }

        // PUT: api/Day/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutDay([FromRoute] int id, [FromBody] Day day)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != day.Id)
            {
                return BadRequest();
            }

            _context.Entry(day).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DayExists(id))
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

        // POST: api/Day
        [HttpPost]
        public async Task<IActionResult> PostDay([FromBody] Day day)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.Day.Add(day);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetDay", new { id = day.Id }, day);
        }

        // DELETE: api/Day/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteDay([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var day = await _context.Day.SingleOrDefaultAsync(m => m.Id == id);
            if (day == null)
            {
                return NotFound();
            }

            _context.Day.Remove(day);
            await _context.SaveChangesAsync();

            return Ok(day);
        }

        private bool DayExists(int id)
        {
            return _context.Day.Any(e => e.Id == id);
        }
    }
}