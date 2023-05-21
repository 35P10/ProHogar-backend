using System.ComponentModel.DataAnnotations;

namespace ProHogarApi.Models;

public class Negocio{
    public int NegocioID { get; set; }
    [MaxLength(100)]
    public string? NombreEmpresa { get; set; }
    public int Telefono { get; set; }
}