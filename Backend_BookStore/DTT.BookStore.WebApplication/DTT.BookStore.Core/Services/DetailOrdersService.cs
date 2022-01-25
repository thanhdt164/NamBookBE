using DTT.BookStore.Core.Interfaces;
using DTT.BookStore.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTT.BookStore.Core.Services
{
    public class DetailOrdersService : BaseService<DetailOrders>, IDetailOrdersService
    {
        IDetailOrdersRepository _detailOrdersRepository;
        public DetailOrdersService(IDetailOrdersRepository detailOrdersRepository) : base(detailOrdersRepository)
        {
            _detailOrdersRepository = detailOrdersRepository;
        }

        public int InsertDetailOrders(paramInsertDetailOrders param)
        {
            return _detailOrdersRepository.InsertDetailOrders(param);
        }
    }
}
