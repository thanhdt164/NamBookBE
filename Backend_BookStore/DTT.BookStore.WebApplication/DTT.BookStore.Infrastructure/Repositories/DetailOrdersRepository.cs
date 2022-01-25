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
    public class DetailOrdersRepository : BaseRepository<DetailOrders>, IDetailOrdersRepository
    {
        public DetailOrdersRepository(IConfiguration configuration) : base(configuration) { }


        public int InsertDetailOrders(paramInsertDetailOrders param)
        {
            // Lấy orders_id
            var sql = "select max(orders_id)+1 from tblorders";
            var orders_id = _dbConnection.Query<int>(sql, commandType: CommandType.Text).FirstOrDefault();
            var count = param.book_ids.Count;
            for(int i = 0; i< count; i++)
            {
                var amount = param.amounts[i];
                var book_id = param.book_ids[i];
                do
                {
                    // Lấy payload_id
                    var sql2 = $"SELECT payload_id from tblpayload WHERE book_id = {book_id} and amount_in_storage > 0 ORDER BY import_date ASC LIMIT 1";
                    var payload_id = _dbConnection.Query<int>(sql2, commandType: CommandType.Text).FirstOrDefault();
                    sql2 = $"SELECT amount_in_storage from tblpayload WHERE book_id = {book_id} and amount_in_storage > 0 ORDER BY import_date ASC LIMIT 1";
                    var amount_in_storage = _dbConnection.Query<int>(sql2, commandType: CommandType.Text).FirstOrDefault();
                    // Thực hiện insert vào bảng ordersdetail
                    var amount_insert = 0;
                    if (amount > amount_in_storage)
                    {
                        amount_insert = amount_in_storage;
                        amount -= amount_in_storage;
                    }
                    else
                    {
                        amount_insert = amount;
                        amount = 0;
                    }
                    var paramInsert = new
                    {
                        orders_id = orders_id,
                        book_id = book_id,
                        payload_id = payload_id,
                        user_id = param.user_id,
                        amount = amount_insert
                    };
                    var rs = _dbConnection.Execute($"Proc_Insert{_entityName}", param: paramInsert, commandType: CommandType.StoredProcedure);
                } while (amount > 0);
            }
            return 0;
        }
    }
}
