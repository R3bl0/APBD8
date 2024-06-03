using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace APBD8.Models;

[Table("Products_Categories")]
public class ProductCategory
{
    [Key]
    [ForeignKey("Product")]
    [Column("FK_acount")]
    public int ProductId { get; set; }
    public Product Product { get; set; }
    [Key]
    [ForeignKey("Category")]
    [Column("FK_Category")]
    public int CategoryId { get; set; }
    public Category Category { get; set; }
}