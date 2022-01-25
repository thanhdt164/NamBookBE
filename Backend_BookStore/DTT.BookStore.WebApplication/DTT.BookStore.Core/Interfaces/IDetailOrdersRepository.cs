using DTT.BookStore.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTT.BookStore.Core.Interfaces
{
    public interface IDetailOrdersRepository: IBaseRepository<DetailOrders>
    {
        int InsertDetailOrders(paramInsertDetailOrders param);
    }

}
