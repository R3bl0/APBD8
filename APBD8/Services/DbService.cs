using System.Data;
using System.Data.SqlClient;
using APBD8.Contexts;
using APBD8.DTOs;
using APBD8.Exceptions;
using APBD8.Models;
using Microsoft.EntityFrameworkCore;

namespace APBD8.Services;

public interface IDbService
{
    Task<AccountDTO> GetAccount(int id);
}

public class DbService(DatabaseContext context) : IDbService
{
    public async Task<AccountDTO> GetAccount(int id)
    {
        var result = await context.Accounts
            .Where(a => a.Id == id)
            .Select(a => new AccountDTO
            {
                FirstName = a.FirstName,
                LastName = a.LastName,
                Email = a.Email,
                Phone = a.Phone,
                Role = a.Role.Name,
                Cart = a.ShopingCarts
                    .Select(sc => new CartDTO
                    {
                        ProductId = sc.ProductId,
                        ProductName = sc.Product.Name,
                        Amount = sc.Amount
                    }).ToList()
            })
            .FirstOrDefaultAsync();
        if (result is null)
        {
            throw new NotFoundException($"Account id: {id} does not exist");
        }
        return result;
    }
}