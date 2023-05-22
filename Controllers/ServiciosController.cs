using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProHogarApi.Models;


namespace ProHogarApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServicioController : ControllerBase{
        private readonly AppDBContext _context;

        public ServicioController(AppDBContext context){
            _context = context;
        }

        // GET: api/Servicio
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ServicioShortDescription>>> GetServicio(){
            if (_context.Servicio == null){
                return NotFound();
            }
            return await _context.Servicio
                .Join(_context.Negocio, 
                    s => s.NegocioID,
                    n => n.NegocioID, 
                    (s, n) => new {Servicio = s, Negocio = n})
                .Select(sn => new ServicioShortDescription{
                    ServicioID = sn.Servicio.ServicioID,
                    ServicioNombre = sn.Servicio.Nombre,
                    ServicioDistrito = sn.Servicio.Distrito,
                    ServicioCategoria = sn.Servicio.Categoria,
                    NegocioNombre = sn.Negocio.NombreEmpresa
                }).ToListAsync();
        }

        // GET: api/Servicio/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ServicioDescription>> GetServicio(long id){
            if (_context.Servicio == null){
              return NotFound();
            }

            var descripcion = await _context.Servicio
                .Where(s => s.ServicioID == id)
                .Join(_context.Negocio, 
                    s => s.NegocioID,
                    n => n.NegocioID, 
                    (s, n) => new {Servicio = s, Negocio = n})
                .Select(sn => new ServicioDescription{
                    ServicioID = sn.Servicio.ServicioID,
                    ServicioNombre = sn.Servicio.Nombre,
                    ServicioCategoria = sn.Servicio.Categoria,
                    ServicioDistrito = sn.Servicio.Distrito,
                    ServicioDireccion = sn.Servicio.Distrito,
                    ServicioDescripcion = sn.Servicio.Distrito,
                    ServicioHorarioInicio = sn.Servicio.HorarioInicio,
                    ServicioHorarioFin = sn.Servicio.HorarioFin,
                    NegocioID = sn.Negocio.NegocioID,
                    NegocioNombre = sn.Negocio.NombreEmpresa,
                    ServicioCalificacion = 5
                }).SingleOrDefaultAsync();
            
            if(descripcion == null){
                return NotFound();
            }

            return descripcion;
        }

        [HttpGet("byNegocio/{id}")]
        public async Task<ActionResult<IEnumerable<ServicioShortDescription>>> GetServicioByNegocio(int id) {
            if (_context.Servicio == null){
                return NotFound();
            }
        
            return await _context.Servicio
                .Where(s => s.NegocioID == id)
                .Join(_context.Negocio, 
                    s => s.NegocioID,
                    n => n.NegocioID, 
                    (s, n) => new {Servicio = s, Negocio = n})
                .Select(sn => new ServicioShortDescription{
                    ServicioID = sn.Servicio.ServicioID,
                    ServicioNombre = sn.Servicio.Nombre,
                    ServicioDistrito = sn.Servicio.Distrito,
                    ServicioCategoria = sn.Servicio.Categoria,
                    NegocioNombre = sn.Negocio.NombreEmpresa
                }).ToListAsync();
        }

        // POST: api/Negocio
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Servicio>> AddServicio(Servicio servicio) {
            if (_context.Servicio == null){
                return Problem("Entity set 'AppDBContext.Servicio'  is null.");
            }
            
            _context.Servicio.Add(servicio);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetServicio", new { id = servicio.ServicioID }, servicio);
        }

        [HttpGet("search")]
        public async Task<ActionResult<IEnumerable<ServicioShortDescription>>> HandleSearch(string? keyword, string? distrito, int? calificacion) {
            if (_context.Servicio == null){
                return Problem("Entity set 'AppDBContext.Servicio'  is null.");
            }

            Expression<Func<Servicio,bool>> searchPred = s => 
                ((keyword == null || s.Nombre == null) || s.Nombre.Contains(keyword)) &&
                ((distrito == null || s.Distrito == null) || s.Distrito.Equals(distrito)) ;

            return await _context.Servicio
                .Where(searchPred)
                .Join(_context.Negocio, 
                    s => s.NegocioID,
                    n => n.NegocioID, 
                    (s, n) => new {Servicio = s, Negocio = n})
                .Select(sn => new ServicioShortDescription{
                    ServicioID = sn.Servicio.ServicioID,
                    ServicioNombre = sn.Servicio.Nombre,
                    ServicioDistrito = sn.Servicio.Distrito,
                    ServicioCategoria = sn.Servicio.Categoria,
                    NegocioNombre = sn.Negocio.NombreEmpresa
                }).ToListAsync();
        }
    }
}