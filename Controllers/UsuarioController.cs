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
    public class UsuarioController : ControllerBase{
        private readonly AppDBContext _context;

        public UsuarioController(AppDBContext context){
            _context = context;
        }

        [HttpPost]
        [Route("login")]
        public async Task<IActionResult> UsuarioLogin([FromBody] UsuarioLogin usuario) {
            var dbUsuario = await _context.Usuario
                .Where(u => usuario.CorreoElectronico == u.CorreoElectronico)
                .FirstOrDefaultAsync();

            if (dbUsuario == null) {
                return BadRequest("Usuario no existe");
            }

            if (dbUsuario.Password != usuario.Password){
                return BadRequest("Contraseña incorrecta");
            }

            return Ok(dbUsuario);
        }

        // POST: api/registro
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        [Route("registro")]
        public async Task<ActionResult> Registrar([FromBody] Usuario newUsuario) {
            if (_context.Usuario == null){
                return Problem("Entity set 'AppDBContext.Usuario' is null.");
            }
            if ((_context.Usuario.Any(u => u.CorreoElectronico == newUsuario.CorreoElectronico)))
                return BadRequest("Correo electronico ya registrado");
            
            _context.Usuario.Add(newUsuario);

            await _context.SaveChangesAsync();

            return Ok();
        }

        private bool UsuarioExists(long id){
            return (_context.Usuario?.Any(u => u.UsuarioID == id)).GetValueOrDefault();
        }
    }
}