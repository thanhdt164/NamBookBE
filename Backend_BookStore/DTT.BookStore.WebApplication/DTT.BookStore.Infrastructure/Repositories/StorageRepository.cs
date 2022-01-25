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
    public class StorageRepository : BaseRepository<Storage>, IStorageRepository
    {
        public StorageRepository(IConfiguration configuration) : base(configuration) { }

        public IEnumerable<int> getAmountInstorage(ParamBook_Id param)
        {
            var sql = $"select amount from tblstorage where book_id = {param.book_id}";
            var rs = _dbConnection.Query<int>(sql, commandType: CommandType.Text);
            return rs;
        }
    }
}
