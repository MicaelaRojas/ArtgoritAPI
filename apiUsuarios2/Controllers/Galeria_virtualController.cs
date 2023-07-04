using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using apiUsuarios2.Context;
using apiUsuarios2.Models;

namespace apiUsuarios2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Galeria_virtualController : ControllerBase
    {
        private readonly AppDbContext _context;

        public Galeria_virtualController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/Galeria_virtual
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Galeria_virtual>>> Getgaleria_virtual()
        {
            return await _context.galeria_virtual.ToListAsync();
        }

        // GET: api/Galeria_virtual/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Galeria_virtual>> GetGaleria_virtual(int id)
        {
            var galeria_virtual = await _context.galeria_virtual.FindAsync(id);

            if (galeria_virtual == null)
            {
                return NotFound();
            }

            return galeria_virtual;
        }

        // PUT: api/Galeria_virtual/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutGaleria_virtual(int id, Galeria_virtual galeria_virtual)
        {
            if (id != galeria_virtual.id)
            {
                return BadRequest();
            }

            _context.Entry(galeria_virtual).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!Galeria_virtualExists(id))
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

        // POST: api/Galeria_virtual
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Galeria_virtual>> PostGaleria_virtual(Galeria_virtual galeria_virtual)
        {
            _context.galeria_virtual.Add(galeria_virtual);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetGaleria_virtual", new { id = galeria_virtual.id }, galeria_virtual);
        }

        // DELETE: api/Galeria_virtual/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Galeria_virtual>> DeleteGaleria_virtual(int id)
        {
            var galeria_virtual = await _context.galeria_virtual.FindAsync(id);
            if (galeria_virtual == null)
            {
                return NotFound();
            }

            _context.galeria_virtual.Remove(galeria_virtual);
            await _context.SaveChangesAsync();

            return galeria_virtual;
        }

        private bool Galeria_virtualExists(int id)
        {
            return _context.galeria_virtual.Any(e => e.id == id);
        }
    }
}
