using DTT.BookStore.Core.Interfaces;
using DTT.BookStore.Core.Models;
using DTT.BookStore.Core.ServiceResult;
using System;
using System.Collections.Generic;
using System.Text;

namespace DTT.BookStore.Core.Services
{
    public class AuthenticateService : BaseService<Account>, IAuthenticateService
    {
        IAuthenticateRepositoty _authenticateRepository;
        public AuthenticateService(IAuthenticateRepositoty authenticateRepository): base(authenticateRepository)
        {
            _authenticateRepository = authenticateRepository;
        }

        public object Authenticate(string userName, string password)
        {
            return _authenticateRepository.Authenticate(userName, password);
        }
    }
}
