using DTT.BookStore.Core.Interfaces;
using DTT.BookStore.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTT.BookStore.Core.Services
{
    public class TransactionHistoryService : BaseService<TransactionHistory>, ITransactionHistoryService
    {
        ITransactionHistoryRepository _transactionHistoryRepository;
        public TransactionHistoryService(ITransactionHistoryRepository transactionHistoryRepository) : base(transactionHistoryRepository)
        {
            _transactionHistoryRepository = transactionHistoryRepository;
        }
    }
}
