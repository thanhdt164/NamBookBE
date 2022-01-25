using System;
using System.Collections.Generic;
using System.Text;

namespace DTT.BookStore.Core.Models
{
    public class Book
    {
        public int book_id { get; set; }
        public string book_nm { get; set; }
        public string subtitle { get; set; }
        public string avatar { get; set; }
        public string images { get; set; }
        public string description { get; set; }
        public int? pages { get; set; }
        public string language { get; set; }
        public float? price { get; set; }
        public float? sale { get; set; }
        public DateTime? sale_expired { get; set; }
        public float? sale_money { get; set; }
        public int? view { get; set; }
        public int? sales { get; set; }
        public string isbn { get; set; }
        public DateTime? publishing_date { get; set; }
        public string content_protection { get; set; }
        public string genres_ids { get; set; }
        public int? author_id { get; set; }
        public string author_nm { get; set; }
        public int? publisher_id { get; set; }
        public string publisher_nm { get; set; }
        public int? rate_id { get; set; }
        public int? comment_id { get; set; }
        public DateTime? created_at { get; set; }
        public DateTime? updated_at { get; set; }
        public DateTime? deleted_at { get; set; }
    }
}
