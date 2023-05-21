using System.ComponentModel.DataAnnotations;

namespace ProHogarApi.Models;

public class ServicioShortDescription{
    public int ServicioID { get; set; }
    [MaxLength(64)]
    public string? ServicioNombre { get; set; }
    [MaxLength(32)]
    public string? ServicioDistrito { get; set; }
    [MaxLength(32)]
    public string? ServicioCategoria { get; set; }
    [MaxLength(100)]
    public string? NegocioNombre { get; set; }
}
