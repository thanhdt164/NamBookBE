using Dapper;
using DTT.BookStore.Core.Models;
using Microsoft.Extensions.Configuration;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTT.BookStore.Infrastructure.Repositories
{
    public class CommentRepository
    {
        #region Declare
        string _connectionString = string.Empty;
        protected IDbConnection _dbConnection;
        protected string _entityName = string.Empty;
        #endregion
        
        public CommentRepository()
        {
            _connectionString = "Server=localhost;Port=3306;Database=bookstore;Uid=root;Pwd='';";
            _dbConnection = new MySqlConnection(_connectionString);
            _entityName = "Comment";
        }

        public int updateComment(ParamComment param)
        {
            var sql = $"Update tblcomment Set comment_json = '{param.comment_json}' where comment_id = {param.comment_id}";
            var rs = _dbConnection.Query<int>(sql, commandType: CommandType.Text).FirstOrDefault();
            return rs;
        }
    }
}
