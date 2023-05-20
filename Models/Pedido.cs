namespace ProHogarApi.Models;

public class Pedido{
    public int PedidoID { get; set; }
    public decimal PrecioFinal { get; set; }
    public DateTime HorarioFinal { get; set; }
    public int ClienteID { get; set; }
}