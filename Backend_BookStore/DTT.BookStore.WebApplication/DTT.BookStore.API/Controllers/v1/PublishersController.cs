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
    public class PublishersController : BaseEntityController<Publisher>
    {
        IPublisherService _publisherService;

        public PublishersController(IPublisherService publisherService) : base(publisherService)
        {
            _publisherService = publisherService;
        }
    }
}
