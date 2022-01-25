using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTT.BookStore.Core.Models
{
    public class User
    {
        public int user_id { get; set; }
        public string user_nm { get; set; }
        public string user_avatar { get; set; }
        public string email { get; set; }
        public int? gender { get; set; }
        public string phone_number { get; set; }
        public string address { get; set; }
        public int? account_id { get; set; }
        public string role_ids { get; set; }
        public string role_nm { get; set; }
        public DateTime? created_at { get; set; }
        public DateTime? updated_at { get; set; }
        public DateTime? deleted_at { get; set; }
    }
}
