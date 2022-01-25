using DTT.BookStore.Core.Interfaces;
using DTT.BookStore.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTT.BookStore.Core.Services
{
    public class OrdersService : BaseService<Orders>, IOrdersService
    {
        IOrdersRepository _ordersRepository;
        public OrdersService(IOrdersRepository ordersRepository) : base(ordersRepository)
        {
            _ordersRepository = ordersRepository;
        }
    }
}
