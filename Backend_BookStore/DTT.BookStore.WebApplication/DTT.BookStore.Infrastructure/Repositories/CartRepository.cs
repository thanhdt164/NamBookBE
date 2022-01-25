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
    public class CartRepository : BaseRepository<Cart>, ICartRepository
    {
        public CartRepository(IConfiguration configuration) : base(configuration) { }
        public IEnumerable<object> getCartInfo(int userId)
        {
            // Lấy thông tin cart
            var sql = $"select * from tblCart c where c.cart_id = '{userId}'";
            var cart = _dbConnection.Query<object>(sql, commandType: CommandType.Text);
            return cart;
        }
    }
}
