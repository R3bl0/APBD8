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
    Task<ProductDTO> PostProduct(ProductDTO productDto);
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

    public async Task<ProductDTO> PostProduct(ProductDTO productDto)
    {
        var product = new Product
        {
            Name = productDto.ProductName,
            Weight = productDto.ProductWeight,
            Width = productDto.ProductWidth,
            Height = productDto.ProductHeight,
            Depth = productDto.ProductDepth
        };

        var categories = await context.Categories
            .Where(c => productDto.ProductCategories.Contains(c.Id))
            .ToListAsync();

        var notFound = productDto.ProductCategories.Except(categories.Select(c => c.Id)).ToList();

        if (notFound.Any()) throw new NotFoundException($"There is no category with id: {notFound}");

        foreach (var id in categories)
        {
            var productCategory = new ProductCategory
            {
                Product = product,
                Category = id
            };
            await context.ProductsCategories.AddAsync(productCategory);
        }

        await context.Products.AddAsync(product);
        await context.SaveChangesAsync();

        return productDto;
    }
}