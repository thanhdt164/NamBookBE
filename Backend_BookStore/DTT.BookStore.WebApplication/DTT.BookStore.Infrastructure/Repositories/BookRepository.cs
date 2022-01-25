using DTT.BookStore.Core.Interfaces;
using DTT.BookStore.Core.Models;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;
using Dapper;
using System.Data;
using MySql.Data.MySqlClient;
using System.Linq;
using System.Collections;

namespace DTT.BookStore.Infrastructure.Repositories
{
    public class BookRepository : BaseRepository<Book>, IBookRepository
    {
        #region Declare
        
        #endregion
        #region Constructor
        public BookRepository(IConfiguration configuration) : base(configuration){}

        #endregion
        #region Methods
        public IEnumerable<object> getHomeBooks()
        {
            var result = new ArrayList();
            int[] genresIds = { 1, 2, 3, 4, 5 };
            for( int id = 0; id < genresIds.Length; id++)
            {
                var rs = new ArrayList();
                var genresId = genresIds[id];
                var genresName = _dbConnection.Query<object>($"select genres_id, genres_nm from tblgenres where genres_id = {genresId}", commandType: CommandType.Text);
                var genresExtractIds = genresIds.Where((source, index) => index != id).ToArray();
                var books = getSimilarBooks(genresId, genresExtractIds);
                rs.AddRange((ICollection)genresName);
                rs.AddRange((ICollection)books);
                result.Add(rs);

            }
            return result.Cast<Object>();
        }
        public IEnumerable<object> getTopChart()
        {
            var result = new ArrayList();
            // TOP sách free
            var frees = _dbConnection.Query<object>("Proc_GetTopFree", commandType: CommandType.StoredProcedure);
            result.Add(frees);
            // TOP sách có nhiều lượt xem gần đây
            var books2 = _dbConnection.Query<object>("Proc_GetTopView", commandType: CommandType.StoredProcedure);
            result.Add(books2);
            // TOP sách được nhiều người mua
            var books4 = _dbConnection.Query<object>("Proc_GetTopSales", commandType: CommandType.StoredProcedure);
            result.Add(books4);
            // TOP sách có đánh giá tốt
            //var books3 = _dbConnection.Query<object>("Proc_GetTopFree", commandType: CommandType.StoredProcedure);
            //result.Add(books3);
            
            return result.Cast<Object>();
        }

        public IEnumerable<object> getTopArrivals()
        {
            var result = new ArrayList();
            // TOP sách free
            var arrivals = _dbConnection.Query<object>("Proc_GetTopArrivals", commandType: CommandType.StoredProcedure);
            result.Add(arrivals);

            return result.Cast<Object>();
        }

        public IEnumerable<object> getSimilarBooks(int genresId, int[] genresExtractIds = null)
        {
            var sql = $"SELECT DISTINCT *, tc.comment_json FROM `tblbook` tb JOIN tblcomment tc on tb.comment_id = tc.comment_id WHERE tb.genres_ids like '%{genresId}%'";
            // Loại bỏ những book có genresId trùng
            if ( genresExtractIds != null)
            {
                foreach ( int genresExtractId in genresExtractIds)
                {
                    sql += $" and tb.genres_ids not like '%{genresExtractId}%'";
                }
            }
            sql += " ORDER BY RAND() Limit 10";
            var books = _dbConnection.Query<object>(sql, commandType: CommandType.Text);
            return books;
        }
        public IEnumerable<object> getBookInfor(int bookId)
        {
            var result = _dbConnection.Query<object>("Proc_GetBookInfor", param: new { BookId = bookId }, commandType: CommandType.StoredProcedure);
            return result;
        }

        public IEnumerable<object> getBookByGenresId(int genresId)
        {
            var result = new ArrayList();
            var books = _dbConnection.Query<object>("Proc_GetBookByGenresId", param: new { GenresId = genresId }, commandType: CommandType.StoredProcedure);
            var genresName = _dbConnection.Query<object>($"select genres_id, genres_nm from tblgenres where genres_id = {genresId}", commandType: CommandType.Text);
            result.AddRange((ICollection)genresName);
            result.AddRange((ICollection)books);
            return result.Cast<Object>();
        }

        public IEnumerable<object> search(paramStringSearch param)
        {
            var sql = $"select * from tblbook b where b.book_nm like '%{param.stringSearch}%' " +
                $"or b.author_nm LIKE '%{param.stringSearch}%' " +
                $"or b.publisher_nm LIKE '%{param.stringSearch}%'";

            var books = _dbConnection.Query<object>(sql, commandType: CommandType.Text);
            return books.Cast<Object>();
        }

        public override int Insert(Book b)
        {
            var sql = $"Insert into tblbook " +
                $"(book_nm, avatar, description, pages, language, price, sale, sale_expired, sale_money, isbn, publishing_date, content_protection, author_id, author_nm publisher_id, publisher_nm, genres_ids, comment_id) " +
                $"values " +
                $"('{b.book_nm}','{b.avatar}','{b.description}',{b.pages},'{b.language}',{b.price},{b.sale},'{b.sale_expired}',{b.sale_money},'{b.isbn}'," +
                $"'{b.publishing_date}','{b.content_protection}',{b.author_id},'{b.author_nm}',{b.publisher_id},'{b.publisher_nm}','{b.genres_ids}',{b.comment_id})";
            var rowAffects = _dbConnection.Execute(sql, commandType: CommandType.Text);
            return rowAffects;
        }

        #endregion
    }
}
