using DTT.BookStore.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTT.BookStore.Core.Interfaces
{
    public interface IAuthenticateRepositoty : IBaseRepository<Account>
    {
        /// <summary>
        /// Hàm xác thực
        /// </summary>
        /// <returns></returns>
        /// Created by: thanhdt - 19.05.2021
        object Authenticate(string userName, string password);
    }
}
