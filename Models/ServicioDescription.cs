using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProHogarApi.Models;

public class ServicioDescription{
    public int ServicioID { get; set; }
    [MaxLength(64)]
    public string? ServicioNombre { get; set; }
    [MaxLength(32)]
    public string? ServicioCategoria { get; set; }
    [MaxLength(32)]
    public string? ServicioDistrito { get; set; }
    [MaxLength(100)]
    public string? ServicioDireccion { get; set; }
    [Column(TypeName = "text")]
    public string? ServicioDescripcion { get; set; }
    public TimeSpan ServicioHorarioInicio { get; set; }
    public TimeSpan ServicioHorarioFin { get; set; }
    public int? NegocioID { get; set; }
    [MaxLength(100)]
    public string? NegocioNombre { get; set; }
    [Precision(1, 1)]
    public decimal ServicioCalificacion { get; set; }
    public bool IsFavorite { get; set; }
}
