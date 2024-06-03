using APBD8.Models;

namespace APBD8.DTOs;

public record AccountDTO(string firstname, string lastname, string email, string phone, Role role, IEnumerable<ShopingCart> ShopingCarts)
{
    public AccountDTO(Account account) : this(account.FirstName, account.LastName, account.Email, account.Phone,
        account.Role, account.ShopingCarts)
    { }
}