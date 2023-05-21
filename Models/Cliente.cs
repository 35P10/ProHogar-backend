using System.ComponentModel.DataAnnotations;

namespace ProHogarApi.Models;

public class Cliente{
    public int ClienteID { get; set; }
    public int Telefono { get; set; }
    [MaxLength(32)]
    public string? Distrito { get; set; }
    [MaxLength(100)]
    public string? Direccion { get; set; }
}