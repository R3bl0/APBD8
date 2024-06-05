using APBD8.Exceptions;
using APBD8.Services;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace APBD8.Controllers;

[ApiController]
[Route("/api/accounts")]
public class AccountsController:ControllerBase
{
    private readonly IDbService _dbService;

    public AccountsController(IDbService dbService)
    {
        _dbService = dbService;
    }
    
    [HttpGet("{accountId:int}")]
    public async Task<IActionResult> GetAccount(int accountId)
    {
        try
        {
            return Ok(await _dbService.GetAccount(accountId));
        }
        catch (NotFoundException e)
        {
            return NotFound(e.Message);
        }
    }
}