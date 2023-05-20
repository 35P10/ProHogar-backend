namespace ProHogarApi.Models;

public class Servicio{
    public int ServicioID { get; set; } //PK
    public string Distrito { get; set; }
    public string Direccion { get; set; }
    public string Nombre { get; set; }
    public string Descripcion { get; set; }
    public TimeSpan HorarioInicio { get; set; }
    public TimeSpan HorarioFin { get; set; }
    public string Categoria { get; set; }
    public int NegocioID { get; set; } //FK
}
