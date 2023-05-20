using Microsoft.EntityFrameworkCore;

namespace ProHogarApi.Models;

public class Pedido{
    public int PedidoID { get; set; }
    [Precision(18, 2)]
    public decimal PrecioFinal { get; set; }
    public DateTime HorarioFinal { get; set; }
    public int ClienteID { get; set; }
}