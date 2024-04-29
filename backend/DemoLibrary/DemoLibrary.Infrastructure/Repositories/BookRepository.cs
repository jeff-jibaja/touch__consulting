using Dapper;
using DemoLibrary.Application.Handlers.Queries.BookController.FindAll;
using DemoLibrary.Application.Interfaces.Repositories;
using DemoLibrary.Application.Models.Common;
using DemoLibrary.Application.Models.Database;
using DemoLibrary.Common.Helpers;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary.Infrastructure.Repositories
{
    public class BookRepository:IBookRepository
    {
        private readonly IConfiguration _configuration;
        private readonly HeaderToken _token;

        public BookRepository(IConfiguration configuration, HeaderToken token)
        {
            _configuration = configuration;
            _token = token;
        }

        public async Task<IEnumerable<BokkFindResponse>> CreateAndUpdateByStoredProcedure(BookFindAllRequest book)
        {
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DEV_STANDAR")))
            {

                var parameters = new DynamicParameters();
                parameters.Add("@ParamIdPerson", book.Param);
                parameters.Add("@ParamDNI", book.Value);
                parameters.Add("@ParamDNI", book.PageNumber);
                parameters.Add("@ParamDNI", book.NumberOfRecord);
                //parameters.Add("@ParamUser", _token.UserEdit);

                //return await connection.QueryAsync<List<ModelBook>(
                //    sql: $"{ConstantMasterTable.Procedure.BookFilter}",
                //    param: parameters,
                //    commandType: CommandType.StoredProcedure);

                var result = await connection.QueryAsync<BokkFindResponse>(
                        sql: $"{ConstantMasterTable.Procedure.BookFilter}",
                        param: parameters,
                        commandType: CommandType.StoredProcedure);

                return result;
            }
        }
    }
    
}
