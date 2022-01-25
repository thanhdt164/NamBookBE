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
    public class StoragesController : BaseEntityController<Storage>
    {
        IStorageService _storageService;

        public StoragesController(IStorageService storageService) : base(storageService)
        {
            _storageService = storageService;
        }

        
        [HttpPost("amount-in-storage")]
        public IActionResult getAmountInstorage(ParamBook_Id param)
        {
            return Ok(_storageService.getAmountInstorage(param));
        }
    }
}
