﻿using DTT.BookStore.Core.Interfaces;
using DTT.BookStore.Core.Models;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTT.BookStore.Infrastructure.Repositories
{
    public class TransactionHistoryRepository : BaseRepository<TransactionHistory>, ITransactionHistoryRepository
    {
        public TransactionHistoryRepository(IConfiguration configuration) : base(configuration) { }
    }
}
