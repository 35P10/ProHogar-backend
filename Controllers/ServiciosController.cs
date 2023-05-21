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
    public class ServicioController : ControllerBase{
        private readonly AppDBContext _context;

        public ServicioController(AppDBContext context){
            _context = context;
        }

        // GET: api/Servicio
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ServicioShortDescription>>> GetNegocio(){
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
        public async Task<ActionResult<ServicioDescription>> GetNegocio(long id){
            if (_context.Negocio == null){
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
    }
}