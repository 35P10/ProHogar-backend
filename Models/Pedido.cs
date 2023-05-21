using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace ProHogarApi.Models;

public class Pedido{
    public int PedidoID { get; set; }
    [Precision(18, 2)]
    public decimal PrecioFinal { get; set; }
    public DateTime HorarioFinal { get; set; }
    [MaxLength(32)]
    public string? Estado { get; set; }
    public int ClienteID { get; set; }
    public int ServicioID { get; set; }
}