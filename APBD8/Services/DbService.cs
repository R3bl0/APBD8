using System.Data;
using System.Data.SqlClient;
using APBD8.DTOs;

namespace APBD8.Services;

public interface IDbService
{
    Task<AccountDTO> GetAccount(int id);
}

public class DbService : IDbService
{
    private readonly IConfiguration _configuration;

    public DbService(IConfiguration configuration)
    {
        _configuration = configuration;
    }

    private async Task<SqlConnection> GetConnection()
    {
        var sqlConnection = new SqlConnection(_configuration.GetConnectionString("Default"));
        if (sqlConnection.State != ConnectionState.Open) await sqlConnection.OpenAsync();
        return sqlConnection;
    }

    public Task<AccountDTO> GetAccount(int id)
    {
        throw new NotImplementedException();
    }
}