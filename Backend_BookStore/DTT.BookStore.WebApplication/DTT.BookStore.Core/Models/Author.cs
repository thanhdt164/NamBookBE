using System;
using System.Collections.Generic;
using System.Text;

namespace DTT.BookStore.Core.Models
{
    public class Author
    {
        public int author_id { get; set; }
        public string author_nm { get; set; }
        public string author_about { get; set; }
        public string avatar { get; set; }
        public string bg_image { get; set; }
        public DateTime? created_at { get; set; }
        public DateTime? updated_at { get; set; }
        public DateTime? deleted_at { get; set; }
    }
}
