using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTT.BookStore.Core.Models
{
    public class TransactionHistory
    {
        public int transaction_history_id { get; set; }
        public int? user_id { get; set; }
        public string user_nm { get; set; }
        public int? orders_id { get; set; }
        public DateTime? orders_date { get; set; }
        public float? total_price { get; set; }
        public float? orders_sale { get; set; }
        public float? real_price { get; set; }
        public int? status { get; set; }
        public DateTime? created_at { get; set; }
        public DateTime? updated_at { get; set; }
        public DateTime? deleted_at { get; set; }
    }
}
