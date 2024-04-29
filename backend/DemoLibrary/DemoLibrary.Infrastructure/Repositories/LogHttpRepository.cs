﻿using DemoLibrary.Application.Interfaces.Repositories;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System.Data;

namespace DemoLibrary.Infrastructure.Repositories
{
    public class LogHttpRepository : ILogHttpRepository
    {
        private readonly IConfiguration _configuration;
        public LogHttpRepository(IConfiguration configuration)
        {
            this._configuration = configuration;
        } 
        public async Task<int> DeleteOlds(CancellationToken cancellationToken = default)
        {
            using var con = new SqlConnection(_configuration.GetConnectionString("DEV_STANDAR"));
            await con.OpenAsync(cancellationToken);
            using var cmd = con.CreateCommand();
            cmd.CommandText = "[Sgr].[USP_Delete_Olds_LogHttp]";
            cmd.CommandType = CommandType.StoredProcedure;
            var rowAffect = await cmd.ExecuteNonQueryAsync(cancellationToken);           
            await con.CloseAsync();
            return rowAffect;
        }
    }
}
