using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTT.BookStore.Core.Models
{
    public class ParamGetBookImport
    {
        public DateTime fromTime { get; set; }
        public DateTime toTime { get; set; }
    }

    public class ParamGetTopBookSold
    {
        public DateTime fromTime { get; set; }
        public DateTime toTime { get; set; }
        public int top { get; set; }
    }

    public class ParamGetSpendingAndRevenue
    {
        public DateTime fromTime { get; set; }
        public DateTime toTime { get; set; }
        public int reportType { get; set; }
    }

    public class ParamAuthenticate
    {
        public string userName { get; set; }
        public string password { get; set; }
    }

    public class paramAccountName
    {
        public string accountName { get; set; }
    }

    public class paramInsertDetailOrders
    {
        public List<int> book_ids { get; set; }
        public int user_id { get; set; }
        public List<int> amounts { get; set; }
    }

    public class paramStringSearch
    {
        public string stringSearch { get; set; }
    }

    public class ParamComment
    {
        public int comment_id { get; set; }
        public string comment_json { get; set; }
    }
    
    public class ParamBook_Id
    {
        public int book_id { get; set; }
    }

    public class ParamInsertPayload
    {
        public int payload_id { get; set; }
        public int book_id { get; set; }
        public int amount { get; set; }
        public int import_price { get; set; }
    }
}
