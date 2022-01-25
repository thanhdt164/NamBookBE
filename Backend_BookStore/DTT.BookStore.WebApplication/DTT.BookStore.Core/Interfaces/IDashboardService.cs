using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTT.BookStore.Core.Interfaces
{
    public interface IDashboardService : IBaseService<object>
    {
        /// <summary>
        /// Thống kê top sách bán được nhiều nhất
        /// (Created by: thanhdt - 22.05.2021)
        /// </summary>
        /// <returns></returns>
        IEnumerable<object> getTopBookSold(DateTime fromTime, DateTime toTime, int top);
        /// <summary>
        /// Thống kê khoản thu chi
        /// (Created by: thanhdt - 22.05.2021)
        /// </summary>
        /// <returns></returns>
        IEnumerable<object> reportRevenueAndSpending(DateTime fromTime, DateTime toTime);
        /// <summary>
        /// Thống kê sách nhập vào
        /// (Created by: thanhdt - 22.05.2021)
        /// </summary>
        /// <returns></returns>
        IEnumerable<object> getBookImport(DateTime fromTime, DateTime toTime);
        /// <summary>
        /// Thống kê tổng chi tiêu
        /// (Created by: thanhdt - 22.05.2021)
        /// </summary>
        /// <returns></returns>
        IEnumerable<object> getSpending(DateTime fromTime, DateTime toTime, int reportType);

        /// <summary>
        /// Thống kê tổng doanh thu
        /// (Created by: thanhdt - 22.05.2021)
        /// </summary>
        /// <returns></returns>
        IEnumerable<object> getRevenue(DateTime fromTime, DateTime toTime, int reportType);
    }
}
