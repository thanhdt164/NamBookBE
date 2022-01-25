using DTT.BookStore.Core.Interfaces;
using DTT.BookStore.Core.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DTT.BookStore.API.Controllers.v1
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class AuthenticatesController : BaseEntityController<Account>
    {
        IAuthenticateService _authenticateService;

        public AuthenticatesController(IAuthenticateService authenticateService) : base(authenticateService)
        {
            _authenticateService = authenticateService;
        }

        
        [HttpPost("Authenticate")]
        public IActionResult Authenticate([FromBody] ParamAuthenticate param)
        {
            var result = _authenticateService.Authenticate(param.userName, param.password);
            //IdentityResult res = await  UserManager.CreateAsyn()
            return Ok(result);
           
        }
    }
}
