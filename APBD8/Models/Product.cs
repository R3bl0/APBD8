using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace APBD8.Models;

[Table("Products")]
public class Product
{
    [Key]
    [Column("PK_product")]
    public int Id { get; set; }
    [Column("name")]
    [MaxLength(100)]
    public string Name { get; set; }
    [Column("weight")]
    [Precision(5,2)]
    public decimal Weight { get; set; }
    [Column("width")]
    [Precision(5,2)]
    public decimal Width { get; set; }
    [Column("height")]
    [Precision(5,2)]
    public decimal Height { get; set; }
    [Column("depth")]
    [Precision(5,2)]
    public decimal Depth { get; set; }
    public IEnumerable<ProductCategory> ProductsCategories { get; set; }
    public IEnumerable<ShopingCart> ShopingCarts { get; set; }
}