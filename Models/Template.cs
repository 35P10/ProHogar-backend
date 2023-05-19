namespace ProHogarApi.Models;

public class MyModel{
    public long Id { get; set; }
    public string? Name { get; set; }
    public bool IsComplete { get; set; }
    public DateOnly Date { get; set; }
    public DateTime ReleaseDate { get; set; }
    public decimal Price { get; set; }
}
