using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace APBD8.Models;

[PrimaryKey("ProductId", "CategoryId")]
[Table("Products_Categories")]
public class ProductCategory
{
    [ForeignKey("Product")]
    [Column("FK_account")]
    public int ProductId { get; set; }
    public Product Product { get; set; }
    [ForeignKey("Category")]
    [Column("FK_Category")]
    public int CategoryId { get; set; }
    public Category Category { get; set; }
}