using System.ComponentModel.DataAnnotations;

namespace ProHogarApi.Models;

public class Usuario{
    public int UsuarioID { get; set; } //PK
    [MaxLength(100)]
    public string? Nombres { get; set; }
    [MaxLength(100)]
    public string? Apellidos { get; set; }
    [MaxLength(100)]
    public string? CorreoElectronico { get; set; }
    [MaxLength(64)]
    public string? Password { get; set; }
}

public class UsuarioLogin {
    public string? CorreoElectronico { get; set; }
    public string? Password { get; set; }
}
