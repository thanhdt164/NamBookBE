using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTT.BookStore.Core.Models
{
    public class Storage
    {
        public int book_id { get; set; }
        public string book_nm { get; set; }
        public string book_avatar { get; set; }
        public int? amount { get; set; }
        public DateTime? created_at { get; set; }
        public DateTime? updated_at { get; set; }
        public DateTime deleted_at { get; set; }
    }
}
