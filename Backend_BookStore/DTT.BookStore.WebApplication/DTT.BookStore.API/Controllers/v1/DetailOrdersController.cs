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
    public class DetailOrdersController : BaseEntityController<DetailOrders>
    {
        IDetailOrdersService _detailOrdersService;

        public DetailOrdersController(IDetailOrdersService detailOrdersService) : base(detailOrdersService)
        {
            _detailOrdersService = detailOrdersService;
        }

        #region Methods
        [HttpPost("detail-orders-i")]
        public IActionResult InsertDetailOrders([FromBody] paramInsertDetailOrders param)
        {
            return Ok(_detailOrdersService.InsertDetailOrders(param));
        }
        #endregion
    }
}
