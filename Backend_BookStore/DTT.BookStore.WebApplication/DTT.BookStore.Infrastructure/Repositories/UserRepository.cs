using Dapper;
using DTT.BookStore.Core.Interfaces;
using DTT.BookStore.Core.Models;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTT.BookStore.Infrastructure.Repositories
{
    public class UserRepository : BaseRepository<User>, IUserRepository
    {
        public UserRepository(IConfiguration configuration) : base(configuration) { }

        public IEnumerable<object> getUserInfo(string accountName)
        {
            var userInfo = _dbConnection.Query<object>("Proc_GetUserInfo", param: new { accountName = accountName }, commandType: CommandType.StoredProcedure);
            return userInfo;
        }
    }
}
