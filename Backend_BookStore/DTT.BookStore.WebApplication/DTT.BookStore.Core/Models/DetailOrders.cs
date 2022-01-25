using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTT.BookStore.Core.Models
{
    public class DetailOrders
    {
        public int orders_id { get; set; }
        public int book_id { get; set; }
        public string book_nm { get; set; }
        public string book_avatar { get; set; }
        public int? payload_id { get; set; }
        public int? user_id { get; set; }
        public string user_nm { get; set; }
        public int? amount { get; set; }
        public float? price { get; set; }
        public float? sale { get; set; }
        public DateTime? sale_expired { get; set; }
        public float? sale_money { get; set; }
        public DateTime? orders_date { get; set; }
        public float? multi_price { get; set; }
        public DateTime? created_at { get; set; }
        public DateTime? updated_at { get; set; }
        public DateTime? deleted_at { get; set; }
    }
}
