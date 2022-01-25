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
    public class GenressController : BaseEntityController<Genres>
    {
        #region Declare
        IGenresService _genresService;
        #endregion
        #region Constructor
        public GenressController(IGenresService genresService): base(genresService)
        {
            _genresService = genresService;
        }
        #endregion

    }
}
