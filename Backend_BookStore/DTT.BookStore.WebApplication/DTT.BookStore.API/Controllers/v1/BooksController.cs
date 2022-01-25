using DTT.BookStore.Core.Interfaces;
using DTT.BookStore.Core.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Json.Serialization;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DTT.BookStore.API.Controllers.v1
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class BooksController : BaseEntityController<Book>
    {
        IBookService _bookService;

        public BooksController(IBookService bookService): base (bookService)
        {
            _bookService = bookService;
        }

        #region Methods 
        [HttpGet("homebooks")]
        public IActionResult getHomeBooks()
        {
           return  Ok(_bookService.getHomeBooks());
        }

        [HttpGet("top-chart")]
        public IActionResult getTopChart()
        {
            return Ok(_bookService.getTopChart());
        }
        
        [HttpGet("top-arrivals")]
        public IActionResult getTopArrivals()
        {
            return Ok(_bookService.getTopArrivals());
        }

        [HttpPost("similars")]
        public IActionResult getSimilarBooks([FromBody] int[] genresIds)
        {
            var result = new ArrayList();
            int[] intGenresIds = genresIds;
            foreach (int genresid in intGenresIds)
            {
               var books = _bookService.getSimilarBooks(genresid);
                result.AddRange((ICollection)books);
            }
            
            Random rnd = new Random();
            var count = result.Count;
            while(count > 1)
            {
                count--;
                var pos = rnd.Next(count + 1);
                var value = result[pos];
                result[pos] = result[count];
                result[count] = value;
            }
            return Ok(result);
        }
        [HttpPost("bookinfor")]
        public IActionResult getBookInfor([FromBody] int bookId)
        {
            var result = _bookService.getBookInfor(bookId);
            return Ok(result.FirstOrDefault());
        }
        [HttpPost("bookbygenres")]
        public IActionResult getBookByGenresId([FromBody] int genresId)
        {
            var result = _bookService.getBookByGenresId(genresId);
            return Ok(result);
        }

        [HttpPost("search")]
        public IActionResult search([FromBody] paramStringSearch param)
        {
            var result = _bookService.search(param);
            return Ok(result);
        }
        #endregion
    }
}
