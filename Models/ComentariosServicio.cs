using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProHogarApi.Models;

public class ComentariosServicios{
    public int ComentariosServiciosID { get; set; }
    [Precision(1, 1)]
    public decimal Calificacion { get; set; }
    [Column(TypeName = "text")]
    public string? Comentario { get; set; }
    public int ServiciosID { get; set; }
    public int ClienteID { get; set; }
}