using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace APBD8.Models;

[Table("Categories")]
public class Category
{
    [Key]
    [Column("PK_category")]
    public int Id { get; set; }
    [Column("name")]
    [MaxLength(100)]
    public string Name { get; set; }
    public IEnumerable<ProductCategory> ProductsCategories { get; set; }
}