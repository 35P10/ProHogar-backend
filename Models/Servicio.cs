using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProHogarApi.Models;

public class Servicio{
    public int ServicioID { get; set; } //PK
    [MaxLength(32)]
    public string? Distrito { get; set; }
    [MaxLength(100)]
    public string? Direccion { get; set; }
    [MaxLength(64)]
    public string? Nombre { get; set; }
    [Column(TypeName = "text")]
    public string? Descripcion { get; set; }
    public TimeSpan HorarioInicio { get; set; }
    public TimeSpan HorarioFin { get; set; }
    [MaxLength(32)]
    public string? Categoria { get; set; }
    public int NegocioID { get; set; } //FK
}
