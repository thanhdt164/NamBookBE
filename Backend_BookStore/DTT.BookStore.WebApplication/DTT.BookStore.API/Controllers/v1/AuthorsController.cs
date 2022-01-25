using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DTT.BookStore.Core.Models;
using DTT.BookStore.Core.Interfaces;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DTT.BookStore.API.Controllers.v1
{
    public class AuthorsController : BaseEntityController<Author>
    {
        IBaseService<Author> _baseService;
        public AuthorsController(IBaseService<Author> baseService): base(baseService)
        {
            _baseService = baseService;
        }
    }
}
