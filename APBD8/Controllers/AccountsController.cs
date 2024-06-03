using APBD8.Services;
using Microsoft.AspNetCore.Mvc;

namespace APBD8.Controllers;

[ApiController]
[Route("/api/accounts")]
public class AccountsController
{
    private readonly IDbService _dbService;

    public AccountsController(IDbService dbService)
    {
        _dbService = dbService;
    }

    [HttpGet("{accountId:int}")]
    public async Task<IActionResult> GetAccount(int id)
    {
        return null;
    }
}