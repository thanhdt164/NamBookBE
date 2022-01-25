using DTT.BookStore.Core.Interfaces;
using DTT.BookStore.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTT.BookStore.Core.Services
{
    public class UserService : BaseService<User>, IUserService
    {
        IUserRepository _userRepository;
        public UserService(IUserRepository userRepository) : base(userRepository)
        {
            _userRepository = userRepository;
        }

        public IEnumerable<object> getUserInfo(string accountName)
        {
            return _userRepository.getUserInfo(accountName);
        }
    }
}
