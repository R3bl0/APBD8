using System.Data;
using System.Data.SqlClient;
using APBD8.Contexts;
using APBD8.DTOs;
using APBD8.Models;

namespace APBD8.Services;

public interface IDbService
{
    Task<AccountDTO> GetAccount(int id);
}

public class DbService(DatabaseContext context) : IDbService
{
    public async Task<AccountDTO> GetAccount(int id)
    {
        
    }
}