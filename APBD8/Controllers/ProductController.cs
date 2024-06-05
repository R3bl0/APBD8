using APBD8.DTOs;
using APBD8.Exceptions;
using APBD8.Services;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace APBD8.Controllers;

[ApiController]
[Route("/api/products")]
public class ProductController:ControllerBase
{
    private readonly IDbService _dbService;

    public ProductController(IDbService dbService)
    {
        _dbService = dbService;
    }
    
    [HttpPost]
    public async Task<IActionResult> GetAccount(ProductDTO productDto)
    {
        if (!ModelState.IsValid) return BadRequest("Invalid data");
        try
        {
            var created = await _dbService.PostProduct(productDto);
            return Created($"/api/products/{productDto.ProductName}",productDto);
        }
        catch (BadRequestException e)
        {
            return BadRequest(e.Message);
        }
    }
}