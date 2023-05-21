using System.ComponentModel.DataAnnotations.Schema;

namespace ProHogarApi.Models;

public class Mensajes{
    public int MensajesID { get; set; }
    public DateTime HoraFechaEnvio { get; set; }
    [Column(TypeName = "text")]
    public string? Mensaje { get; set; }
    public int ChatID { get; set; }
}