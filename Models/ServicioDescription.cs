namespace ProHogarApi.Models;

public class ServicioDescription{
    public int ServicioID { get; set; }
    public string? ServicioNombre { get; set; }
    public string? ServicioCategoria { get; set; }
    public string? ServicioDistrito { get; set; }
    public string? ServicioDireccion { get; set; }
    public string? ServicioDescripcion { get; set; }
    public TimeSpan ServicioHorarioInicio { get; set; }
    public TimeSpan ServicioHorarioFin { get; set; }
    public int? NegocioID { get; set; }
    public string? NegocioNombre { get; set; }
    public decimal ServicioCalificacion { get; set; }
}
