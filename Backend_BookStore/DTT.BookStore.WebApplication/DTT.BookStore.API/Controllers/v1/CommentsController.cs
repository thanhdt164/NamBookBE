using DTT.BookStore.Core.Models;
using DTT.BookStore.Infrastructure.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DTT.BookStore.API.Controllers.v1
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class CommentsController : ControllerBase
    {
        [HttpPut]
        public IActionResult Update([FromBody] ParamComment param)
        {
         
            var comment = new CommentRepository();
            return Ok(comment.updateComment(param));


        }
    }
}
