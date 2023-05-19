using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProHogarApi.Models;

namespace ProHogarApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NegocioController : ControllerBase
    {
        private readonly AppDBContext _context;

        public NegocioController(AppDBContext context)
        {
            _context = context;
        }

        // GET: api/Negocio
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Negocio>>> GetNegocio()
        {
          if (_context.Negocio == null)
          {
              return NotFound();
          }
            return await _context.Negocio.ToListAsync();
        }

        // GET: api/Negocio/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Negocio>> GetNegocio(long id)
        {
          if (_context.Negocio == null)
          {
              return NotFound();
          }
            var negocio = await _context.Negocio.FindAsync(id);

            if (negocio == null)
            {
                return NotFound();
            }

            return negocio;
        }

        // PUT: api/Negocio/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutNegocio(long id, Negocio negocio)
        {
            if (id != negocio.Id)
            {
                return BadRequest();
            }

            _context.Entry(negocio).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!NegocioExists(id))
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

        // POST: api/Negocio
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Negocio>> PostNegocio(Negocio negocio)
        {
          if (_context.Negocio == null)
          {
              return Problem("Entity set 'AppDBContext.Negocio'  is null.");
          }
            _context.Negocio.Add(negocio);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetNegocio", new { id = negocio.Id }, negocio);
        }

        // DELETE: api/Negocio/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteNegocio(long id)
        {
            if (_context.Negocio == null)
            {
                return NotFound();
            }
            var negocio = await _context.Negocio.FindAsync(id);
            if (negocio == null)
            {
                return NotFound();
            }

            _context.Negocio.Remove(negocio);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool NegocioExists(long id)
        {
            return (_context.Negocio?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
