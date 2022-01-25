using DTT.BookStore.Core.Interfaces;
using DTT.BookStore.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTT.BookStore.Core.Services
{
    public class CartService : BaseService<Cart>, ICartService
    {
        ICartRepository _cartRepository;
        public CartService(ICartRepository cartRepository) : base(cartRepository)
        {
            _cartRepository = cartRepository;
        }

        public IEnumerable<object> getCartInfo(int userId)
        {
            return _cartRepository.getCartInfo(userId);
        }
    }
}
