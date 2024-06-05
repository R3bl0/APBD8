namespace APBD8.DTOs;

public record CartDTO
{
    public int ProductId { get; set; }
    public string ProductName { get; set; }
    public int Amount { get; set; }
}