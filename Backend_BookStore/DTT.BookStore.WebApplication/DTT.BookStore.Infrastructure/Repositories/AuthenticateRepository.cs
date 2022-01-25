using Dapper;
using DTT.BookStore.Core.Interfaces;
using DTT.BookStore.Core.Models;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTT.BookStore.Infrastructure.Repositories
{
    public class AuthenticateRepository : BaseRepository<Account>, IAuthenticateRepositoty
    {
        public AuthenticateRepository(IConfiguration configuration) : base(configuration) { }
        public object Authenticate(string userName, string password)
        {
            var sql = $"Select count(*) count from tblAccount where account_nm = '{userName}' and password = '{password}'";
            var ressult = _dbConnection.Query<object>(sql, commandType: CommandType.Text).FirstOrDefault();
            return ressult;
        }
    }
}
