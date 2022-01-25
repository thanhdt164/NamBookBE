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
    public class UsersController : BaseEntityController<User>
    {
        IUserService _userService;

        public UsersController(IUserService userService) : base(userService)
        {
            _userService = userService;
        }

        [HttpPost("user-info")]
        public IActionResult getUserInfo([FromBody] paramAccountName param)
        {
            return Ok(_userService.getUserInfo(param.accountName).FirstOrDefault());
        }
    }
}
