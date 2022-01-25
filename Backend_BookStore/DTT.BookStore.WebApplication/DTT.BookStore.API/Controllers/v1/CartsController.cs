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
    public class CartsController : BaseEntityController<Cart>
    {
        ICartService _cartService;

        public CartsController(ICartService cartService) : base(cartService)
        {
            _cartService = cartService;
        }

        [HttpPost("cart-info")]
        public IActionResult getCartInfo([FromBody] int userId)
        {
            var result = _cartService.getCartInfo(userId);
            return Ok(result.FirstOrDefault());
        }

    }
}
