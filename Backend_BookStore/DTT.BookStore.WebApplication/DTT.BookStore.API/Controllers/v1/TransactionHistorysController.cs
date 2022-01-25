using DTT.BookStore.Core.Interfaces;
using DTT.BookStore.Core.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DTT.BookStore.API.Controllers.v1
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class TransactionHistorysController : BaseEntityController<TransactionHistory>
    {
        ITransactionHistoryService _transactionHistoryService;

        public TransactionHistorysController(ITransactionHistoryService transactionHistoryService) : base(transactionHistoryService)
        {
            _transactionHistoryService = transactionHistoryService;
        }
    }
}
