namespace ProHogarApi.Models;

public class Usuario{
    public int UsuarioID { get; set; } //PK
    public string? Nombres { get; set; }
    public string? Apellidos { get; set; }
    public string? CorreoElectronico { get; set; }
    public string? Password { get; set; }
}

public class UsuarioLogin {
    public string? CorreoElectronico { get; set; }
    public string? Password { get; set; }
}
