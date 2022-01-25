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
    public class PayloadsController : BaseEntityController<Payload>
    {
        IPayloadService _payloadService;

        public PayloadsController(IPayloadService payloadService) : base(payloadService)
        {
            _payloadService = payloadService;
        }

        // POST api/<BaseEntityController>
        //[HttpPost]
        //public override IActionResult Insert([FromBody] ParamInsertPayload param)
        //{
        //    var serviceResult = _payloadService.Insert(payload);
        //    if (serviceResult.ResultCode == Core.Enum.DTTCode.NotValid)
        //    {
        //        return BadRequest(serviceResult);
        //    }
        //    else if (serviceResult.ResultCode == Core.Enum.DTTCode.Success)
        //    {
        //        return Ok(serviceResult);
        //    }
        //    else
        //    {
        //        return NoContent();
        //    }
        //}
    }
}
