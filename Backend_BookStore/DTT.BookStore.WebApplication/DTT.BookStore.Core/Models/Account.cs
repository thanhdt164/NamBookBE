using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTT.BookStore.Core.Models
{
    public class Account
    {
        public int account_id { get; set; }
        public string account_nm { get; set; }
        public string password { get; set; }
        public string role_ids { get; set; }
        public string role_nm { get; set; }
        public int? cart_id { get; set; }
        public DateTime created_at { get; set; }
        public DateTime updated_at { get; set; }
        public DateTime deleted_at { get; set; }
    }
}
