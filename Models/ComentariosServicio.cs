namespace ProHogarApi.Models;

public class ComentariosServicios{
    public int ComentariosServiciosID { get; set; }
    public int Calificacion { get; set; }
    public string? Comentario { get; set; }
    public int ServiciosID { get; set; }
    public int ClienteID { get; set; }
}