namespace ProHogarApi.Models;

public class Mensajes{
    public int MensajesID { get; set; }
    public DateTime HoraFechaEnvio { get; set; }
    public string? Mensaje { get; set; }
    public int ChatID { get; set; }
}