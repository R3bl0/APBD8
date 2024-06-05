using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace APBD8.DTOs;

public class ProductDTO
{
    [Required]
    [MaxLength(100)]
    public string ProductName { get; set; }
    [Required]
    [Precision(5,2)]
    public decimal ProductWeight { get; set; }
    [Required]
    [Precision(5,2)]
    public decimal ProductWidth { get; set; }
    [Required]
    [Precision(5,2)]
    public decimal ProductHeight { get; set; }
    [Required]
    [Precision(5,2)]
    public decimal ProductDepth { get; set; }
    [Required]
    public List<int> ProductCategories { get; set; }
}