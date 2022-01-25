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
    public class PayloadRepository : BaseRepository<Payload>, IPayloadRepository
    {
        public PayloadRepository(IConfiguration configuration) : base(configuration) { }

        public override int Insert(Payload payload)
        {
            var sql = $"Insert into tblpayload (payload_id, book_id, amount, import_price) " +
                $"values ({payload.payload_id}, {payload.book_id}, {payload.amount}, {payload.import_price})";
            var rowAffects = _dbConnection.Execute(sql, commandType: CommandType.Text);
            return rowAffects;
        }
    }
}
