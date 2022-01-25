using DTT.BookStore.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DTT.BookStore.Core.Interfaces
{
    public interface IBookRepository : IBaseRepository<Book>
    {
        /// <summary>
        /// Lấy dữ liệu sách hiển thị cho page Home
        /// (Created by: thanhdt - 01.05.2021)
        /// </summary>
        /// <returns></returns>
        IEnumerable<object> getHomeBooks();

        IEnumerable<object> getTopChart();
        IEnumerable<object> getTopArrivals();

        /// <summary>
        /// Lấy dữ liệu sách similars
        /// </summary>
        /// <returns></returns>
        IEnumerable<object> getSimilarBooks(int genresId, int[] genresExtractIds = null);
        /// <summary>
        /// Lấy thông tin đầy đủ của sách, bao gồm comment, rate, 
        /// </summary>
        /// <param name="bookId"></param>
        /// <returns></returns>
        IEnumerable<object> getBookInfor(int bookId);
        /// <summary>
        /// Lấy danh sách sách theo genresId
        /// </summary>
        /// <param name="genresId"></param>
        /// <returns></returns>
        IEnumerable<object> getBookByGenresId(int genresId);

        IEnumerable<object> search(paramStringSearch param);
    }
}
