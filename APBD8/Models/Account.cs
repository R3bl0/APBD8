using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace APBD8.Models;

[Table("Accounts")]
public class Account
{
    [Key]
    [Column("PK_account")]
    public int Id { get; set; }
    [ForeignKey("Role")]
    [Column("FK_role")]
    public int RoleId { get; set; }
    public Role Role { get; set; }
    [Column("first_name")]
    [MaxLength(50)]
    public string FirstName { get; set; }
    [Column("last_name")]
    [MaxLength(50)]
    public string LastName { get; set; }
    [Column("email")]
    [MaxLength(80)]
    public string Email { get; set; }
    [Column("phone")]
    [MaxLength(9)]
    public string? Phone { get; set; }
    public IEnumerable<ShopingCart> ShopingCarts { get; set; }
}