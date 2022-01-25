using DTT.BookStore.Core.Interfaces;
using DTT.BookStore.Core.Models;
using DTT.BookStore.Core.ServiceResult;
using System;
using System.Collections.Generic;
using System.Text;

namespace DTT.BookStore.Core.Services
{
    public class BookService : BaseService<Book>, IBookService
    {
        IBookRepository _bookRepository;
        public BookService(IBookRepository bookRepository) : base(bookRepository)
        {
            _bookRepository = bookRepository;
        }


        public IEnumerable<object> getHomeBooks()   
        {
            return _bookRepository.getHomeBooks();
        }

        public IEnumerable<object> getTopChart()
        {
            return _bookRepository.getTopChart();
        }
        
        public IEnumerable<object> getTopArrivals()
        {
            return _bookRepository.getTopArrivals();
        }

        public IEnumerable<object> getSimilarBooks(int genresId, int[] genresExtractIds = null)
        {
            return _bookRepository.getSimilarBooks(genresId, genresExtractIds);
        }

        public IEnumerable<object> getBookInfor(int bookId)
        {
            return _bookRepository.getBookInfor(bookId);
        }

        public IEnumerable<object> getBookByGenresId(int genresId)
        {
            return _bookRepository.getBookByGenresId(genresId);
        }
        
        public IEnumerable<object> search(paramStringSearch param)
        {
            return _bookRepository.search(param);
        }
    }
}
