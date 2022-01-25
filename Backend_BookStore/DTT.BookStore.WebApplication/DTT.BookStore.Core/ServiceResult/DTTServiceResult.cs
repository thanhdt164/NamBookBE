using DTT.BookStore.Core.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace DTT.BookStore.Core.ServiceResult
{
    public class DTTServiceResult
    {
        public object ResultData { get; set; }
        public DTTCode ResultCode { get; set; }
        public string ResultMessage { get; set; }  
    }
}
