using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace APBD8.Models;

public class ShopingCart
{
    [ForeignKey("Account")]
    [Column("FK_acount")]
    public int AccountId { get; set; }
    public Account Account { get; set; }
    [ForeignKey("Product")]
    [Column("FK_product")]
    public int ProductId { get; set; }
    public Product Product { get; set; }
    [Column("amount")]
    public int Amount { get; set; }
}