using DTT.BookStore.Core.Models;
using DTT.BookStore.Core.ServiceResult;
using System;
using System.Collections.Generic;
using System.Text;

namespace DTT.BookStore.Core.Interfaces
{
    public interface IAuthenticateService : IBaseService<Account>
    {
        object Authenticate(string userName, string password);
    }
}
